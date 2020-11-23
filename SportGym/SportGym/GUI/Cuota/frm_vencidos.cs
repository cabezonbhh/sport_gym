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

namespace SportGym.GUI.Cuota
{
    public partial class frm_vencidos : Form
    {
        private Service_Inscripcion service = null;
        public frm_vencidos()
        {
            InitializeComponent();
            service = new Service_Inscripcion();
        }

        private void llenarGrilla()
        {
            IList<DTO_Inscripcion> inscripciones = service.getInscripcionesVencidas();
            dgv_cuotas.Rows.Clear();
            if (inscripciones != null)
            {
                lbl_cantidad.Text = "Cantidad de vencidos: " + inscripciones.Count;
                lbl_cantidad.ForeColor = Color.Red;
                foreach (DTO_Inscripcion dto in inscripciones)
                {

                    dgv_cuotas.Rows.Add(new Object[]
                            {
                                dto.NombreSocio.ToString(),
                                dto.ApellidoSocio.ToString(),
                                dto.UltimoPago.ToString(),
                                dto.UltimoVencimiento.ToString(),
                                dto.EstadoCuota.ToString(),
                                dto.Celular.ToString()
                            }
                        );
                }
            }
            else
            {
                MessageBox.Show("No hay datos para mostrar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void frm_vencidos_Load(object sender, EventArgs e)
        {
            llenarGrilla();
        }


    }
}
