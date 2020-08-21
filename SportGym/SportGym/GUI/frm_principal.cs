using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using SportGym.Service;
using SportGym.DataTransferObject;
using SportGym.GUI.Socio;
using SportGym.GUI.Cuota;
using SportGym.GUI.Horarios;

namespace SportGym.GUI
{
    public partial class frm_principal : Form
    {

        Support support = Support.GetSupport();
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void panel_titulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private Service_Inscripcion svInscripcion;
        private Service_cuota svCuota;
        private Service_socio svSocio;
        public frm_principal()
        {
            InitializeComponent();
            svInscripcion = new Service_Inscripcion();
            svCuota = new Service_cuota();
            svSocio = new Service_socio();
            this.cargarGrillaInscripciones();
            Form aux = new frm_horarios_automaticos();
            aux.Show();
            //this.WindowState = FormWindowState.Maximized; para que la ventana inicie maximizada
        }

        
        private void pic_close_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Desea cerrar la aplicacion?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if(resultado == DialogResult.Yes)
            {
                Application.Exit();
            }          
        }

        
        private void pic_min_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void pic_maximizar_Click(object sender, EventArgs e)
        {
            pic_restaurar.Visible = true;
            pic_maximizar.Visible = false;
            this.WindowState = FormWindowState.Maximized;
        }
        private void pic_restaurar_Click(object sender, EventArgs e)
        {
            pic_restaurar.Visible = false;
            pic_maximizar.Visible = true;
            this.WindowState = FormWindowState.Normal;
        }

      

        private void btn_cuotas_Click(object sender, EventArgs e)
        {       
                panel_cuota.Visible = true;
                panel_botones_cuota.Visible = true;

        }

