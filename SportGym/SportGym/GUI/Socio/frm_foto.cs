﻿using AForge.Video;
using AForge.Video.DirectShow;
using SportGym.Interface;
using SportGym.Properties;
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
    public partial class frm_foto : Form
    {
        private bool hayDispositivos;
        private frm_editar_socio frm_editar;
        private frm_nuevo_socio frm_nuevo;
        private FilterInfoCollection lista_dispositivos;
        private VideoCaptureDevice dispositivo;

        public frm_foto(frm_nuevo_socio form)
        {
            InitializeComponent();
            this.frm_nuevo = form;
        }
        public frm_foto(frm_editar_socio form)
        {
            InitializeComponent();
            this.frm_editar = form;
        }

        private void frm_foto_Load(object sender, EventArgs e)
        {
            this.cargarDispositivos();
            if(hayDispositivos == true)
            {
                this.inicializarDispositivo();
                combo_dispositivos.SelectedIndex = 0;
            }
        }

        private void btn_tomar_foto_Click(object sender, EventArgs e)
        {
            if(dispositivo != null && dispositivo.IsRunning)
            {
                pic_foto_tomada.Image = pic_foto_vivo.Image;
                if(frm_nuevo != null)
                {
                    frm_nuevo.recibirFoto(pic_foto_tomada.Image);
                }
                else
                {
                    frm_editar.recibirFoto(pic_foto_tomada.Image);
                }
                btn_borrar_foto.Enabled = true;
            }
        }

        private void inicializarDispositivo()
        {
            try
            {
                cerrarDispositivo();
                if(combo_dispositivos.SelectedIndex != -1)
                {
                    int i = combo_dispositivos.SelectedIndex;
                    string nombreDispositivo = lista_dispositivos[i].MonikerString;
                    dispositivo = new VideoCaptureDevice(nombreDispositivo);
                    dispositivo.NewFrame += new NewFrameEventHandler(capturar);
                    dispositivo.Start();
                }
            }
            catch(Exception e)
            {
                MessageBox.Show("Error al intentar inicializar la camara: Mensaje: " + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }         
        }
        private void cerrarDispositivo()
        {
            if(dispositivo != null && dispositivo.IsRunning)
            {
                dispositivo.SignalToStop();
                dispositivo = null;
            }
        }
        
        
        //Metodo para cargar dispositivos de captura de video
        private void cargarDispositivos()
        {
            try
            {
                lista_dispositivos = new FilterInfoCollection(FilterCategory.VideoInputDevice);
                if (lista_dispositivos.Count > 0)
                {
                    btn_tomar_foto.Enabled = true;
                    hayDispositivos = true;
                    //ciclo para cargar los dispositivos al comboBox.
                    for (int i = 0; i < lista_dispositivos.Count; i++)
                    {
                        combo_dispositivos.Items.Add(lista_dispositivos[i].Name.ToString());
                    }
                }
                else
                {
                    hayDispositivos = false;
                }
            }
            catch(Exception e)
            {
                MessageBox.Show("Error al intentar cargar la camara: Mensaje: "+e.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            
        }

        private void capturar(object sender, NewFrameEventArgs eventArgs)
        {
            try
            {
            }
            catch(Exception e)
            {
                MessageBox.Show("Error al intentar cargar la imagen: " + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //para copiar la imagen y cargarla en el pictureBox 
            Bitmap imagen = (Bitmap)eventArgs.Frame.Clone();
            pic_foto_vivo.Image = imagen;
        }

        private void btn_borrar_foto_Click(object sender, EventArgs e)
        {
            this.pic_foto_tomada.Image = Resources.camera;
            this.btn_borrar_foto.Enabled = false;
        }

        private void frm_foto_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.cerrarDispositivo();
        }

        private void combo_dispositivos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(hayDispositivos == true && combo_dispositivos.SelectedIndex != -1)
            inicializarDispositivo();
        }

        
    }
}
