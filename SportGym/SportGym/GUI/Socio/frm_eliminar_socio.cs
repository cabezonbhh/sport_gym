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

namespace SportGym.GUI.Socio
{
    public partial class frm_eliminar_socio : Form
    {
        private Form subPrincipal;
        private DTO_Socio seleccionado;
        private Service_socio service = null;
        Support support = Support.GetSupport();
        public frm_eliminar_socio(DTO_Socio dto, Form subPrincipal)
        {
            this.subPrincipal = subPrincipal;
            seleccionado = dto;
            InitializeComponent();
        }

        private void frm_eliminar_socio_Load(object sender, EventArgs e)
        {
            if(seleccionado != null)
            {
                lbl_socio_borrar.Text = lbl_socio_borrar.Text + " " + seleccionado.Nombre + " " + seleccionado.Apellido;
                btn_borrar.Enabled = false;
                btn_borrar.Visible = false;
            }
            else
            {
                btn_borrar.Enabled = false;
                btn_borrar.Visible = false;
                lbl_socio_borrar.Text = lbl_socio_borrar.Text + "ERROR";
            }
        }

        private void btn_borrar_Click(object sender, EventArgs e)
        {
            if(support.esUnNumero(txt_nro_socio_eliminar.Text) == true && !String.IsNullOrWhiteSpace(txt_nro_socio_eliminar.Text))
            {                
                DialogResult resultado = MessageBox.Show("¿Desea borrar el socio seleccionado?", "Alerta!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes && seleccionado != null)
                {
                    int nro = Convert.ToInt32(txt_nro_socio_eliminar.Text);
                    int nroSeleccionado = Convert.ToInt32(seleccionado.NumeroSocio);
                    if (nro == nroSeleccionado)
                    {
                        service = new Service_socio();
                        bool control = service.eliminarSocio(nro);
                        if(control == true)
                        {
                            IForm frm_ps = subPrincipal as IForm;
                            if (frm_ps != null && frm_ps != null)
                            {
                                frm_ps.actualizarDatos();
                            }
                            MessageBox.Show("Socio eliminado", "Exito!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Dispose();
                        }
                        else
                        {
                            MessageBox.Show("Hubo un problema al intentar eliminar el socio, intente nuevamente", "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            this.Dispose();
                        }                       
                    }
                    else
                    {
                        MessageBox.Show("El numero ingresado no se corresponde con el socio a borrar", "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.Dispose();
                    }
                }
                else
                {
                    MessageBox.Show("Hubo un error al intentar eliminar al socio, intente de nuevo", "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Dispose();
                }
                    
            }
        }
        private void txt_nro_socio_eliminar_KeyPress(object sender, KeyPressEventArgs e)
        {
            support.soloNumeros(sender, e);
        }

        private void txt_nro_socio_eliminar_TextChanged(object sender, EventArgs e)
        {
            if(!String.IsNullOrWhiteSpace(txt_nro_socio_eliminar.Text))
            {
                btn_borrar.Visible = true;
                btn_borrar.Enabled = true;
            }
            else
            {
                btn_borrar.Visible = false;
                btn_borrar.Enabled = false;
            }
        }
    }
}