        private void cargarGrillaInscripciones()
        {
            IList<DTO_Inscripcion> inscripciones = svInscripcion.getInscripciones();
            dgv_inscripciones.Rows.Clear();
            if(inscripciones != null)
            {
                foreach (DTO_Inscripcion dto in inscripciones)
                {
                    dgv_inscripciones.Rows.Add(new Object[]
                            {
                            dto.NroSocio.ToString(),
                            dto.NombreSocio.ToString(),
                            dto.ApellidoSocio.ToString(),
                            dto.UltimoVencimiento.ToString(),
                            dto.EstadoCuota.ToString(),
                            dto.UltimoPago.ToString()
                            }
                        );
                }
            }
            else
            {
                MessageBox.Show("No hay datos para mostrar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
      
        private void dgv_inscripciones_CellFormatting_1(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgv_inscripciones.Columns[e.ColumnIndex].Name == "col_estado")
            {
                if (String.Equals(e.Value, "VENCIDA") == true)
                {
                    e.CellStyle.BackColor = Color.LightPink;

                    //las lineas de abajo son para hacer negrita la fila de estado
                    //DataGridViewCellStyle style = new DataGridViewCellStyle();

                    //style.Font = new Font(dgv_inscripciones.Font, FontStyle.Bold);

                    //dgv_inscripciones.Columns[4].DefaultCellStyle = style;
                }
                else
                {
                    if (String.Equals(e.Value, "VENCE HOY") == true)
                    {
                        e.CellStyle.BackColor = Color.Yellow;
                    }
                    else
                    {
                        if (String.Equals(e.Value, "NO TIENE CUOTAS") == true)
                        {
                            e.CellStyle.BackColor = Color.Cyan;
                        }
                        else
                        {
                            e.CellStyle.BackColor = Color.LightGreen;
                        }

                    }
                }
            }
        }

        private void dgv_inscripciones_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            habilitarBotonesCuota();
        }
        private void habilitarBotonesCuota()
        {
            if (dgv_inscripciones.CurrentRow != null)
            {
                btn_pagar_cuota.Enabled = true;
                btn_pagar_cuota.BackColor = Color.FromArgb(51, 153, 255);
                txt_monto_pagar.Enabled = true;
                dtp_fecha_inicio.Enabled = true;
                dtp_fecha_vto.Enabled = true;
                dtp_fecha_vto.Value = dtp_fecha_inicio.Value.AddMonths(1);
            }
            else
            {
                btn_pagar_cuota.Enabled = false;
                txt_monto_pagar.Enabled = false;
                dtp_fecha_inicio.Enabled = false;
                dtp_fecha_vto.Enabled = false;
            }
        }

        private void btn_pagar_cuota_Click(object sender, EventArgs e)
        {
            bool control = false; //variable para controlar el resultado 
            if (dgv_inscripciones.CurrentRow != null)//valido que haya seleccionado una fila
            {
                int nroS = Convert.ToInt32(dgv_inscripciones.CurrentRow.Cells["col_nro_socio"].Value.ToString());
                string nombre = dgv_inscripciones.CurrentRow.Cells["col_nombre"].Value.ToString();
                string apellido = dgv_inscripciones.CurrentRow.Cells["col_apellido"].Value.ToString();
                int nroI = Convert.ToInt32(svSocio.getSocio(nroS).Inscripcion);
                if (svCuota.tieneQuePagar(nroS) == false)//valido que el socio tenga la cuota vencida
                {
                    MessageBox.Show("La ultima cuota no se encuentra vencida", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    txt_monto_pagar.Clear();
                }
                else
                {
                    if (support.esUnNumero(txt_monto_pagar.Text) == true)
                    {
                        if (String.IsNullOrEmpty(txt_monto_pagar.Text) || Convert.ToDouble(txt_monto_pagar.Text) < 0)
                        {
                            MessageBox.Show("No ingreso un monto valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txt_monto_pagar.Clear();
                        }
                        else
                        {
                            DialogResult respuesta = MessageBox.Show("¿Desea registrar el pago de " +nombre+" "+apellido + "?", "Atencion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (respuesta == DialogResult.Yes)
                            {
                                DTO_Pagar_Cuota dtoNuevaCuota = new DTO_Pagar_Cuota();
                                dtoNuevaCuota.NroSocio = nroS.ToString();
                                dtoNuevaCuota.NroInscripcion = nroI.ToString();
                                dtoNuevaCuota.FechaInicio = dtp_fecha_inicio.Value.ToString();
                                dtoNuevaCuota.FechaFin = dtp_fecha_vto.Value.ToString();
                                dtoNuevaCuota.Monto = txt_monto_pagar.Text;
                                control = svCuota.registrarNuevaCuota(dtoNuevaCuota);
                                if (control == true)
                                {
                                    MessageBox.Show("Pago registrado con exito", "Exito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    dgv_inscripciones.Rows.Clear();
                                    cargarGrillaInscripciones();
                                    txt_monto_pagar.Clear();
                                }
                                else
                                {
                                    MessageBox.Show("Error al registrar el pago, intente nuevamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    txt_monto_pagar.Clear();
                                }
                            }
                        }
                    }
                    else
                    {
                        txt_monto_pagar.Clear();
                    }
                }
            }
            else
            {
                MessageBox.Show("No selecciono ningun socio", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }       
        }

        

        private void btn_socios_Click(object sender, EventArgs e)
        {
            Form aux = new frm_principal_socio();
            aux.ShowDialog();      
        }

        private void txt_monto_pagar_KeyPress(object sender, KeyPressEventArgs e)
        {
            support.soloNumeros(sender,e);
        }

        private void btn_historial_pago_socio_Click(object sender, EventArgs e)
        {
            if (dgv_inscripciones.CurrentRow != null)
            {
                int id = Convert.ToInt32(dgv_inscripciones.CurrentRow.Cells["col_nro_socio"].Value.ToString());
                string nombre = dgv_inscripciones.CurrentRow.Cells["col_nombre"].Value.ToString() + " " + dgv_inscripciones.CurrentRow.Cells["col_apellido"].Value.ToString();
                Form historial = new frm_historial_pagos(id, nombre);
                historial.ShowDialog();
            }
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Desea salir?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (resultado == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_fecha.Text = DateTime.Now.ToShortDateString();
            lbl_hora_chico.Text = DateTime.Now.ToLongTimeString();
        }

        private void frm_principal_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void btn_horarios_Click(object sender, EventArgs e)
        {
            Form horario = new frm_horarios();
            horario.Show();
        }

        private void btn_covid_Click(object sender, EventArgs e)
        {
            Form aux = new frm_horarios_automaticos();
            aux.Show();
        }

        private void btn_vencidos_Click(object sender, EventArgs e)
        {
            Form aux = new frm_vencidos();
            aux.Show();
        }

        private void btn_refresh_socio_Click(object sender, EventArgs e)
        {
            cargarGrillaInscripciones();
        }

        private void btn_estadisticas_Click(object sender, EventArgs e)
        {
            Form aux = new frm_estadisticas();
            aux.Show();
        }
    }
}
