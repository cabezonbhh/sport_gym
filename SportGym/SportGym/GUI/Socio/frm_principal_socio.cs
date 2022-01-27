using SportGym.DataTransferObject;
using SportGym.GUI.Cuota;
using SportGym.Interface;
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
    public partial class frm_principal_socio : Form, IForm
    {
       
        Service_socio svSocio;
        Support support = Support.GetSupport();
        Form principal = null;
        public frm_principal_socio(Form principal)
        {
            InitializeComponent();
            svSocio = new Service_socio();
            this.principal = principal;
        }
      
        private void pic_close_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }    
 
       
        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frm_nuevo_socio);
            if (frm == null || frm.IsDisposed == true)
            {
                frm = new frm_nuevo_socio(principal,this);
                frm.ShowDialog();
            }
            else
            {
                frm.BringToFront();
            }

        }

        private void btn_ver_editar_Click(object sender, EventArgs e)
        {
            if (dgv_socios.CurrentRow != null)
            {
                int id = Convert.ToInt32(dgv_socios.CurrentRow.Cells["col_nro"].Value.ToString());
                DTO_Socio dto = svSocio.getSocio(id);
                if(dto != null)
                {
                    Form editarVer = new frm_editar_socio(dto,this);
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
            if (dgv_socios.CurrentRow != null)
            {
                int id = Convert.ToInt32(dgv_socios.CurrentRow.Cells["col_nro"].Value.ToString());
                DTO_Socio dto = svSocio.getSocio(id);
                frm_eliminar_socio eliminar = new frm_eliminar_socio(dto, this);
                eliminar.txt_nro_socio_eliminar.Text = id.ToString();
                eliminar.btn_borrar_Click(sender,e);
            }
            else
            {
                MessageBox.Show("No selecciono ningun socio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        public void cargarGrilla(IList<DTO_Socio> lista)
        {
            int contador = 1;
            dgv_socios.Rows.Clear();
            if (lista != null && lista.Count > 0)
            {
                habilitarBotonesNoError();
                foreach (DTO_Socio dto in lista)
                {
                    dgv_socios.Rows.Add(new Object[]
                            {
                                contador.ToString(),                               
                                dto.Nombre,
                                dto.Apellido,
                                dto.NumeroSocio,
                                dto.Dni
                            }
                        );
                    contador++;
                }
            }
        }
      
        private void frm_principal_socio_Load(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            cargarGrilla(svSocio.getSocios());

        }
        
        private void habilitarBotonesNoError()
        {
            btn_eliminar.Enabled = true;
            btn_ver_editar.Enabled = true;
            txt_filtro_nombre.Enabled = true;
            txt_filtro_apellido.Enabled = true;
        }
    
        private void btn_atras_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            cargarGrilla(svSocio.getSocios());
        }

        private void txt_filtro_nombre_TextChanged_1(object sender, EventArgs e)
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

        private void txt_filtro_apellido_TextChanged_1(object sender, EventArgs e)
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

        private void btn_actualizar_Click_1(object sender, EventArgs e)
        {
            cargarGrilla(svSocio.getSocios());
        }

        private void txt_filtro_nombre_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            support.soloLetrasSiEspacio(sender, e);
        }

        private void txt_filtro_apellido_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            support.soloLetrasSiEspacio(sender, e);
        }

        public void actualizarDatos()
        {
            cargarGrilla(svSocio.getSocios());
        }

        private void btn_vencidos_Click(object sender, EventArgs e)
        {
            cargarGrilla(svSocio.getSociosVencidos());
        }

        private void dgv_socios_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgv_socios.Columns[e.ColumnIndex].Name == "col_nro")
            {
                e.CellStyle.BackColor = Color.LightGray;
            }
        }
    }
}
