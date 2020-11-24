namespace SportGym.GUI
{
    partial class frm_nuevo_socio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_nuevo_socio));
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.lbl_apellido = new System.Windows.Forms.Label();
            this.lbl_mail = new System.Windows.Forms.Label();
            this.lbl_dni = new System.Windows.Forms.Label();
            this.lbl_telefono = new System.Windows.Forms.Label();
            this.lbl_celular = new System.Windows.Forms.Label();
            this.txt_apellido = new System.Windows.Forms.TextBox();
            this.txt_mail = new System.Windows.Forms.TextBox();
            this.txt_dni = new System.Windows.Forms.TextBox();
            this.txt_telefono = new System.Windows.Forms.TextBox();
            this.txt_celular = new System.Windows.Forms.TextBox();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.lbl_advertencia_nombre = new System.Windows.Forms.Label();
            this.lbl_advertencia_apellido = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.combo_fin = new System.Windows.Forms.ComboBox();
            this.combo_inicio = new System.Windows.Forms.ComboBox();
            this.lbl_inicio = new System.Windows.Forms.Label();
            this.lbl_fin = new System.Windows.Forms.Label();
            this.txt_monto_pagar = new System.Windows.Forms.TextBox();
            this.lbl_monto = new System.Windows.Forms.Label();
            this.lbl_fecha_fin = new System.Windows.Forms.Label();
            this.dtp_fecha_vto = new System.Windows.Forms.DateTimePicker();
            this.lbl_fecha_inicio = new System.Windows.Forms.Label();
            this.dtp_fecha_inicio = new System.Windows.Forms.DateTimePicker();
            this.btn_guardar_pagar = new System.Windows.Forms.Button();
            this.pic_socio = new System.Windows.Forms.PictureBox();
            this.btn_tomar_foto = new System.Windows.Forms.Button();
            this.btn_foto_archivo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pic_socio)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Location = new System.Drawing.Point(529, 23);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(47, 13);
            this.lbl_nombre.TabIndex = 1;
            this.lbl_nombre.Text = "Nombre:";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(580, 20);
            this.txt_nombre.MaxLength = 50;
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(245, 20);
            this.txt_nombre.TabIndex = 1;
            this.txt_nombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_nombre_KeyPress);
            // 
            // lbl_apellido
            // 
            this.lbl_apellido.AutoSize = true;
            this.lbl_apellido.Location = new System.Drawing.Point(529, 63);
            this.lbl_apellido.Name = "lbl_apellido";
            this.lbl_apellido.Size = new System.Drawing.Size(47, 13);
            this.lbl_apellido.TabIndex = 3;
            this.lbl_apellido.Text = "Apellido:";
            // 
            // lbl_mail
            // 
            this.lbl_mail.AutoSize = true;
            this.lbl_mail.Location = new System.Drawing.Point(547, 103);
            this.lbl_mail.Name = "lbl_mail";
            this.lbl_mail.Size = new System.Drawing.Size(29, 13);
            this.lbl_mail.TabIndex = 4;
            this.lbl_mail.Text = "Mail:";
            // 
            // lbl_dni
            // 
            this.lbl_dni.AutoSize = true;
            this.lbl_dni.Location = new System.Drawing.Point(547, 143);
            this.lbl_dni.Name = "lbl_dni";
            this.lbl_dni.Size = new System.Drawing.Size(29, 13);
            this.lbl_dni.TabIndex = 5;
            this.lbl_dni.Text = "DNI:";
            // 
            // lbl_telefono
            // 
            this.lbl_telefono.AutoSize = true;
            this.lbl_telefono.Location = new System.Drawing.Point(524, 183);
            this.lbl_telefono.Name = "lbl_telefono";
            this.lbl_telefono.Size = new System.Drawing.Size(52, 13);
            this.lbl_telefono.TabIndex = 6;
            this.lbl_telefono.Text = "Telefono:";
            // 
            // lbl_celular
            // 
            this.lbl_celular.AutoSize = true;
            this.lbl_celular.Location = new System.Drawing.Point(534, 223);
            this.lbl_celular.Name = "lbl_celular";
            this.lbl_celular.Size = new System.Drawing.Size(42, 13);
            this.lbl_celular.TabIndex = 7;
            this.lbl_celular.Text = "Celular:";
            // 
            // txt_apellido
            // 
            this.txt_apellido.Location = new System.Drawing.Point(580, 60);
            this.txt_apellido.MaxLength = 50;
            this.txt_apellido.Name = "txt_apellido";
            this.txt_apellido.Size = new System.Drawing.Size(245, 20);
            this.txt_apellido.TabIndex = 2;
            this.txt_apellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_apellido_KeyPress);
            // 
            // txt_mail
            // 
            this.txt_mail.Location = new System.Drawing.Point(582, 100);
            this.txt_mail.MaxLength = 80;
            this.txt_mail.Name = "txt_mail";
            this.txt_mail.Size = new System.Drawing.Size(245, 20);
            this.txt_mail.TabIndex = 3;
            this.txt_mail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_mail_KeyPress);
            // 
            // txt_dni
            // 
            this.txt_dni.Location = new System.Drawing.Point(582, 140);
            this.txt_dni.MaxLength = 10;
            this.txt_dni.Name = "txt_dni";
            this.txt_dni.Size = new System.Drawing.Size(100, 20);
            this.txt_dni.TabIndex = 4;
            this.txt_dni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_dni_KeyPress);
            // 
            // txt_telefono
            // 
            this.txt_telefono.Location = new System.Drawing.Point(582, 180);
            this.txt_telefono.MaxLength = 12;
            this.txt_telefono.Name = "txt_telefono";
            this.txt_telefono.Size = new System.Drawing.Size(100, 20);
            this.txt_telefono.TabIndex = 5;
            this.txt_telefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_telefono_KeyPress);
            // 
            // txt_celular
            // 
            this.txt_celular.Location = new System.Drawing.Point(582, 220);
            this.txt_celular.MaxLength = 12;
            this.txt_celular.Name = "txt_celular";
            this.txt_celular.Size = new System.Drawing.Size(100, 20);
            this.txt_celular.TabIndex = 6;
            this.txt_celular.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_celular_KeyPress);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cancelar.Location = new System.Drawing.Point(856, 450);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(102, 42);
            this.btn_cancelar.TabIndex = 13;
            this.btn_cancelar.Text = "Salir";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // lbl_advertencia_nombre
            // 
            this.lbl_advertencia_nombre.AutoSize = true;
            this.lbl_advertencia_nombre.Location = new System.Drawing.Point(833, 23);
            this.lbl_advertencia_nombre.Name = "lbl_advertencia_nombre";
            this.lbl_advertencia_nombre.Size = new System.Drawing.Size(125, 13);
            this.lbl_advertencia_nombre.TabIndex = 15;
            this.lbl_advertencia_nombre.Text = "* (Maximo 50 Caracteres)";
            // 
            // lbl_advertencia_apellido
            // 
            this.lbl_advertencia_apellido.AutoSize = true;
            this.lbl_advertencia_apellido.Location = new System.Drawing.Point(833, 63);
            this.lbl_advertencia_apellido.Name = "lbl_advertencia_apellido";
            this.lbl_advertencia_apellido.Size = new System.Drawing.Size(125, 13);
            this.lbl_advertencia_apellido.TabIndex = 16;
            this.lbl_advertencia_apellido.Text = "* (Maximo 50 Caracteres)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(840, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "(Maximo 80 Caracteres)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(688, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "(Maximo 10 Caracteres)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(688, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "(Maximo 12 Caracteres)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(688, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "(Maximo 12 Caracteres)";
            // 
            // combo_fin
            // 
            this.combo_fin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_fin.FormattingEnabled = true;
            this.combo_fin.Location = new System.Drawing.Point(582, 300);
            this.combo_fin.Name = "combo_fin";
            this.combo_fin.Size = new System.Drawing.Size(60, 21);
            this.combo_fin.TabIndex = 8;
            // 
            // combo_inicio
            // 
            this.combo_inicio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_inicio.FormattingEnabled = true;
            this.combo_inicio.Location = new System.Drawing.Point(582, 260);
            this.combo_inicio.Name = "combo_inicio";
            this.combo_inicio.Size = new System.Drawing.Size(60, 21);
            this.combo_inicio.TabIndex = 7;
            this.combo_inicio.SelectedIndexChanged += new System.EventHandler(this.combo_inicio_SelectedIndexChanged);
            // 
            // lbl_inicio
            // 
            this.lbl_inicio.AutoSize = true;
            this.lbl_inicio.Location = new System.Drawing.Point(515, 263);
            this.lbl_inicio.Name = "lbl_inicio";
            this.lbl_inicio.Size = new System.Drawing.Size(61, 13);
            this.lbl_inicio.TabIndex = 23;
            this.lbl_inicio.Text = "Hora Inicio:";
            // 
            // lbl_fin
            // 
            this.lbl_fin.AutoSize = true;
            this.lbl_fin.Location = new System.Drawing.Point(526, 303);
            this.lbl_fin.Name = "lbl_fin";
            this.lbl_fin.Size = new System.Drawing.Size(50, 13);
            this.lbl_fin.TabIndex = 24;
            this.lbl_fin.Text = "Hora Fin:";
            // 
            // txt_monto_pagar
            // 
            this.txt_monto_pagar.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_monto_pagar.Location = new System.Drawing.Point(580, 380);
            this.txt_monto_pagar.MaxLength = 10;
            this.txt_monto_pagar.Name = "txt_monto_pagar";
            this.txt_monto_pagar.Size = new System.Drawing.Size(100, 26);
            this.txt_monto_pagar.TabIndex = 11;
            this.txt_monto_pagar.TextChanged += new System.EventHandler(this.txt_monto_pagar_TextChanged);
            this.txt_monto_pagar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_monto_pagar_KeyPress);
            // 
            // lbl_monto
            // 
            this.lbl_monto.AutoSize = true;
            this.lbl_monto.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_monto.Location = new System.Drawing.Point(522, 383);
            this.lbl_monto.Name = "lbl_monto";
            this.lbl_monto.Size = new System.Drawing.Size(54, 18);
            this.lbl_monto.TabIndex = 29;
            this.lbl_monto.Text = "Monto:";
            // 
            // lbl_fecha_fin
            // 
            this.lbl_fecha_fin.AutoSize = true;
            this.lbl_fecha_fin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fecha_fin.Location = new System.Drawing.Point(727, 349);
            this.lbl_fecha_fin.Name = "lbl_fecha_fin";
            this.lbl_fecha_fin.Size = new System.Drawing.Size(57, 13);
            this.lbl_fecha_fin.TabIndex = 28;
            this.lbl_fecha_fin.Text = "Fecha Fin:";
            // 
            // dtp_fecha_vto
            // 
            this.dtp_fecha_vto.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_fecha_vto.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_fecha_vto.Location = new System.Drawing.Point(790, 340);
            this.dtp_fecha_vto.Name = "dtp_fecha_vto";
            this.dtp_fecha_vto.Size = new System.Drawing.Size(132, 26);
            this.dtp_fecha_vto.TabIndex = 10;
            // 
            // lbl_fecha_inicio
            // 
            this.lbl_fecha_inicio.AutoSize = true;
            this.lbl_fecha_inicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fecha_inicio.Location = new System.Drawing.Point(508, 349);
            this.lbl_fecha_inicio.Name = "lbl_fecha_inicio";
            this.lbl_fecha_inicio.Size = new System.Drawing.Size(68, 13);
            this.lbl_fecha_inicio.TabIndex = 26;
            this.lbl_fecha_inicio.Text = "Fecha Inicio:";
            // 
            // dtp_fecha_inicio
            // 
            this.dtp_fecha_inicio.CalendarFont = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_fecha_inicio.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_fecha_inicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_fecha_inicio.Location = new System.Drawing.Point(580, 340);
            this.dtp_fecha_inicio.Name = "dtp_fecha_inicio";
            this.dtp_fecha_inicio.Size = new System.Drawing.Size(132, 26);
            this.dtp_fecha_inicio.TabIndex = 9;
            this.dtp_fecha_inicio.ValueChanged += new System.EventHandler(this.dtp_fecha_inicio_ValueChanged);
            // 
            // btn_guardar_pagar
            // 
            this.btn_guardar_pagar.Enabled = false;
            this.btn_guardar_pagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardar_pagar.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_guardar_pagar.Location = new System.Drawing.Point(725, 450);
            this.btn_guardar_pagar.Name = "btn_guardar_pagar";
            this.btn_guardar_pagar.Size = new System.Drawing.Size(102, 42);
            this.btn_guardar_pagar.TabIndex = 12;
            this.btn_guardar_pagar.Text = "Guardar";
            this.btn_guardar_pagar.UseVisualStyleBackColor = true;
            this.btn_guardar_pagar.Click += new System.EventHandler(this.btn_guardar_pagar_Click);
            // 
            // pic_socio
            // 
            this.pic_socio.Image = global::SportGym.Properties.Resources.camera;
            this.pic_socio.InitialImage = global::SportGym.Properties.Resources.camera;
            this.pic_socio.Location = new System.Drawing.Point(12, 20);
            this.pic_socio.Name = "pic_socio";
            this.pic_socio.Size = new System.Drawing.Size(480, 386);
            this.pic_socio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_socio.TabIndex = 30;
            this.pic_socio.TabStop = false;
            // 
            // btn_tomar_foto
            // 
            this.btn_tomar_foto.Location = new System.Drawing.Point(12, 412);
            this.btn_tomar_foto.Name = "btn_tomar_foto";
            this.btn_tomar_foto.Size = new System.Drawing.Size(210, 60);
            this.btn_tomar_foto.TabIndex = 31;
            this.btn_tomar_foto.Text = "Tomar Foto";
            this.btn_tomar_foto.UseVisualStyleBackColor = true;
            this.btn_tomar_foto.Click += new System.EventHandler(this.btn_tomar_foto_Click);
            // 
            // btn_foto_archivo
            // 
            this.btn_foto_archivo.Location = new System.Drawing.Point(282, 412);
            this.btn_foto_archivo.Name = "btn_foto_archivo";
            this.btn_foto_archivo.Size = new System.Drawing.Size(210, 60);
            this.btn_foto_archivo.TabIndex = 32;
            this.btn_foto_archivo.Text = "Cargar Foto";
            this.btn_foto_archivo.UseVisualStyleBackColor = true;
            this.btn_foto_archivo.Click += new System.EventHandler(this.btn_foto_archivo_Click);
            // 
            // frm_nuevo_socio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.CancelButton = this.btn_cancelar;
            this.ClientSize = new System.Drawing.Size(964, 501);
            this.Controls.Add(this.btn_foto_archivo);
            this.Controls.Add(this.btn_tomar_foto);
            this.Controls.Add(this.pic_socio);
            this.Controls.Add(this.btn_guardar_pagar);
            this.Controls.Add(this.txt_monto_pagar);
            this.Controls.Add(this.lbl_monto);
            this.Controls.Add(this.lbl_fecha_fin);
            this.Controls.Add(this.dtp_fecha_vto);
            this.Controls.Add(this.lbl_fecha_inicio);
            this.Controls.Add(this.dtp_fecha_inicio);
            this.Controls.Add(this.lbl_fin);
            this.Controls.Add(this.lbl_inicio);
            this.Controls.Add(this.combo_fin);
            this.Controls.Add(this.combo_inicio);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_advertencia_apellido);
            this.Controls.Add(this.lbl_advertencia_nombre);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.txt_celular);
            this.Controls.Add(this.txt_telefono);
            this.Controls.Add(this.txt_dni);
            this.Controls.Add(this.txt_mail);
            this.Controls.Add(this.txt_apellido);
            this.Controls.Add(this.lbl_celular);
            this.Controls.Add(this.lbl_telefono);
            this.Controls.Add(this.lbl_dni);
            this.Controls.Add(this.lbl_mail);
            this.Controls.Add(this.lbl_apellido);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.lbl_nombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_nuevo_socio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Nuevo Socio";
            this.Load += new System.EventHandler(this.frm_nuevo_socio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_socio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label lbl_apellido;
        private System.Windows.Forms.Label lbl_mail;
        private System.Windows.Forms.Label lbl_dni;
        private System.Windows.Forms.Label lbl_telefono;
        private System.Windows.Forms.Label lbl_celular;
        private System.Windows.Forms.TextBox txt_apellido;
        private System.Windows.Forms.TextBox txt_mail;
        private System.Windows.Forms.TextBox txt_dni;
        private System.Windows.Forms.TextBox txt_telefono;
        private System.Windows.Forms.TextBox txt_celular;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Label lbl_advertencia_nombre;
        private System.Windows.Forms.Label lbl_advertencia_apellido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox combo_fin;
        private System.Windows.Forms.ComboBox combo_inicio;
        private System.Windows.Forms.Label lbl_inicio;
        private System.Windows.Forms.Label lbl_fin;
        private System.Windows.Forms.TextBox txt_monto_pagar;
        private System.Windows.Forms.Label lbl_monto;
        private System.Windows.Forms.Label lbl_fecha_fin;
        private System.Windows.Forms.DateTimePicker dtp_fecha_vto;
        private System.Windows.Forms.Label lbl_fecha_inicio;
        private System.Windows.Forms.DateTimePicker dtp_fecha_inicio;
        private System.Windows.Forms.Button btn_guardar_pagar;
        private System.Windows.Forms.PictureBox pic_socio;
        private System.Windows.Forms.Button btn_tomar_foto;
        private System.Windows.Forms.Button btn_foto_archivo;
    }
}