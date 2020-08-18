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

        private void btn_salir_editar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Desea salir de esta ventana?","Alerta!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
                this.Dispose();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if(!String.IsNullOrWhiteSpace(txt_nombre.Text) && !String.IsNullOrWhiteSpace(txt_apellido.Text) && check_editar.Checked == true && validarMaximoCaracteres() == 6)
            {
                if(validarMaximoCaracteres() == 6 && validarFormatoCampos()==true)
                {
                    DTO_Socio dto = new DTO_Socio();
                    dto.NumeroSocio = seleccionado.NumeroSocio;
                    dto.Nombre = txt_nombre.Text;
                    dto.Apellido = txt_apellido.Text;
                    dto.Dni = txt_dni.Text;
                    dto.Email = txt_mail.Text;
                    dto.Telefono = txt_telefono.Text;
                    dto.Celular = txt_celular.Text;
                    DialogResult resultado = MessageBox.Show("¿Desea modificar los datos del socio?", "Alerta!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (resultado == DialogResult.Yes)
                    {
                        bool control = service.modificarSocio(dto);
                        if (control == true)
                            MessageBox.Show("Se aplicaron los cambios con exito", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        else
                        {
                            MessageBox.Show("Hubo un error al modificar los datos, intente nuevamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            llenarCampos();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Alguno de los campos no respeta el formato indicado, revise e intente nuevamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool validarFormatoCampos()
        {
            Support support = Support.GetSupport();
            int control = 0;

            if(support.esUnNumeroSinAdvertencia(txt_dni.Text) == true)
            {
                control++;
            }
            if (support.esUnNumeroSinAdvertencia(txt_celular.Text) == true) 
            {
                control++;
            }
            if (support.esUnNumeroSinAdvertencia(txt_telefono.Text) == true) 
            {
                control++;
            }
            return control == 3;
        }
        private int validarMaximoCaracteres()
        {
            int contador = 0;
            if (txt_nombre.TextLength < 51)
                contador++;
            if (txt_apellido.TextLength < 51)
                contador++;
            if (txt_mail.TextLength < 81)
                contador++;
            if (txt_dni.TextLength < 11)
                contador++;
            if (txt_telefono.TextLength < 13)
                contador++;
            if (txt_celular.TextLength < 13)
                contador++;
            return contador;
        }
    }
}
