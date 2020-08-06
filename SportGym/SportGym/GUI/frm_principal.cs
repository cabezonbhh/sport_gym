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

namespace SportGym.GUI
{
    public partial class frm_principal : Form
    {
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
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        

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

        private void panel_titulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle,0x112,0xf012,0); 
        }

        private void btn_cuotas_Click(object sender, EventArgs e)
        {
            if (panel_cuota.Visible == false)
            {
                panel_cuota.Visible = true;
                //panel_socio.Visible = false;
            }               
        }

        private void btn_socios_Click(object sender, EventArgs e)
        {
            //if (panel_socio.Visible == false)
            {
                panel_cuota.Visible = false;
                //panel_socio.Visible = true;
            }
        }
        private void cargarGrillaInscripciones()
        {
            IList<DTO_Inscripcion> inscripciones = svInscripcion.getInscripciones();
            dgv_inscripciones.Rows.Clear();
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
            bool control = false;

                if (String.IsNullOrEmpty(txt_monto_pagar.Text) || Convert.ToDouble(txt_monto_pagar.Text) < 0)
                {
                    MessageBox.Show("No ingreso un monto valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    DialogResult respuesta = MessageBox.Show("¿Desea registrar el pago?", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Question); ;
                    if (respuesta == DialogResult.Yes)
                    {
                        int nroS = Convert.ToInt32(dgv_inscripciones.CurrentRow.Cells["col_nro_socio"].Value.ToString());
                        int nroI = Convert.ToInt32(svSocio.getSocio(nroS).Inscripcion);

                        if (svCuota.tieneQuePagar(nroS) == false)
                        {
                            MessageBox.Show("No tiene que pagar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        }
                        else
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
                                MessageBox.Show("Pago registrado con exito", "Exito!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                cargarGrillaInscripciones();
                            }                               
                            else
                            {
                                MessageBox.Show("Error al registrar el pago, intente nuevamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }                               
                        }
                    }      
                }           
        }
    }
}
