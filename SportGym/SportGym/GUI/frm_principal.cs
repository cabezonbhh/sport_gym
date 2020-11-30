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
using System.IO;
using System.Globalization;
using SportGym.Interface;

namespace SportGym.GUI
{
    public partial class frm_principal : Form, IForm
    {

        Support support = Support.GetSupport();


        private Service_Inscripcion svInscripcion;
        private Service_cuota svCuota;
        private Service_socio svSocio;


        public frm_principal()
        {
            InitializeComponent();
            svInscripcion = new Service_Inscripcion();
            svCuota = new Service_cuota();
            svSocio = new Service_socio();
        }
        private void llenarCombos()
        {
            support.cargarComboHorarios(combo_inicio,combo_fin);
        }

        private void pic_close_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Desea cerrar la aplicacion?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (resultado == DialogResult.Yes)
            {
                Application.Exit();
            }
        }


        private void cargarGrillaInscripciones(IList<DTO_Inscripcion> lista)
        {
            IList<DTO_Inscripcion> inscripciones = lista;
            dgv_inscripciones.Rows.Clear();
            if (inscripciones != null && inscripciones.Count > 0)
            {
                int contador = 1;
                habilitarBotonesNoError();
                foreach (DTO_Inscripcion dto in inscripciones)
                {
                    dgv_inscripciones.Rows.Add(new Object[]
                            {
                                dto.CodInscripcion.ToString(),
                                contador.ToString(),
                                Convert.ToInt32(dto.NroSocio).ToString(),
                                dto.NombreSocio.ToString(),
                                dto.ApellidoSocio.ToString(),
                                dto.UltimoVencimiento.ToString(),
                                dto.EstadoCuota.ToString(),
                                dto.UltimoPago.ToString(),
                                dto.HoraInicio.ToString(),
                                dto.HoraFin.ToString()
                            }
                        );
                    contador++;
                }
            }        
        }


