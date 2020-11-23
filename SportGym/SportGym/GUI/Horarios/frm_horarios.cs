using SportGym.DataTransferObject;
using SportGym.Interface;
using SportGym.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SportGym.GUI
{
    public partial class frm_horarios : Form, IForm
    {
        Service_socio service = null;
        Form caller;
        public frm_horarios(Form caller)
        {
            InitializeComponent();
            service = new Service_socio();
            this.caller = caller;
        }

        private void frm_horarios_Load(object sender, EventArgs e)
        {
            Support support = Support.GetSupport();
            support.cargarComboHorarios(combo_inicio, combo_fin);        
            combo_inicio.SelectedIndex = -1;
            combo_fin.SelectedIndex = -1;
            cargarGrilla(service.getSocios());
            lbl_cantidad_resultado.Text = "0";
            lbl_cantidad_resultado.ForeColor = Color.Red;
        }

        private void llenarCombos()
        {
            //combo de inicio
            combo_inicio.Items.Add("07:00");
            combo_inicio.Items.Add("08:00");
            combo_inicio.Items.Add("09:00");
            combo_inicio.Items.Add("10:00");
            combo_inicio.Items.Add("11:00");
            combo_inicio.Items.Add("16:00");
            combo_inicio.Items.Add("17:00");
            combo_inicio.Items.Add("18:00");
            combo_inicio.Items.Add("19:00");
            combo_inicio.Items.Add("20:00");
            combo_inicio.Items.Add("21:00");
            //combo de fin
            combo_fin.Items.Add("08:00");
            combo_fin.Items.Add("09:00");
            combo_fin.Items.Add("10:00");
            combo_fin.Items.Add("11:00");
            combo_fin.Items.Add("12:00");
            combo_fin.Items.Add("17:00");
            combo_fin.Items.Add("18:00");
            combo_fin.Items.Add("19:00");
            combo_fin.Items.Add("20:00");
            combo_fin.Items.Add("21:00");
            combo_fin.Items.Add("22:00");
        }
        private void cargarGrilla(IList<DTO_Socio> lista)
        {
            dgv_horarios.Rows.Clear();
            if (lista != null)
            {
                int contador = 1;
                foreach (DTO_Socio dto in lista)
                {
                    dgv_horarios.Rows.Add(new Object[]
                            {   
                                contador.ToString(),
                                dto.Nombre,
                                dto.Apellido,
                                dto.HoraInicio,
                                dto.HoraFin,
                                dto.NumeroSocio
                            }
                        );
                    contador++;
                }
                
            }
            else
            {
                MessageBox.Show("No hay datos para mostrar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_filtrar_Click(object sender, EventArgs e)
        {
            if(combo_inicio.SelectedIndex != -1 && combo_fin.SelectedIndex != -1)
            {
                IList<DTO_Socio> lista = service.getSociosHorarios(combo_inicio.SelectedItem.ToString(), combo_fin.SelectedItem.ToString());
                this.cargarGrilla(lista);
                int resultado = 20 - lista.Count;
                if(resultado > 0)
                {
                    lbl_cantidad_resultado.Text = resultado.ToString();
                    lbl_cantidad_resultado.ForeColor = Color.Green;
                }
                else
                {
                    if(resultado < 0)
                    {
                        lbl_cantidad_resultado.Text = "0";
                        lbl_cantidad_resultado.Text = resultado.ToString();
                        lbl_cantidad_resultado.ForeColor = Color.Red;
                    }
                    else
                    {
                        lbl_cantidad_resultado.Text = resultado.ToString();
                        lbl_cantidad_resultado.ForeColor = Color.Red;
                    }
                }
            }
            else
            {
                MessageBox.Show("Problema al filtrar los datos, por favor revise que los horarios ingresados son los correctos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgv_horarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_horarios.CurrentRow != null)
            {
                int id = Convert.ToInt32(dgv_horarios.CurrentRow.Cells["col_socio"].Value.ToString());
                DTO_Socio dto = service.getSocio(id);
                if (dto != null)
                {
                    Form editarVer = new frm_editar_socio(dto,caller,this);
                    editarVer.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Error al cargar los datos del socio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("No selecciono ningun socio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgv_horarios_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgv_horarios.Columns[e.ColumnIndex].Name == "col_orden")
            {
                if (Convert.ToInt32(e.Value) > 15 && Convert.ToInt32(e.Value) < 20)
                {
                    e.CellStyle.BackColor = Color.Yellow;
                }
                else
                {
                    if(Convert.ToInt32(e.Value) == 20)
                    {
                        e.CellStyle.BackColor = Color.PaleVioletRed;
                    }
                    else
                    {
                        if (Convert.ToInt32(e.Value) > 20)
                        {
                            e.CellStyle.BackColor = Color.LightGray;
                        }
                        else
                        {
                            e.CellStyle.BackColor = Color.LightGreen;
                        }
                    }
                }
            }
        }

        private void combo_inicio_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combo_inicio.SelectedIndex != -1)
            {
                combo_fin.SelectedItem = (Convert.ToDateTime(combo_inicio.SelectedItem.ToString()).AddHours(1)).ToString("HH:mm");
            }
        }

        public void actualizarDatos()
        {
            if (combo_inicio.SelectedIndex != -1 && combo_fin.SelectedIndex != -1)
            {
                IList<DTO_Socio> lista = service.getSociosHorarios(combo_inicio.SelectedItem.ToString(), combo_fin.SelectedItem.ToString());
                this.cargarGrilla(lista);
                int resultado = 20 - lista.Count;
                if (resultado > 0)
                {
                    lbl_cantidad_resultado.Text = resultado.ToString();
                    lbl_cantidad_resultado.ForeColor = Color.Green;
                }
                else
                {
                    if (resultado < 0)
                    {
                        lbl_cantidad_resultado.Text = "0";
                        lbl_cantidad_resultado.Text = resultado.ToString();
                        lbl_cantidad_resultado.ForeColor = Color.Red;
                    }
                    else
                    {
                        lbl_cantidad_resultado.Text = resultado.ToString();
                        lbl_cantidad_resultado.ForeColor = Color.Red;
                    }
                }
            }
        }
    }
}
