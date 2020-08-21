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

namespace SportGym.GUI.Horarios
{
    public partial class frm_horarios_automaticos : Form
    {
        Service_socio service = null;
        public frm_horarios_automaticos()
        {
            InitializeComponent();
            service = new Service_socio();
        }

        private void frm_horarios_automaticos_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            cargarGrilla();
        }
        private void cargarGrilla()
        {
            string inicio = DateTime.Now.ToString("HH") + ":00";
            string fin = DateTime.Now.AddHours(1).ToString("HH") + ":00"; ;
            IList<DTO_Socio> lista = service.getSociosHorarios(inicio, fin);
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
    }
}