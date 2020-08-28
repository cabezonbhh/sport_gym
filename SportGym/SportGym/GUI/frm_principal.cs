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

namespace SportGym.GUI
{
    public partial class frm_principal : Form
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
            this.cargarGrillaInscripciones(svInscripcion.getInscripciones());
        }


        private void pic_close_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Desea cerrar la aplicacion?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (resultado == DialogResult.Yes)
            {
                Application.Exit();
            }
        }


        private void pic_min_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        private void btn_cuotas_Click(object sender, EventArgs e)
        {
            panel_botones_cuota.Visible = true;

        }

        private void cargarGrillaInscripciones(IList<DTO_Inscripcion> lista)
        {
            IList<DTO_Inscripcion> inscripciones = lista;
            dgv_inscripciones.Rows.Clear();
            if (inscripciones != null && inscripciones.Count > 0)
            {
                habilitarBotonesNoError();
                foreach (DTO_Inscripcion dto in inscripciones)
                {
                    dgv_inscripciones.Rows.Add(new Object[]
                            {
                            Convert.ToInt32(dto.NroSocio.ToString()),
                            dto.NombreSocio.ToString(),
                            dto.ApellidoSocio.ToString(),
                            dto.UltimoVencimiento.ToString(),
                            dto.EstadoCuota.ToString(),
                            dto.UltimoPago.ToString()
                            }
                        );
                }
            }        
        }
        

        private void dgv_inscripciones_CellFormatting_1(object sender, DataGridViewCellFormattingEventArgs e)
        {
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
                frm = new frm_principal_socio();
                frm.Show();
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
            timer1.Start();
        }

        private void btn_horarios_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frm_horarios);
            if (frm == null || frm.IsDisposed == true)
            {
                frm = new frm_horarios();
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
                                        cargarGrillaInscripciones(svInscripcion.getInscripciones());
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


        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            cargarGrillaInscripciones(svInscripcion.getInscripciones());
        }

        private void btn_exportar_excel_Click(object sender, EventArgs e)
        {
            SaveFileDialog fichero = new SaveFileDialog();
            fichero.Filter = "Excel (*.xls)|*.xls";
            IList<DTO_Inscripcion> inscripciones = svInscripcion.getInscripciones();

            if (fichero.ShowDialog() == DialogResult.OK)
            {
                if(inscripciones != null && inscripciones.Count > 0 )
                {
                    Microsoft.Office.Interop.Excel.Application aplicacion;
                    Microsoft.Office.Interop.Excel.Workbook libros_trabajo;
                    Microsoft.Office.Interop.Excel.Worksheet hoja_trabajo;
                    aplicacion = new Microsoft.Office.Interop.Excel.Application();
                    libros_trabajo = aplicacion.Workbooks.Add();
                    hoja_trabajo =
                        (Microsoft.Office.Interop.Excel.Worksheet)libros_trabajo.Worksheets.get_Item(1);

                    for (int i = 0; i < dgv_inscripciones.Rows.Count; i++)
                    {
                        for (int j = 0; j < dgv_inscripciones.Columns.Count; j++)
                        {
                            hoja_trabajo.Cells[i + 2, j + 1] = dgv_inscripciones.Rows[i].Cells[j].Value.ToString();
                        }
                    }
                    hoja_trabajo.Cells[1, "A"] = "Socio";
                    hoja_trabajo.Cells[1, "B"] = "Nombre";
                    hoja_trabajo.Cells[1, "C"] = "Apellido";
                    hoja_trabajo.Cells[1, "D"] = "Vencimiento";
                    hoja_trabajo.Cells[1, "E"] = "Estado";
                    hoja_trabajo.Cells[1, "F"] = "Fecha Pago";

                    libros_trabajo.SaveAs(fichero.FileName,
                        Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal);
                    libros_trabajo.Close(true);
                    aplicacion.Quit();
                }
                else
                {
                    MessageBox.Show("No hay datos para guardar","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
        }

        private void panel_titulo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txt_filtro_nombre_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(txt_filtro_nombre.Text))
            {
                this.cargarGrillaInscripciones(svInscripcion.getInscripcionesPorNombre(txt_filtro_nombre.Text));
            }
            else
            {
                dgv_inscripciones.Rows.Clear();
                this.cargarGrillaInscripciones(svInscripcion.getInscripciones());
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
    }
}
