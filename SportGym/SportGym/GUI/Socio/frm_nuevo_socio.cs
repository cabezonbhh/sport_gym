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
    public partial class frm_nuevo_socio : Form
    {
        Service_socio service = null;
        public frm_nuevo_socio()
        {
            InitializeComponent();
            service = new Service_socio();// inicializo el service que se va a comunicar con el dao
        }

        private void frm_nuevo_socio_Load(object sender, EventArgs e)
        {
            this.limpiarCampos();
        }

        private void limpiarCampos()//metodo para limpiar los campos
        {
            txt_nombre.Clear();
            txt_apellido.Clear();
            txt_dni.Clear();
            txt_mail.Clear();
            txt_celular.Clear();
            txt_telefono.Clear();
        }

        private string validarCampos()// metodo para validar que ingreso nombre y apellido, ya que ambos son obligatorios. Si alguno esta vacio retorna un string indicando el campo que falta
        {
            {
                if (String.IsNullOrWhiteSpace(txt_nombre.Text))
                {
                    return "Nombre";
                }
                if (String.IsNullOrWhiteSpace(txt_apellido.Text))
                {
                    return "Apellido";
                }
                if (String.IsNullOrWhiteSpace(txt_dni.Text))
                {
                    return "DNI";
                }
                return null;
            }
        }

        private void txt_nombre_KeyPress(object sender, KeyPressEventArgs e)//metodo que controla 
        {
            Support.GetSupport().soloLetrasSiEspacioConAdvertencia(sender,e);
            if(txt_nombre.TextLength > 50 )
                MessageBox.Show("Maximo 50 caracteres", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void txt_apellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            Support.GetSupport().soloLetrasSiEspacioConAdvertencia(sender,e);
            if(txt_apellido.TextLength > 50)
                MessageBox.Show("Maximo 50 caracteres", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void txt_mail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txt_mail.TextLength > 80)
                MessageBox.Show("Maximo 80 caracteres", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void txt_dni_KeyPress(object sender, KeyPressEventArgs e)
        {
            Support.GetSupport().soloNumerosConAdvertencia(sender,e);
            if (txt_dni.TextLength > 10)
                MessageBox.Show("Maximo 10 caracteres", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void txt_telefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            Support.GetSupport().soloNumerosConAdvertencia(sender, e);
            if (txt_telefono.TextLength > 12)
                MessageBox.Show("Maximo 12 caracteres", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void txt_celular_KeyPress(object sender, KeyPressEventArgs e)
        {
            Support.GetSupport().soloNumerosConAdvertencia(sender, e);
            if (txt_celular.TextLength > 12)
                MessageBox.Show("Maximo 12 caracteres", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            bool retorno = false;
            if (validarCampos() != null)
            {
                MessageBox.Show("Ha dejado el campo " + validarCampos() + " vacio", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if(service.existeSocioConDni(txt_dni.Text) == false)
                {   
                    
                    DTO_Socio dto = new DTO_Socio();
                    dto.Nombre = txt_nombre.Text;
                    dto.Apellido = txt_apellido.Text;
                    dto.Dni = txt_dni.Text;
                    dto.Email = txt_mail.Text;
                    dto.Celular = txt_celular.Text;
                    dto.Telefono = txt_telefono.Text;

                    retorno = (service.registrarSocio(dto) > 0) ;
                    if(retorno == true)
                    {
                        MessageBox.Show("Socio registrado con exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.limpiarCampos();
                    }                       
                    else
                    {
                        MessageBox.Show("Hubo un problema al registrar al socio, intente nuevamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.limpiarCampos();
                    }
                        
                }
                else
                {
                    MessageBox.Show("Existe un socio con ese dni", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.limpiarCampos();
                }
            }
            
        }

        
    }
}
