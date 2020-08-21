namespace SportGym.GUI
{
    partial class frm_editar_socio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_editar_socio));
            this.lbl_advertencia_celular = new System.Windows.Forms.Label();
            this.lbl_advertencia_telefono = new System.Windows.Forms.Label();
            this.lbl_advertencia_dni = new System.Windows.Forms.Label();
            this.lbl_advertencia_mail = new System.Windows.Forms.Label();
            this.lbl_advertencia_apellido = new System.Windows.Forms.Label();
            this.lbl_advertencia_nombre = new System.Windows.Forms.Label();
            this.lbl_info = new System.Windows.Forms.Label();
            this.btn_salir_editar = new System.Windows.Forms.Button();
            this.txt_celular = new System.Windows.Forms.TextBox();
            this.txt_telefono = new System.Windows.Forms.TextBox();
            this.txt_dni = new System.Windows.Forms.TextBox();
            this.txt_mail = new System.Windows.Forms.TextBox();
            this.txt_apellido = new System.Windows.Forms.TextBox();
            this.lbl_celular = new System.Windows.Forms.Label();
            this.lbl_telefono = new System.Windows.Forms.Label();
            this.lbl_dni = new System.Windows.Forms.Label();
            this.lbl_mail = new System.Windows.Forms.Label();
            this.lbl_apellido = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.check_editar = new System.Windows.Forms.CheckBox();
            this.lbl_fin = new System.Windows.Forms.Label();
            this.lbl_inicio = new System.Windows.Forms.Label();
            this.combo_fin = new System.Windows.Forms.ComboBox();
            this.combo_inicio = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lbl_advertencia_celular
            // 
            this.lbl_advertencia_celular.AutoSize = true;
            this.lbl_advertencia_celular.Location = new System.Drawing.Point(176, 198);
            this.lbl_advertencia_celular.Name = "lbl_advertencia_celular";
            this.lbl_advertencia_celular.Size = new System.Drawing.Size(301, 13);
            this.lbl_advertencia_celular.TabIndex = 41;
            this.lbl_advertencia_celular.Text = "(Maximo 12 Caracteres). Solo numeros, sin guiones o espacios";
            this.lbl_advertencia_celular.Visible = false;
            // 
            // lbl_advertencia_telefono
            // 
            this.lbl_advertencia_telefono.AutoSize = true;
            this.lbl_advertencia_telefono.Location = new System.Drawing.Point(176, 157);
            this.lbl_advertencia_telefono.Name = "lbl_advertencia_telefono";
            this.lbl_advertencia_telefono.Size = new System.Drawing.Size(301, 13);
            this.lbl_advertencia_telefono.TabIndex = 40;
            this.lbl_advertencia_telefono.Text = "(Maximo 12 Caracteres). Solo numeros, sin guiones o espacios";
            this.lbl_advertencia_telefono.Visible = false;
            // 
            // lbl_advertencia_dni
            // 
            this.lbl_advertencia_dni.AutoSize = true;
            this.lbl_advertencia_dni.Location = new System.Drawing.Point(176, 120);
            this.lbl_advertencia_dni.Name = "lbl_advertencia_dni";
            this.lbl_advertencia_dni.Size = new System.Drawing.Size(188, 13);
            this.lbl_advertencia_dni.TabIndex = 39;
            this.lbl_advertencia_dni.Text = "(Maximo 10 Caracteres). Solo numeros";
            this.lbl_advertencia_dni.Visible = false;
            // 
            // lbl_advertencia_mail
            // 
            this.lbl_advertencia_mail.AutoSize = true;
            this.lbl_advertencia_mail.Location = new System.Drawing.Point(328, 85);
            this.lbl_advertencia_mail.Name = "lbl_advertencia_mail";
            this.lbl_advertencia_mail.Size = new System.Drawing.Size(118, 13);
            this.lbl_advertencia_mail.TabIndex = 38;
            this.lbl_advertencia_mail.Text = "(Maximo 80 Caracteres)";
            this.lbl_advertencia_mail.Visible = false;
            // 
            // lbl_advertencia_apellido
            // 
            this.lbl_advertencia_apellido.AutoSize = true;
            this.lbl_advertencia_apellido.Location = new System.Drawing.Point(321, 50);
            this.lbl_advertencia_apellido.Name = "lbl_advertencia_apellido";
            this.lbl_advertencia_apellido.Size = new System.Drawing.Size(125, 13);
            this.lbl_advertencia_apellido.TabIndex = 37;
            this.lbl_advertencia_apellido.Text = "* (Maximo 50 Caracteres)";
            this.lbl_advertencia_apellido.Visible = false;
            // 
            // lbl_advertencia_nombre
            // 
            this.lbl_advertencia_nombre.AutoSize = true;
            this.lbl_advertencia_nombre.Location = new System.Drawing.Point(321, 15);
            this.lbl_advertencia_nombre.Name = "lbl_advertencia_nombre";
            this.lbl_advertencia_nombre.Size = new System.Drawing.Size(125, 13);
            this.lbl_advertencia_nombre.TabIndex = 36;
            this.lbl_advertencia_nombre.Text = "* (Maximo 50 Caracteres)";
            this.lbl_advertencia_nombre.Visible = false;
            // 
            // lbl_info
            // 
            this.lbl_info.AutoSize = true;
            this.lbl_info.Enabled = false;
            this.lbl_info.Location = new System.Drawing.Point(277, 265);
            this.lbl_info.Name = "lbl_info";
            this.lbl_info.Size = new System.Drawing.Size(108, 13);
            this.lbl_info.TabIndex = 35;
            this.lbl_info.Text = "* Campos obligatorios";
            // 
            // btn_salir_editar
            // 
            this.btn_salir_editar.Location = new System.Drawing.Point(371, 306);
            this.btn_salir_editar.Name = "btn_salir_editar";
            this.btn_salir_editar.Size = new System.Drawing.Size(75, 23);
            this.btn_salir_editar.TabIndex = 34;
            this.btn_salir_editar.Text = "Salir";
            this.btn_salir_editar.UseVisualStyleBackColor = true;
            this.btn_salir_editar.Click += new System.EventHandler(this.btn_salir_editar_Click);
            // 
            // txt_celular
            // 
            this.txt_celular.Location = new System.Drawing.Point(70, 195);
            this.txt_celular.MaxLength = 12;
            this.txt_celular.Name = "txt_celular";
            this.txt_celular.ReadOnly = true;
            this.txt_celular.Size = new System.Drawing.Size(100, 20);
            this.txt_celular.TabIndex = 33;
            this.txt_celular.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_celular_KeyPress);
            // 
            // txt_telefono
            // 
            this.txt_telefono.Location = new System.Drawing.Point(70, 154);
            this.txt_telefono.MaxLength = 12;
            this.txt_telefono.Name = "txt_telefono";
            this.txt_telefono.ReadOnly = true;
            this.txt_telefono.Size = new System.Drawing.Size(100, 20);
            this.txt_telefono.TabIndex = 32;
            this.txt_telefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_telefono_KeyPress);
            // 
            // txt_dni
            // 
            this.txt_dni.Location = new System.Drawing.Point(70, 117);
            this.txt_dni.MaxLength = 10;
            this.txt_dni.Name = "txt_dni";
            this.txt_dni.ReadOnly = true;
            this.txt_dni.Size = new System.Drawing.Size(100, 20);
            this.txt_dni.TabIndex = 31;
            this.txt_dni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_dni_KeyPress);
            // 
            // txt_mail
            // 
            this.txt_mail.Location = new System.Drawing.Point(70, 82);
            this.txt_mail.MaxLength = 80;
            this.txt_mail.Name = "txt_mail";
            this.txt_mail.ReadOnly = true;
            this.txt_mail.Size = new System.Drawing.Size(245, 20);
            this.txt_mail.TabIndex = 30;
            // 
            // txt_apellido
            // 
            this.txt_apellido.Location = new System.Drawing.Point(70, 47);
            this.txt_apellido.MaxLength = 50;
            this.txt_apellido.Name = "txt_apellido";
            this.txt_apellido.ReadOnly = true;
            this.txt_apellido.Size = new System.Drawing.Size(245, 20);
            this.txt_apellido.TabIndex = 29;
            this.txt_apellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_apellido_KeyPress);
            // 
            // lbl_celular
            // 
            this.lbl_celular.AutoSize = true;
            this.lbl_celular.Location = new System.Drawing.Point(22, 198);
            this.lbl_celular.Name = "lbl_celular";
            this.lbl_celular.Size = new System.Drawing.Size(42, 13);
            this.lbl_celular.TabIndex = 28;
            this.lbl_celular.Text = "Celular:";
            // 
            // lbl_telefono
            // 
            this.lbl_telefono.AutoSize = true;
            this.lbl_telefono.Location = new System.Drawing.Point(12, 157);
            this.lbl_telefono.Name = "lbl_telefono";
            this.lbl_telefono.Size = new System.Drawing.Size(52, 13);
            this.lbl_telefono.TabIndex = 27;
            this.lbl_telefono.Text = "Telefono:";
            // 
            // lbl_dni
            // 
            this.lbl_dni.AutoSize = true;
            this.lbl_dni.Location = new System.Drawing.Point(35, 120);
            this.lbl_dni.Name = "lbl_dni";
            this.lbl_dni.Size = new System.Drawing.Size(29, 13);
            this.lbl_dni.TabIndex = 26;
            this.lbl_dni.Text = "DNI:";
            // 
            // lbl_mail
            // 
            this.lbl_mail.AutoSize = true;
            this.lbl_mail.Location = new System.Drawing.Point(35, 85);
            this.lbl_mail.Name = "lbl_mail";
            this.lbl_mail.Size = new System.Drawing.Size(29, 13);
            this.lbl_mail.TabIndex = 25;
            this.lbl_mail.Text = "Mail:";
            // 
            // lbl_apellido
            // 
            this.lbl_apellido.AutoSize = true;
            this.lbl_apellido.Location = new System.Drawing.Point(17, 50);
            this.lbl_apellido.Name = "lbl_apellido";
            this.lbl_apellido.Size = new System.Drawing.Size(47, 13);
            this.lbl_apellido.TabIndex = 24;
            this.lbl_apellido.Text = "Apellido:";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(70, 12);
            this.txt_nombre.MaxLength = 50;
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.ReadOnly = true;
            this.txt_nombre.Size = new System.Drawing.Size(245, 20);
            this.txt_nombre.TabIndex = 23;
            this.txt_nombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_nombre_KeyPress);
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Location = new System.Drawing.Point(17, 15);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(47, 13);
            this.lbl_nombre.TabIndex = 22;
            this.lbl_nombre.Text = "Nombre:";
            // 
            // btn_guardar
            // 
            this.btn_guardar.Enabled = false;
            this.btn_guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardar.ForeColor = System.Drawing.Color.Green;
            this.btn_guardar.Location = new System.Drawing.Point(280, 306);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(75, 23);
            this.btn_guardar.TabIndex = 21;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Visible = false;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // check_editar
            // 
            this.check_editar.AutoSize = true;
            this.check_editar.Location = new System.Drawing.Point(70, 306);
            this.check_editar.Name = "check_editar";
            this.check_editar.Size = new System.Drawing.Size(53, 17);
            this.check_editar.TabIndex = 42;
            this.check_editar.Text = "Editar";
            this.check_editar.UseVisualStyleBackColor = true;
            this.check_editar.CheckedChanged += new System.EventHandler(this.check_editar_CheckedChanged);
            // 
            // lbl_fin
            // 
            this.lbl_fin.AutoSize = true;
            this.lbl_fin.Location = new System.Drawing.Point(14, 268);
            this.lbl_fin.Name = "lbl_fin";
            this.lbl_fin.Size = new System.Drawing.Size(50, 13);
            this.lbl_fin.TabIndex = 46;
            this.lbl_fin.Text = "Hora Fin:";
            // 
            // lbl_inicio
            // 
            this.lbl_inicio.AutoSize = true;
            this.lbl_inicio.Location = new System.Drawing.Point(3, 231);
            this.lbl_inicio.Name = "lbl_inicio";
            this.lbl_inicio.Size = new System.Drawing.Size(61, 13);
            this.lbl_inicio.TabIndex = 45;
            this.lbl_inicio.Text = "Hora Inicio:";
            // 
            // combo_fin
            // 
            this.combo_fin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_fin.FormattingEnabled = true;
            this.combo_fin.Location = new System.Drawing.Point(70, 265);
            this.combo_fin.Name = "combo_fin";
            this.combo_fin.Size = new System.Drawing.Size(60, 21);
            this.combo_fin.TabIndex = 44;
            // 
            // combo_inicio
            // 
            this.combo_inicio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_inicio.FormattingEnabled = true;
            this.combo_inicio.Location = new System.Drawing.Point(70, 228);
            this.combo_inicio.Name = "combo_inicio";
            this.combo_inicio.Size = new System.Drawing.Size(60, 21);
            this.combo_inicio.TabIndex = 43;
            // 
            // frm_editar_socio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(484, 341);
            this.Controls.Add(this.lbl_fin);
            this.Controls.Add(this.lbl_inicio);
            this.Controls.Add(this.combo_fin);
            this.Controls.Add(this.combo_inicio);
            this.Controls.Add(this.check_editar);
            this.Controls.Add(this.lbl_advertencia_celular);
            this.Controls.Add(this.lbl_advertencia_telefono);
            this.Controls.Add(this.lbl_advertencia_dni);
            this.Controls.Add(this.lbl_advertencia_mail);
            this.Controls.Add(this.lbl_advertencia_apellido);
            this.Controls.Add(this.lbl_advertencia_nombre);
            this.Controls.Add(this.lbl_info);
            this.Controls.Add(this.btn_salir_editar);
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
            this.Controls.Add(this.btn_guardar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_editar_socio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ver/Editar socio";
            this.Load += new System.EventHandler(this.frm_editar_socio_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_advertencia_celular;
        private System.Windows.Forms.Label lbl_advertencia_telefono;
        private System.Windows.Forms.Label lbl_advertencia_dni;
        private System.Windows.Forms.Label lbl_advertencia_mail;
        private System.Windows.Forms.Label lbl_advertencia_apellido;
        private System.Windows.Forms.Label lbl_advertencia_nombre;
        private System.Windows.Forms.Label lbl_info;
        private System.Windows.Forms.Button btn_salir_editar;
        private System.Windows.Forms.TextBox txt_celular;
        private System.Windows.Forms.TextBox txt_telefono;
        private System.Windows.Forms.TextBox txt_dni;
        private System.Windows.Forms.TextBox txt_mail;
        private System.Windows.Forms.TextBox txt_apellido;
        private System.Windows.Forms.Label lbl_celular;
        private System.Windows.Forms.Label lbl_telefono;
        private System.Windows.Forms.Label lbl_dni;
        private System.Windows.Forms.Label lbl_mail;
        private System.Windows.Forms.Label lbl_apellido;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.CheckBox check_editar;
        private System.Windows.Forms.Label lbl_fin;
        private System.Windows.Forms.Label lbl_inicio;
        private System.Windows.Forms.ComboBox combo_fin;
        private System.Windows.Forms.ComboBox combo_inicio;
    }
}