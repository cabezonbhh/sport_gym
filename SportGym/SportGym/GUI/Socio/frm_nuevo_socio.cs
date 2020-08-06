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
        public frm_nuevo_socio()
        {
            InitializeComponent();
        }

        private void frm_nuevo_socio_Load(object sender, EventArgs e)
        {

        }

        private string validarCampos()
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
                return null;
            }
        }

        private void txt_nombre_KeyPress(object sender, KeyPressEventArgs e)
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

        //private void btn_guardar_Click(object sender, EventArgs e)
        //{
        //    bool retorno = false;
        //    if (validarCampos() != null)
        //    {
        //        MessageBox.Show("Ha dejado el campo " + validarCampos() + " vacio", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //    else
        //    {
        //        if ()
        //        {
        //            MessageBox.Show("Ya existe un cliente con ese DNI ", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        //        }
        //        else
        //        {
        //            //vec: 0 - nombre / 1 - apellido / 2 - calle 
        //            string[] vec = new string[3];
        //            long dni = Convert.ToInt64(txt_dni.Text);
        //            long telefono = Convert.ToInt64(txt_phone.Text);
        //            long celular = Convert.ToInt64(txt_mobile.Text);
        //            int nro = Int32.Parse(txt_nro.Text);
        //            vec[0] = txt_name.Text;
        //            vec[1] = txt_lastName.Text;
        //            vec[2] = txt_address.Text;
        //            retorno = service.nuevoCliente(vec, dni, nro, telefono, celular);
        //            if (retorno == true)
        //                MessageBox.Show("Cliente registrado con exito", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //            else
        //                MessageBox.Show("Hubo un problema al registrar el cliente, intente nuevamente", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error);

        //        }
        //    }
        //}
    }
}
