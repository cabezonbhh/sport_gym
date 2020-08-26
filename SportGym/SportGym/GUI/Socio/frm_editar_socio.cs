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
        Support support = Support.GetSupport();
        public frm_editar_socio(DTO_Socio seleccionado)
        {
            InitializeComponent();
            this.seleccionado = seleccionado;
            service = new Service_socio();
        }
        private void llenarCombos()
        {
            combo_inicio.Items.Clear();
            combo_fin.Items.Clear();
            //combo de inicio
            combo_inicio.Items.Add("08:00");
            combo_inicio.Items.Add("09:00");
            combo_inicio.Items.Add("10:00");
            combo_inicio.Items.Add("11:00");
            combo_inicio.Items.Add("16:00");
            combo_inicio.Items.Add("17:00");
            combo_inicio.Items.Add("18:00");
            combo_inicio.Items.Add("19:00");
            combo_inicio.Items.Add("20:00");
            combo_inicio.Items.Add("21:00");
            //combo de fin
            combo_fin.Items.Add("09:00");
            combo_fin.Items.Add("10:00");
            combo_fin.Items.Add("11:00");
            combo_fin.Items.Add("12:00");
            combo_fin.Items.Add("17:00");
            combo_fin.Items.Add("18:00");
            combo_fin.Items.Add("19:00");
            combo_fin.Items.Add("20:00");
            combo_fin.Items.Add("21:00");
            combo_fin.Items.Add("22:00");
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
                combo_inicio.Items.Add(seleccionado.HoraInicio);
                combo_fin.Items.Add(seleccionado.HoraFin);
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
                llenarCombos();
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
            if(!String.IsNullOrWhiteSpace(txt_nombre.Text) && !String.IsNullOrWhiteSpace(txt_apellido.Text) && check_editar.Checked == true)
            {
                if(support.esUnNumeroSinAdvertencia(txt_dni.Text) == true && support.esUnNumeroSinAdvertencia(txt_celular.Text) == true && support.esUnNumeroSinAdvertencia(txt_telefono.Text) == true)
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
                    else
                    {
                        MessageBox.Show("Hay un problema de formato en alguno de los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            {
                MessageBox.Show("El campo nombre o apellido se encuentra vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            support.soloLetrasSiEspacio(sender,e);
        }

        private void txt_apellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            support.soloLetrasSiEspacio(sender, e);
        }
        private void txt_dni_KeyPress(object sender, KeyPressEventArgs e)
        {
            support.soloNumeros(sender, e);
        }

        private void txt_telefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            support.soloNumeros(sender, e);
        }

        private void txt_celular_KeyPress(object sender, KeyPressEventArgs e)
        {
            support.soloNumeros(sender, e);
        }
    }
}
