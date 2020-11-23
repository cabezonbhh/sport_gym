using SportGym.DataTransferObject;
using SportGym.GUI.Socio;
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

namespace SportGym.GUI
{
    public partial class frm_nuevo_socio : Form
    {
        Service_socio service = null;
        Form principal = null;
        Form subPrincipal = null;
        public frm_nuevo_socio(Form principal, Form subPrincipal)
        {
            InitializeComponent();
            service = new Service_socio();// inicializo el service que se va a comunicar con el dao
            this.principal = principal;
            this.subPrincipal = subPrincipal;           
        }
        private void llenarCombos()
        {
            Support support = Support.GetSupport();
            support.cargarComboHorarios(combo_inicio, combo_fin);
        }

        private void frm_nuevo_socio_Load(object sender, EventArgs e)
        {
            this.limpiarCampos();
            llenarCombos();
            dtp_fecha_inicio.Value = DateTime.Now.ToLocalTime();
            dtp_fecha_vto.Value = DateTime.Now.AddMonths(1);
        }

        private void limpiarCampos()//metodo para limpiar los campos
        {
            txt_nombre.Clear();
            txt_apellido.Clear();
            txt_dni.Clear();
            txt_mail.Clear();
            txt_celular.Clear();
            txt_telefono.Clear();
            combo_inicio.SelectedIndex = -1;
            combo_fin.SelectedIndex = -1;
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
                if (combo_inicio.SelectedIndex == -1)
                {
                    return "Hora Inicio";
                }
                if (combo_fin.SelectedIndex == -1)
                {
                    return "Hora Fin";
                }
                if (String.IsNullOrWhiteSpace(txt_monto_pagar.Text))
                {
                    return "Monto";
                }
                return null;
            }
        }

        private void txt_nombre_KeyPress(object sender, KeyPressEventArgs e)//metodo que controla 
        {
            Support.GetSupport().soloLetrasSiEspacio(sender,e);
            if(txt_nombre.TextLength > 50 )
                MessageBox.Show("Maximo 50 caracteres", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void txt_apellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            Support.GetSupport().soloLetrasSiEspacio(sender,e);
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
            Support.GetSupport().soloNumeros(sender,e);
            if (txt_dni.TextLength > 10)
                MessageBox.Show("Maximo 10 caracteres", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void txt_telefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            Support.GetSupport().soloNumeros(sender, e);
            if (txt_telefono.TextLength > 12)
                MessageBox.Show("Maximo 12 caracteres", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void txt_celular_KeyPress(object sender, KeyPressEventArgs e)
        {
            Support.GetSupport().soloNumeros(sender, e);
            if (txt_celular.TextLength > 12)
                MessageBox.Show("Maximo 12 caracteres", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            bool retorno = false;
            Support support = Support.GetSupport();
            if (validarCampos() != null)
            {
                MessageBox.Show("Ha dejado el campo " + validarCampos() + " vacio", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (support.esUnNumeroSinAdvertencia(txt_dni.Text) == true && support.esUnNumeroSinAdvertencia(txt_celular.Text) == true && support.esUnNumeroSinAdvertencia(txt_telefono.Text) == true)
                {
                    DTO_Socio dto = new DTO_Socio();
                    dto.Nombre = txt_nombre.Text;
                    dto.Apellido = txt_apellido.Text;
                    dto.Dni = txt_dni.Text;
                    dto.Email = txt_mail.Text;
                    dto.Celular = txt_celular.Text;
                    dto.Telefono = txt_telefono.Text;
                    dto.HoraInicio = combo_inicio.SelectedItem.ToString();
                    dto.HoraFin = combo_fin.SelectedItem.ToString();

                    retorno = (service.registrarSocio(dto) > 0);
                    if (retorno == true)
                    {
                        IForm frm_p = principal as IForm;
                        IForm frm_ps = subPrincipal as IForm;
                        if (frm_p != null && frm_ps != null)
                        {
                            frm_p.actualizarDatos();
                            frm_ps.actualizarDatos();
                        }
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
                    MessageBox.Show("Hay un problema con alguno de los formatos de los campos", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.limpiarCampos();
                }
            }
            
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Desea salir de esta ventana?", "Atencion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)               
            {
                this.Dispose();              
            }
        }

        private void combo_inicio_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combo_inicio.SelectedIndex != -1)
            {
                combo_fin.SelectedItem = (Convert.ToDateTime(combo_inicio.SelectedItem.ToString()).AddHours(1)).ToString("HH:mm");
            }
        }

        private void txt_monto_pagar_TextChanged(object sender, EventArgs e)
        {
            if(!String.IsNullOrWhiteSpace(txt_monto_pagar.Text))
            {
                btn_guardar_pagar.Enabled = true;
            }
            else
            {
                btn_guardar_pagar.Enabled = false;
            }
        }

        private void btn_guardar_pagar_Click(object sender, EventArgs e)
        {
            bool retorno = false;
            Support support = Support.GetSupport();
            if (validarCampos() != null)
            {
                MessageBox.Show("Ha dejado el campo " + validarCampos() + " vacio", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (support.esUnNumeroSinAdvertencia(txt_dni.Text) == true && support.esUnNumeroSinAdvertencia(txt_celular.Text) == true && support.esUnNumeroSinAdvertencia(txt_telefono.Text) == true && support.esUnNumeroSinAdvertencia(txt_telefono.Text) == true)
                {
                    DTO_Socio dto = new DTO_Socio();
                    dto.Nombre = txt_nombre.Text;
                    dto.Apellido = txt_apellido.Text;
                    dto.Dni = txt_dni.Text;
                    dto.Email = txt_mail.Text;
                    dto.Celular = txt_celular.Text;
                    dto.Telefono = txt_telefono.Text;
                    dto.HoraInicio = combo_inicio.SelectedItem.ToString();
                    dto.HoraFin = combo_fin.SelectedItem.ToString();
                    DateTime inicio = dtp_fecha_inicio.Value;
                    DateTime fin = dtp_fecha_vto.Value;
                    double monto = Convert.ToDouble(txt_monto_pagar.Text);
                    retorno = (service.registrarSocioConPago(dto,monto,inicio,fin) > 0);
                    if (retorno == true)
                    {
                        IForm frm_p = principal as IForm;
                        IForm frm_ps = subPrincipal as IForm;
                        if (frm_p != null && frm_ps != null)
                        {
                            frm_p.actualizarDatos();
                            frm_ps.actualizarDatos();
                        }
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
                    MessageBox.Show("Hay un problema con alguno de los formatos de los campos", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.limpiarCampos();
                }
            }

        }

        private void dtp_fecha_inicio_ValueChanged(object sender, EventArgs e)
        {
            dtp_fecha_vto.Value = dtp_fecha_inicio.Value.AddMonths(1);
        }

        private void txt_monto_pagar_KeyPress(object sender, KeyPressEventArgs e)
        {
            Support.GetSupport().soloNumeros(sender,e);
        }

        private void cargarFoto()
        {

        }
        private bool guardarFoto()
        {
            return false;
        }
    }
}
