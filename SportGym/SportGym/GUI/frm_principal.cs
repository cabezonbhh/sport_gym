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

        private void pic_max_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            pic_restore.Visible = true;
            pic_max.Visible = false;
            btn_pagar_cuota.Location = new Point(15,920);
        }

        private void pic_restore_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            pic_restore.Visible = false;
            pic_max.Visible = true;
            btn_pagar_cuota.Location = new Point(15, 560);
        }

        private void pic_min_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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
                    e.CellStyle.BackColor = Color.IndianRed;

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
                            e.CellStyle.BackColor = Color.ForestGreen;
                        }

                    }
                }
            }
        }
    }
}
