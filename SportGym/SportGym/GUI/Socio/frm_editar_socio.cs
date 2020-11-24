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
    public partial class frm_editar_socio : Form
    {
        private DTO_Socio seleccionado;
        private Service_socio service = null;
        Support support = Support.GetSupport();
        Form main;
        Form caller;

        public frm_editar_socio(DTO_Socio seleccionado)
        {
            InitializeComponent();
            this.seleccionado = seleccionado;
            service = new Service_socio();

        }
        public frm_editar_socio(DTO_Socio seleccionado, Form caller)
        {
            InitializeComponent();
            this.seleccionado = seleccionado;
            service = new Service_socio();
            this.caller = caller;
        }
        public frm_editar_socio(DTO_Socio seleccionado,Form main, Form caller)
        {
            InitializeComponent();
            this.seleccionado = seleccionado;
            service = new Service_socio();
            this.main = main;
            this.caller = caller;
        }
        private void llenarCombos()
        {
            combo_inicio.Items.Clear();
            combo_fin.Items.Clear();
            support.cargarComboHorarios(combo_inicio, combo_fin);
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
                combo_inicio.Items.Clear();
                combo_fin.Items.Clear();
                combo_inicio.Items.Add(seleccionado.HoraInicio);
                combo_fin.Items.Add(seleccionado.HoraFin);
                combo_inicio.SelectedIndex = 0;
                combo_fin.SelectedIndex = 0;
                
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
                btn_guardar.Visible = false;
                lbl_advertencia_nombre.Visible = false;
                lbl_advertencia_apellido.Visible = false;
                lbl_advertencia_mail.Visible = false;
                lbl_info.Visible = false;
                llenarCampos();
            }
            else
            {
                txt_nombre.ReadOnly = false;
                txt_apellido.ReadOnly = false;
                txt_dni.ReadOnly = false;
                txt_mail.ReadOnly = false;
                txt_celular.ReadOnly = false;
                txt_telefono.ReadOnly = false;
                btn_guardar.Visible = true;
                lbl_advertencia_nombre.Visible = true;
                lbl_advertencia_apellido.Visible = true;
                lbl_advertencia_mail.Visible = true;
                lbl_info.Visible = true;
                llenarCombos();
                //combo_inicio.SelectedIndex = 0;
                //combo_fin.SelectedIndex = 0;
            }
        }

        private void frm_editar_socio_Load(object sender, EventArgs e)
        {
            llenarCampos();
            cargarFoto();            
        }

        private void cargarFoto()
        {
            support.cargarFoto(txt_nombre.Text +"_"+ txt_apellido.Text, pic_socio);
        }
        private void btn_salir_editar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Desea salir de esta ventana?","Alerta!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                var aux = main as IForm;
                var aux2 = caller as IForm;
                if (aux != null)
                {
                    aux.actualizarDatos();

                }
                if (aux2 != null)
                {
                    aux2.actualizarDatos();
                }
                this.Dispose();
            }             
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if(!String.IsNullOrWhiteSpace(txt_nombre.Text) && !String.IsNullOrWhiteSpace(txt_apellido.Text) && check_editar.Checked == true)
            {
                DTO_Socio dto = new DTO_Socio();
                dto.NumeroSocio = seleccionado.NumeroSocio;
                dto.Nombre = txt_nombre.Text;
                dto.Apellido = txt_apellido.Text;
                dto.Dni = txt_dni.Text;
                dto.Email = txt_mail.Text;
                dto.Telefono = txt_telefono.Text;
                dto.Celular = txt_celular.Text;
                
                if(combo_inicio.SelectedIndex != -1 && combo_fin.SelectedIndex != -1 )
                {
                    dto.HoraInicio = combo_inicio.SelectedItem.ToString();
                    dto.HoraFin = combo_fin.SelectedItem.ToString();
                    DialogResult resultado = MessageBox.Show("¿Desea modificar los datos del socio?", "Alerta!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (resultado == DialogResult.Yes)
                    {
                        bool control = service.modificarSocio(dto);
                        if (control == true)
                        {
                            MessageBox.Show("Se aplicaron los cambios con exito", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            if (support.guardarFoto(pic_socio.Image, txt_nombre.Text + "_" + txt_apellido.Text) == false)
                            {
                                MessageBox.Show("Error al guardar la foto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            var aux = main as IForm;
                            var aux2 = caller as IForm;
                            if (aux != null)
                            {
                                aux.actualizarDatos();

                            }
                            if (aux2 != null)
                            {
                                aux2.actualizarDatos();
                            }
                        }                        
                        else
                        {
                            MessageBox.Show("Hubo un error al modificar los datos, intente nuevamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            llenarCampos();
                            this.DialogResult = DialogResult.None;
                        }
                    }
                    {
                        this.DialogResult = DialogResult.None;
                    }
                }
                else
                {
                    MessageBox.Show("Horario de Inicio o Fin no esta seleccionado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.DialogResult = DialogResult.None;
                }
                
            }
            else
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

        private void combo_inicio_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combo_inicio.SelectedIndex != -1)
            {
                combo_fin.SelectedItem = (Convert.ToDateTime(combo_inicio.SelectedItem.ToString()).AddHours(1)).ToString("HH:mm");
            }
        }

        private void combo_fin_SelectedIndexChanged(object sender, EventArgs e)
        {
            btn_guardar.Enabled = true;
        }

        private void btn_tomar_foto_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frm_foto);
            if (frm == null || frm.IsDisposed == true)
            {

                Form nuevo = new frm_foto(this);
                nuevo.ShowDialog();
            }
            else
            {
                frm.BringToFront();
            }
        }
        public void recibirFoto(Image imagen)
        {
            this.pic_socio.Image = imagen;
        }

        private void btn_foto_archivo_Click(object sender, EventArgs e)
        {
            OpenFileDialog cargarImagen = new OpenFileDialog();

            cargarImagen.InitialDirectory = "C:\\";
            cargarImagen.Filter = "Archivos de Imagen (*.jpg)(*.jpeg)|*.jpg;*.jpeg|PNG (*.png)|*.png";

            if (cargarImagen.ShowDialog() == DialogResult.OK)
            {
                pic_socio.ImageLocation = cargarImagen.FileName;
            }
        }
    }
}