        private void dgv_inscripciones_CellFormatting_1(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //este primer if es para pintar la columna de estado del socio col_deuda
            if (dgv_inscripciones.Columns[e.ColumnIndex].Name == "col_estado")
            {
                if (String.Equals(e.Value, "VENCIDA") == true)
                {
                    e.CellStyle.BackColor = Color.LightPink;
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
            if (dgv_inscripciones.CurrentRow != null && dgv_inscripciones.CurrentRow.Cells["col_fecha_vto"].Value.ToString().Equals("N/D") != true)
            {
                dtp_fecha_inicio.Value = Convert.ToDateTime(dgv_inscripciones.CurrentRow.Cells["col_fecha_vto"].Value.ToString());
            }
            else
            {
                dtp_fecha_inicio.Value = DateTime.Now;
            }

        }

        private void habilitarBotonesNoError()
        {
            btn_historial_pago_socio.Enabled = true;
            btn_horarios.Enabled = true;
            btn_vencidos.Enabled = true;
            btn_estadisticas.Enabled = true;
            btn_actualizar.Enabled = true;
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


        private void btn_socios_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frm_principal_socio);
            if (frm == null || frm.IsDisposed == true)
            {
                frm = new frm_principal_socio(this);
                frm.ShowDialog();
            }
            else
            {
                frm.BringToFront();
            }
        }

        private void txt_monto_pagar_KeyPress(object sender, KeyPressEventArgs e)
        {
            support.soloNumeros(sender, e);
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
            else
            {
                MessageBox.Show("No selecciono un socio", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
            llenarCombos();
            cargarGrillaInscripciones(svInscripcion.getInscripciones());
            svInscripcion.respaldar();
            WindowState = System.Windows.Forms.FormWindowState.Maximized;
            timer1.Start();
        }

        private void btn_horarios_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frm_horarios);
            if (frm == null || frm.IsDisposed == true)
            {
                frm = new frm_horarios(this);
                frm.Show();
            }
            else
            {
                frm.BringToFront();
            }
        }



        private void btn_vencidos_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frm_vencidos);
            if (frm == null || frm.IsDisposed == true)
            {
                frm = new frm_vencidos();
                frm.Show();
            }
            else
            {
                frm.BringToFront();
            }
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            if (combo_inicio.SelectedIndex != -1 && combo_fin.SelectedIndex != -1)
            {
                this.cargarGrillaInscripciones(svInscripcion.getInscripcionesPorHora(combo_inicio.SelectedItem.ToString(), combo_fin.SelectedItem.ToString()));
            }
            else
            {
                cargarGrillaInscripciones(svInscripcion.getInscripciones());
            }
            txt_filtro_apellido.Clear();
            txt_filtro_nombre.Clear();
        }

        private void btn_exportar_excel_Click(object sender, EventArgs e)
        {
            bool resultado = false;

            IList<DTO_Inscripcion> inscripciones = svInscripcion.getInscripciones();
            if(inscripciones != null && inscripciones.Count > 0)
            {
                SaveFileDialog fichero = new SaveFileDialog();
                fichero.Filter = "Excel (*.xls)|*.xls";
                if (fichero.ShowDialog() == DialogResult.OK)
                {
                    resultado = support.guardarEnExcel(inscripciones, fichero.FileName);
                    if (resultado == true)
                        MessageBox.Show("Se creo el Archivo Excel exitosamente","Excel",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Error al crear el archivo Excel, intente nuevamente", "Excel", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        else
            {
                MessageBox.Show("No hay datos para guardar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_filtro_nombre_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(txt_filtro_nombre.Text))
            {
                this.cargarGrillaInscripciones(svInscripcion.getInscripcionesPorNombre(txt_filtro_nombre.Text));
                combo_inicio.SelectedIndex = -1;
                combo_inicio.Enabled = false;
                combo_fin.SelectedIndex = -1;
                combo_fin.Enabled = false;
            }
            else
            {
                dgv_inscripciones.Rows.Clear();
                this.cargarGrillaInscripciones(svInscripcion.getInscripciones());
                combo_inicio.SelectedIndex = -1;
                combo_inicio.Enabled = true;
                combo_fin.SelectedIndex = -1;
                combo_fin.Enabled = true;
            }
        }

        private void txt_filtro_apellido_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(txt_filtro_apellido.Text))
            {
                this.cargarGrillaInscripciones(svInscripcion.getInscripcionesPorApellido(txt_filtro_apellido.Text));
            }
            else
            {
                dgv_inscripciones.Rows.Clear();
                this.cargarGrillaInscripciones(svInscripcion.getInscripciones());
            }
        }

        private void txt_filtro_nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            support.soloLetrasSiEspacio(sender, e);
        }

        private void txt_filtro_apellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            support.soloLetrasSiEspacio(sender, e);
        }

        private void btn_estadisticas_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frm_estadisticas);
            if (frm == null || frm.IsDisposed == true)
            {
                frm = new frm_estadisticas();
                frm.Show();
            }
            else
            {
                frm.BringToFront();
            }
        }

        private void dgv_inscripciones_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_inscripciones.CurrentRow != null)
            {
                int id = Convert.ToInt32(dgv_inscripciones.CurrentRow.Cells["col_cod_inscripcion"].Value.ToString());
                if (id > 0)
                {
                    Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frm_detalle_cuota);
                    if (frm == null || frm.IsDisposed == true)
                    {
                        frm = new frm_detalle_cuota(id,this);
                        frm.Show();
                    }
                    else
                    {
                        frm.BringToFront();
                    }
                }
                else
                {
                    MessageBox.Show("Inscripcion no valida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("No selecciono ningun socio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btn_filtrar_Click(object sender, EventArgs e)
        {
            if (combo_inicio.SelectedIndex != -1 && combo_fin.SelectedIndex != -1)
            {
                txt_filtro_nombre.Clear();

                txt_filtro_apellido.Clear();

                this.cargarGrillaInscripciones(svInscripcion.getInscripcionesPorHora(combo_inicio.SelectedItem.ToString(), combo_fin.SelectedItem.ToString()));
            }
            else
            {
                MessageBox.Show("Falta la Hora de Inicio o Fin", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void actualizarDatos()
        {
            if (combo_inicio.SelectedIndex != -1 && combo_fin.SelectedIndex != -1)
            {
                this.cargarGrillaInscripciones(svInscripcion.getInscripcionesPorHora(combo_inicio.SelectedItem.ToString(), combo_fin.SelectedItem.ToString()));
            }
            else
            {
                cargarGrillaInscripciones(svInscripcion.getInscripciones());
            }
        }

        private void combo_inicio_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(combo_inicio.SelectedIndex != -1)
            {
                combo_fin.SelectedItem = (Convert.ToDateTime(combo_inicio.SelectedItem.ToString()).AddHours(1)).ToString("HH:mm");
            }
        }

        private void dgv_inscripciones_CurrentCellChanged(object sender, EventArgs e)
        {
            if (dgv_inscripciones.CurrentRow != null && dgv_inscripciones.CurrentRow.Cells["col_fecha_vto"].Value.ToString().Equals("N/D") != true)
            {
                dtp_fecha_inicio.Value = Convert.ToDateTime(dgv_inscripciones.CurrentRow.Cells["col_fecha_vto"].Value.ToString());
                dtp_fecha_vto.Value = dtp_fecha_inicio.Value.AddMonths(1);
            }
            else
            {
                dtp_fecha_inicio.Value = DateTime.Now;
                dtp_fecha_vto.Value = dtp_fecha_inicio.Value.AddMonths(1);
            }
        }

        private void dtp_fecha_inicio_ValueChanged(object sender, EventArgs e)
        {
            if(dtp_fecha_inicio.Value != null)
            {
                dtp_fecha_vto.Value = dtp_fecha_inicio.Value.AddMonths(1);
            }
        }

        private void frm_principal_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                txt_filtro_nombre.Size = new Size(140, 26);
                txt_filtro_nombre.Location = new Point(80, 25);
                var x = txt_filtro_nombre.Location.X;
                var y = txt_filtro_nombre.Location.Y;
                lbl_filtro_nombre.Location = new Point(x - 65, y + 3);


                txt_filtro_apellido.Size = new Size(140, 26);
                txt_filtro_apellido.Location = new Point(x + 210, y);
                x = txt_filtro_apellido.Location.X;
                lbl_filtro_apellido.Location = new Point(x - 65, y + 3);

                dtp_fecha_inicio.Location = new Point(x + 230, y);
                x = dtp_fecha_inicio.Location.X;
                lbl_fecha_inicio.Location = new Point(x - 85, y + 3);

                dtp_fecha_vto.Location = new Point(x + 215, y);
                x = dtp_fecha_vto.Location.X;
                lbl_fecha_fin.Location = new Point(x - 70, y + 3);

                txt_monto_pagar.Location = new Point(x + 210, y);
                x = txt_monto_pagar.Location.X;
                lbl_monto.Location = new Point(x - 60, y + 3);

                btn_pagar_cuota.Location = new Point(x, 60);
                btn_pagar_cuota.Size = new Size(100, 26);
                x = btn_pagar_cuota.Location.X;              
            }
            else
            {
                txt_filtro_nombre.Size = new Size(140, 26);
                txt_filtro_nombre.Location = new Point(78, 12);
                lbl_filtro_nombre.Location = new Point(11,15);

                txt_filtro_apellido.Size = new Size(140, 26);
                txt_filtro_apellido.Location = new Point(78, 52);
                lbl_filtro_apellido.Location = new Point(11, 55);

                dtp_fecha_inicio.Location = new Point(324,12);
                lbl_fecha_inicio.Location = new Point(235,15);

                dtp_fecha_vto.Location = new Point(324,52);
                lbl_fecha_fin.Location = new Point(250,55);

                txt_monto_pagar.Location = new Point(533,35);
                lbl_monto.Location = new Point(473,38);
                btn_pagar_cuota.Location = new Point(639,12);
                btn_pagar_cuota.Size = new Size(78, 70);
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
                    DialogResult respuesta = MessageBox.Show("La cuota no se encuentra vencida. ¿ Desea registrar el cobro de igual forma?", "Atencion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (respuesta == DialogResult.Yes)
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
                                if (dtp_fecha_vto.Value < dtp_fecha_inicio.Value)
                                {
                                    MessageBox.Show("No selecciono fechas o la fecha de vencimiento es anterior a la de inicio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                else
                                {
                                    respuesta = MessageBox.Show("¿Desea registrar el pago de " + nombre + " " + apellido + "?", "Atencion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
                                            if (combo_inicio.SelectedIndex != -1 && combo_fin.SelectedIndex != -1)
                                            {
                                                this.cargarGrillaInscripciones(svInscripcion.getInscripcionesPorHora(combo_inicio.SelectedItem.ToString(), combo_fin.SelectedItem.ToString()));
                                            }
                                            else
                                            {
                                                cargarGrillaInscripciones(svInscripcion.getInscripciones());
                                            }
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
                        }
                    }
                    else
                    {
                        txt_monto_pagar.Clear();
                    }
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
                            if (dtp_fecha_vto.Value < dtp_fecha_inicio.Value)
                            {
                                MessageBox.Show("No selecciono fechas o la fecha de vencimiento es anterior a la de inicio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                DialogResult respuesta = MessageBox.Show("¿Desea registrar el pago de " + nombre + " " + apellido + "?", "Atencion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
                                        if (combo_inicio.SelectedIndex != -1 && combo_fin.SelectedIndex != -1)
                                        {
                                            this.cargarGrillaInscripciones(svInscripcion.getInscripcionesPorHora(combo_inicio.SelectedItem.ToString(), combo_fin.SelectedItem.ToString()));
                                        }
                                        else
                                        {
                                            cargarGrillaInscripciones(svInscripcion.getInscripciones());
                                        }
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
    }
}
