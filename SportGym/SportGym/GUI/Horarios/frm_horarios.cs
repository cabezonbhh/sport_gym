using SportGym.DataTransferObject;
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
    public partial class frm_horarios : Form
    {
        Service_socio service = null;
        public frm_horarios()
        {
            InitializeComponent();
            service = new Service_socio();
        }

        private void frm_horarios_Load(object sender, EventArgs e)
        {
            llenarCombos();
            combo_inicio.SelectedIndex = -1;
            combo_fin.SelectedIndex = -1;
            cargarGrilla(service.getSocios());
        }

        private void llenarCombos()
        {
            //combo de inicio
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
                                dto.HoraFin
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
               this.cargarGrilla(service.getSociosHorarios(combo_inicio.SelectedItem.ToString(), combo_fin.SelectedItem.ToString()));
            }
            else
            {
                MessageBox.Show("Problema al filtrar los datos, por favor revise que los horarios ingresados son los correctos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
