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
    public partial class frm_editar_socio : Form
    {
        private DTO_Socio seleccionado;
        private Service_socio service = null;
        public frm_editar_socio(DTO_Socio seleccionado)
        {
            InitializeComponent();
            this.seleccionado = seleccionado;
            service = new Service_socio();
        }

        public void llenarCampos()
        {
            if(seleccionado != null)
            {
                txt_nombre.Text = seleccionado.Nombre;
                txt_apellido.Text = seleccionado.Apellido;
                txt_dni.Text = seleccionado.Dni;
                txt_mail.Text = seleccionado.Email;
                txt_celular.Text = seleccionado.Celular; ;
                txt_telefono.Text = seleccionado.Telefono;
            }
            else
            {
                txt_nombre.Text = "Error";
                txt_apellido.Text = "Error";
                txt_dni.Text = "Error";
                txt_mail.Text = "Error";
                txt_celular.Text = "Error";
                txt_telefono.Text = "Error";
            }

        }

        private void check_editar_CheckedChanged(object sender, EventArgs e)
        {
            if(check_editar.Checked == false)
            {
                txt_nombre.ReadOnly = true;
                txt_apellido.ReadOnly = true;
                txt_dni.ReadOnly = true;
                txt_mail.ReadOnly = true;
                txt_celular.ReadOnly = true;
                txt_telefono.ReadOnly = true;
                btn_guardar.Enabled = false;
                btn_guardar.Visible = false;
                lbl_advertencia_nombre.Visible = false;
                lbl_advertencia_apellido.Visible = false;
                lbl_advertencia_dni.Visible = false;
                lbl_advertencia_mail.Visible = false;
                lbl_advertencia_celular.Visible = false;
                lbl_advertencia_telefono.Visible = false;
                lbl_info.Visible = false;
            }
            else
            {
                txt_nombre.ReadOnly = false;
                txt_apellido.ReadOnly = false;
                txt_dni.ReadOnly = false;
                txt_mail.ReadOnly = false;
                txt_celular.ReadOnly = false;
                txt_telefono.ReadOnly = false;
                btn_guardar.Enabled = true;
                btn_guardar.Visible = true;
                lbl_advertencia_nombre.Visible = true;
                lbl_advertencia_apellido.Visible = true;
                lbl_advertencia_dni.Visible = true;
                lbl_advertencia_mail.Visible = true;
                lbl_advertencia_celular.Visible = true;
                lbl_advertencia_telefono.Visible = true;
                lbl_info.Visible = true;
            }
        }

        private void frm_editar_socio_Load(object sender, EventArgs e)
        {
            llenarCampos();
        }
    }
}
