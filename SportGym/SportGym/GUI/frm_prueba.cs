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
    public partial class frm_prueba : Form
    {
        private Service_Inscripcion svInscripcion;
        public frm_prueba()
        {
            InitializeComponent();
            svInscripcion = new Service_Inscripcion();
            cargarGrilla();
        }

        private void cargarGrilla()
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

        private void dgv_inscripciones_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgv_inscripciones.Columns[e.ColumnIndex].Name == "col_estado")
            {
                if (String.Equals(e.Value, "VENCIDA") == true)
                {
                    e.CellStyle.BackColor = Color.IndianRed;
                }
                else
                {
                    if (String.Equals(e.Value, "VENCE HOY") == true)
                    {
                        e.CellStyle.BackColor = Color.Yellow;
                    }
                    else
                    {
                        e.CellStyle.BackColor = Color.ForestGreen;
                    }
                }
            }
        }
    }
}
