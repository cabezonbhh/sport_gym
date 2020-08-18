using SportGym.DataTransferObject;
using SportGym.GUI.Cuota;
using SportGym.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SportGym.GUI.Socio
{
    public partial class frm_principal_socio : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void panel_titulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        Service_socio svSocio;
        Support support = Support.GetSupport();
        public frm_principal_socio()
        {
            InitializeComponent();
            svSocio = new Service_socio();
        }

        private void pic_close_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void pic_restaurar_Click(object sender, EventArgs e)
        {
            pic_restaurar.Visible = false;
            pic_maximizar.Visible = true;
            this.WindowState = FormWindowState.Normal;
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

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            Form nuevo = new frm_nuevo_socio();
            nuevo.ShowDialog();
        }

        private void btn_ver_editar_Click(object sender, EventArgs e)
        {
            if (dgv_socios.CurrentRow != null)
            {
                int id = Convert.ToInt32(dgv_socios.CurrentRow.Cells["col_nro"].Value.ToString());
                DTO_Socio dto = svSocio.getSocio(id);
                if(dto != null)
                {
                    Form editarVer = new frm_editar_socio(dto);
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

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if(dgv_socios.CurrentRow != null)
            {
                int id = Convert.ToInt32(dgv_socios.CurrentRow.Cells["col_nro"].Value.ToString());
                DTO_Socio dto = svSocio.getSocio(id);
                Form eliminar = new frm_eliminar_socio(dto);
                eliminar.ShowDialog();
            }
            else
            {
                MessageBox.Show("No selecciono ningun socio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cargarGrilla(IList<DTO_Socio> lista)
        {
            dgv_socios.Rows.Clear();
            if (lista != null)
            {
                foreach (DTO_Socio dto in lista)
                {
                    dgv_socios.Rows.Add(new Object[]
                            {
                                dto.NumeroSocio,
                                dto.Nombre,
                                dto.Apellido,
                                dto.Dni
                            }
                        );
                }
            }
            else
            {
                MessageBox.Show("No hay datos para mostrar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frm_principal_socio_Load(object sender, EventArgs e)
        {
            cargarGrilla(svSocio.getSocios());
        }



        private void txt_filtro_nombre_TextChanged(object sender, EventArgs e)
        {       
            if (!String.IsNullOrWhiteSpace(txt_filtro_nombre.Text))
            {
                cargarGrilla(svSocio.getSocioPorNombre(txt_filtro_nombre.Text));
            }
            else
            {
                dgv_socios.Rows.Clear();
                cargarGrilla(svSocio.getSocios());
            }
        }

        private void txt_filtro_apellido_TextChanged(object sender, EventArgs e)
        {
            dgv_socios.Rows.Clear();
            if (!String.IsNullOrWhiteSpace(txt_filtro_apellido.Text))
            {
                cargarGrilla(svSocio.getSocioPorApellido(txt_filtro_apellido.Text));
            }
            else
            {
                dgv_socios.Rows.Clear();
                cargarGrilla(svSocio.getSocios());
            }
        }

        private void txt_filtro_dni_TextChanged(object sender, EventArgs e)
        {
            dgv_socios.Rows.Clear();
            if (!String.IsNullOrWhiteSpace(txt_filtro_nombre.Text))
            {
                cargarGrilla(svSocio.getSocioPorDni(txt_filtro_dni.Text));
            }
            else
            {
                dgv_socios.Rows.Clear();
                cargarGrilla(svSocio.getSocios());
            }
        }

        private void txt_filtro_nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            support.soloLetrasSiEspacioConAdvertencia(sender,e);
        }

        private void txt_filtro_apellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            support.soloLetrasSiEspacioConAdvertencia(sender, e);
        }

        private void txt_filtro_dni_KeyPress(object sender, KeyPressEventArgs e)
        {
            support.soloNumerosConAdvertencia(sender, e);
        }

        private void btn_refresh_socio_Click(object sender, EventArgs e)
        {
            cargarGrilla(svSocio.getSocios());
        }

        private void btn_atras_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
