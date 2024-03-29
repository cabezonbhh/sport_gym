﻿namespace SportGym.GUI.Socio
{
    partial class frm_principal_socio
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_principal_socio));
            this.panel_main = new System.Windows.Forms.Panel();
            this.btn_vencidos = new System.Windows.Forms.Button();
            this.btn_atras = new System.Windows.Forms.Button();
            this.panel_cuota = new System.Windows.Forms.Panel();
            this.panel_botones_socio = new System.Windows.Forms.Panel();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbl_nro_socio = new System.Windows.Forms.Label();
            this.lbl_dni = new System.Windows.Forms.Label();
            this.lbl_apellido = new System.Windows.Forms.Label();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.dgv_inscripciones = new System.Windows.Forms.DataGridView();
            this.col_nro_socio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_dni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_ver_editar = new System.Windows.Forms.Button();
            this.lbl_gym = new System.Windows.Forms.Label();
            this.btn_nuevo = new System.Windows.Forms.Button();
            this.pic_gym = new System.Windows.Forms.PictureBox();
            this.panel_filtros = new System.Windows.Forms.Panel();
            this.btn_actualizar = new System.Windows.Forms.Button();
            this.txt_filtro_apellido = new System.Windows.Forms.TextBox();
            this.txt_filtro_nombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgv_socios = new System.Windows.Forms.DataGridView();
            this.col_numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_nombre_socio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_apellido_socio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_nro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_dni_socio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel_main.SuspendLayout();
            this.panel_cuota.SuspendLayout();
            this.panel_botones_socio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_inscripciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_gym)).BeginInit();
            this.panel_filtros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_socios)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_main
            // 
            this.panel_main.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel_main.Controls.Add(this.btn_vencidos);
            this.panel_main.Controls.Add(this.btn_atras);
            this.panel_main.Controls.Add(this.panel_cuota);
            this.panel_main.Controls.Add(this.btn_eliminar);
            this.panel_main.Controls.Add(this.btn_ver_editar);
            this.panel_main.Controls.Add(this.lbl_gym);
            this.panel_main.Controls.Add(this.btn_nuevo);
            this.panel_main.Controls.Add(this.pic_gym);
            this.panel_main.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_main.Location = new System.Drawing.Point(0, 0);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(260, 581);
            this.panel_main.TabIndex = 1;
            // 
            // btn_vencidos
            // 
            this.btn_vencidos.FlatAppearance.BorderSize = 0;
            this.btn_vencidos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btn_vencidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_vencidos.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_vencidos.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_vencidos.Image = global::SportGym.Properties.Resources.icons8_expired_52px1;
            this.btn_vencidos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_vencidos.Location = new System.Drawing.Point(0, 365);
            this.btn_vencidos.Name = "btn_vencidos";
            this.btn_vencidos.Size = new System.Drawing.Size(270, 64);
            this.btn_vencidos.TabIndex = 6;
            this.btn_vencidos.Text = " Vencidos";
            this.btn_vencidos.UseVisualStyleBackColor = true;
            this.btn_vencidos.Click += new System.EventHandler(this.btn_vencidos_Click);
            // 
            // btn_atras
            // 
            this.btn_atras.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_atras.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_atras.FlatAppearance.BorderSize = 0;
            this.btn_atras.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btn_atras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_atras.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_atras.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_atras.Image = global::SportGym.Properties.Resources.icons8_left_52px;
            this.btn_atras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_atras.Location = new System.Drawing.Point(0, 517);
            this.btn_atras.Name = "btn_atras";
            this.btn_atras.Size = new System.Drawing.Size(260, 64);
            this.btn_atras.TabIndex = 5;
            this.btn_atras.Text = "Atras";
            this.btn_atras.UseVisualStyleBackColor = true;
            this.btn_atras.Click += new System.EventHandler(this.btn_atras_Click);
            // 
            // panel_cuota
            // 
            this.panel_cuota.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_cuota.BackColor = System.Drawing.SystemColors.Control;
            this.panel_cuota.Controls.Add(this.panel_botones_socio);
            this.panel_cuota.Controls.Add(this.dgv_inscripciones);
            this.panel_cuota.Location = new System.Drawing.Point(270, 50);
            this.panel_cuota.Name = "panel_cuota";
            this.panel_cuota.Size = new System.Drawing.Size(1000, 531);
            this.panel_cuota.TabIndex = 4;
            // 
            // panel_botones_socio
            // 
            this.panel_botones_socio.Controls.Add(this.textBox4);
            this.panel_botones_socio.Controls.Add(this.textBox3);
            this.panel_botones_socio.Controls.Add(this.textBox2);
            this.panel_botones_socio.Controls.Add(this.textBox1);
            this.panel_botones_socio.Controls.Add(this.lbl_nro_socio);
            this.panel_botones_socio.Controls.Add(this.lbl_dni);
            this.panel_botones_socio.Controls.Add(this.lbl_apellido);
            this.panel_botones_socio.Controls.Add(this.lbl_nombre);
            this.panel_botones_socio.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_botones_socio.Location = new System.Drawing.Point(0, 395);
            this.panel_botones_socio.Name = "panel_botones_socio";
            this.panel_botones_socio.Size = new System.Drawing.Size(1000, 136);
            this.panel_botones_socio.TabIndex = 5;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(419, 57);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(113, 20);
            this.textBox4.TabIndex = 10;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(419, 19);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(113, 20);
            this.textBox3.TabIndex = 9;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(65, 57);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(202, 20);
            this.textBox2.TabIndex = 8;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(65, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(202, 20);
            this.textBox1.TabIndex = 7;
            // 
            // lbl_nro_socio
            // 
            this.lbl_nro_socio.AutoSize = true;
            this.lbl_nro_socio.Location = new System.Drawing.Point(353, 60);
            this.lbl_nro_socio.Name = "lbl_nro_socio";
            this.lbl_nro_socio.Size = new System.Drawing.Size(60, 13);
            this.lbl_nro_socio.TabIndex = 6;
            this.lbl_nro_socio.Text = "Nro. Socio:";
            // 
            // lbl_dni
            // 
            this.lbl_dni.AutoSize = true;
            this.lbl_dni.Location = new System.Drawing.Point(384, 22);
            this.lbl_dni.Name = "lbl_dni";
            this.lbl_dni.Size = new System.Drawing.Size(29, 13);
            this.lbl_dni.TabIndex = 4;
            this.lbl_dni.Text = "DNI:";
            // 
            // lbl_apellido
            // 
            this.lbl_apellido.AutoSize = true;
            this.lbl_apellido.Location = new System.Drawing.Point(12, 60);
            this.lbl_apellido.Name = "lbl_apellido";
            this.lbl_apellido.Size = new System.Drawing.Size(47, 13);
            this.lbl_apellido.TabIndex = 2;
            this.lbl_apellido.Text = "Apellido:";
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Location = new System.Drawing.Point(12, 22);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(47, 13);
            this.lbl_nombre.TabIndex = 0;
            this.lbl_nombre.Text = "Nombre:";
            // 
            // dgv_inscripciones
            // 
            this.dgv_inscripciones.AllowUserToAddRows = false;
            this.dgv_inscripciones.AllowUserToDeleteRows = false;
            this.dgv_inscripciones.AllowUserToOrderColumns = true;
            this.dgv_inscripciones.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_inscripciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_inscripciones.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_inscripciones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_inscripciones.ColumnHeadersHeight = 30;
            this.dgv_inscripciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_nro_socio,
            this.col_nombre,
            this.col_apellido,
            this.col_dni});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_inscripciones.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_inscripciones.Location = new System.Drawing.Point(15, 6);
            this.dgv_inscripciones.MultiSelect = false;
            this.dgv_inscripciones.Name = "dgv_inscripciones";
            this.dgv_inscripciones.ReadOnly = true;
            this.dgv_inscripciones.RowHeadersVisible = false;
            this.dgv_inscripciones.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgv_inscripciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_inscripciones.Size = new System.Drawing.Size(973, 394);
            this.dgv_inscripciones.TabIndex = 4;
            // 
            // col_nro_socio
            // 
            this.col_nro_socio.HeaderText = "N° Socio";
            this.col_nro_socio.MinimumWidth = 10;
            this.col_nro_socio.Name = "col_nro_socio";
            this.col_nro_socio.ReadOnly = true;
            // 
            // col_nombre
            // 
            this.col_nombre.HeaderText = "Nombre";
            this.col_nombre.MinimumWidth = 10;
            this.col_nombre.Name = "col_nombre";
            this.col_nombre.ReadOnly = true;
            // 
            // col_apellido
            // 
            this.col_apellido.HeaderText = "Apellido";
            this.col_apellido.MinimumWidth = 10;
            this.col_apellido.Name = "col_apellido";
            this.col_apellido.ReadOnly = true;
            // 
            // col_dni
            // 
            this.col_dni.HeaderText = "DNI";
            this.col_dni.Name = "col_dni";
            this.col_dni.ReadOnly = true;
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Enabled = false;
            this.btn_eliminar.FlatAppearance.BorderSize = 0;
            this.btn_eliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btn_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_eliminar.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eliminar.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_eliminar.Image = global::SportGym.Properties.Resources.icons8_denied_52px;
            this.btn_eliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_eliminar.Location = new System.Drawing.Point(0, 295);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(270, 64);
            this.btn_eliminar.TabIndex = 2;
            this.btn_eliminar.Text = " Eliminar Socio";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // btn_ver_editar
            // 
            this.btn_ver_editar.Enabled = false;
            this.btn_ver_editar.FlatAppearance.BorderSize = 0;
            this.btn_ver_editar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btn_ver_editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ver_editar.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ver_editar.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_ver_editar.Image = global::SportGym.Properties.Resources.icons8_registration_52px;
            this.btn_ver_editar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ver_editar.Location = new System.Drawing.Point(0, 225);
            this.btn_ver_editar.Name = "btn_ver_editar";
            this.btn_ver_editar.Size = new System.Drawing.Size(270, 64);
            this.btn_ver_editar.TabIndex = 1;
            this.btn_ver_editar.Text = "     Ver/Editar Socio";
            this.btn_ver_editar.UseVisualStyleBackColor = true;
            this.btn_ver_editar.Click += new System.EventHandler(this.btn_ver_editar_Click);
            // 
            // lbl_gym
            // 
            this.lbl_gym.AutoSize = true;
            this.lbl_gym.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_gym.ForeColor = System.Drawing.Color.White;
            this.lbl_gym.Location = new System.Drawing.Point(118, 12);
            this.lbl_gym.Name = "lbl_gym";
            this.lbl_gym.Size = new System.Drawing.Size(135, 29);
            this.lbl_gym.TabIndex = 0;
            this.lbl_gym.Text = "Sport Gym";
            // 
            // btn_nuevo
            // 
            this.btn_nuevo.FlatAppearance.BorderSize = 0;
            this.btn_nuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btn_nuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_nuevo.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nuevo.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_nuevo.Image = global::SportGym.Properties.Resources.icons8_add_user_male_52px;
            this.btn_nuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_nuevo.Location = new System.Drawing.Point(0, 155);
            this.btn_nuevo.Name = "btn_nuevo";
            this.btn_nuevo.Size = new System.Drawing.Size(270, 64);
            this.btn_nuevo.TabIndex = 0;
            this.btn_nuevo.Text = "Nuevo Socio";
            this.btn_nuevo.UseVisualStyleBackColor = true;
            this.btn_nuevo.Click += new System.EventHandler(this.btn_nuevo_Click);
            // 
            // pic_gym
            // 
            this.pic_gym.Image = global::SportGym.Properties.Resources.icons8_weightlifting_100px_1;
            this.pic_gym.Location = new System.Drawing.Point(12, 12);
            this.pic_gym.Name = "pic_gym";
            this.pic_gym.Size = new System.Drawing.Size(100, 100);
            this.pic_gym.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_gym.TabIndex = 0;
            this.pic_gym.TabStop = false;
            // 
            // panel_filtros
            // 
            this.panel_filtros.Controls.Add(this.btn_actualizar);
            this.panel_filtros.Controls.Add(this.txt_filtro_apellido);
            this.panel_filtros.Controls.Add(this.txt_filtro_nombre);
            this.panel_filtros.Controls.Add(this.label3);
            this.panel_filtros.Controls.Add(this.label4);
            this.panel_filtros.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_filtros.Location = new System.Drawing.Point(260, 529);
            this.panel_filtros.Name = "panel_filtros";
            this.panel_filtros.Size = new System.Drawing.Size(724, 52);
            this.panel_filtros.TabIndex = 7;
            // 
            // btn_actualizar
            // 
            this.btn_actualizar.Location = new System.Drawing.Point(627, 14);
            this.btn_actualizar.Name = "btn_actualizar";
            this.btn_actualizar.Size = new System.Drawing.Size(75, 23);
            this.btn_actualizar.TabIndex = 22;
            this.btn_actualizar.Text = "Actualizar";
            this.btn_actualizar.UseVisualStyleBackColor = true;
            this.btn_actualizar.Click += new System.EventHandler(this.btn_actualizar_Click_1);
            // 
            // txt_filtro_apellido
            // 
            this.txt_filtro_apellido.Enabled = false;
            this.txt_filtro_apellido.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_filtro_apellido.Location = new System.Drawing.Point(376, 14);
            this.txt_filtro_apellido.Name = "txt_filtro_apellido";
            this.txt_filtro_apellido.Size = new System.Drawing.Size(202, 23);
            this.txt_filtro_apellido.TabIndex = 8;
            this.txt_filtro_apellido.TextChanged += new System.EventHandler(this.txt_filtro_apellido_TextChanged_1);
            this.txt_filtro_apellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_filtro_apellido_KeyPress_1);
            // 
            // txt_filtro_nombre
            // 
            this.txt_filtro_nombre.Enabled = false;
            this.txt_filtro_nombre.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_filtro_nombre.Location = new System.Drawing.Point(75, 14);
            this.txt_filtro_nombre.Name = "txt_filtro_nombre";
            this.txt_filtro_nombre.Size = new System.Drawing.Size(202, 23);
            this.txt_filtro_nombre.TabIndex = 7;
            this.txt_filtro_nombre.TextChanged += new System.EventHandler(this.txt_filtro_nombre_TextChanged_1);
            this.txt_filtro_nombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_filtro_nombre_KeyPress_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(314, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Apellido:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Nombre:";
            // 
            // dgv_socios
            // 
            this.dgv_socios.AllowUserToAddRows = false;
            this.dgv_socios.AllowUserToDeleteRows = false;
            this.dgv_socios.AllowUserToOrderColumns = true;
            this.dgv_socios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_socios.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_socios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_socios.ColumnHeadersHeight = 30;
            this.dgv_socios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_numero,
            this.col_nombre_socio,
            this.col_apellido_socio,
            this.col_nro,
            this.col_dni_socio});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_socios.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_socios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_socios.Location = new System.Drawing.Point(260, 0);
            this.dgv_socios.MultiSelect = false;
            this.dgv_socios.Name = "dgv_socios";
            this.dgv_socios.ReadOnly = true;
            this.dgv_socios.RowHeadersVisible = false;
            this.dgv_socios.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgv_socios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_socios.Size = new System.Drawing.Size(724, 581);
            this.dgv_socios.TabIndex = 6;
            this.dgv_socios.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgv_socios_CellFormatting);
            // 
            // col_numero
            // 
            this.col_numero.HeaderText = "Nº";
            this.col_numero.Name = "col_numero";
            this.col_numero.ReadOnly = true;
            // 
            // col_nombre_socio
            // 
            this.col_nombre_socio.HeaderText = "Nombre";
            this.col_nombre_socio.MinimumWidth = 10;
            this.col_nombre_socio.Name = "col_nombre_socio";
            this.col_nombre_socio.ReadOnly = true;
            // 
            // col_apellido_socio
            // 
            this.col_apellido_socio.HeaderText = "Apellido";
            this.col_apellido_socio.MinimumWidth = 10;
            this.col_apellido_socio.Name = "col_apellido_socio";
            this.col_apellido_socio.ReadOnly = true;
            // 
            // col_nro
            // 
            this.col_nro.HeaderText = "N° Socio";
            this.col_nro.MinimumWidth = 10;
            this.col_nro.Name = "col_nro";
            this.col_nro.ReadOnly = true;
            this.col_nro.Visible = false;
            // 
            // col_dni_socio
            // 
            this.col_dni_socio.HeaderText = "DNI";
            this.col_dni_socio.Name = "col_dni_socio";
            this.col_dni_socio.ReadOnly = true;
            // 
            // frm_principal_socio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.CancelButton = this.btn_atras;
            this.ClientSize = new System.Drawing.Size(984, 581);
            this.Controls.Add(this.panel_filtros);
            this.Controls.Add(this.dgv_socios);
            this.Controls.Add(this.panel_main);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(640, 480);
            this.Name = "frm_principal_socio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Socios";
            this.Load += new System.EventHandler(this.frm_principal_socio_Load);
            this.panel_main.ResumeLayout(false);
            this.panel_main.PerformLayout();
            this.panel_cuota.ResumeLayout(false);
            this.panel_botones_socio.ResumeLayout(false);
            this.panel_botones_socio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_inscripciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_gym)).EndInit();
            this.panel_filtros.ResumeLayout(false);
            this.panel_filtros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_socios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_main;
        private System.Windows.Forms.Button btn_ver_editar;
        private System.Windows.Forms.Label lbl_gym;
        private System.Windows.Forms.Button btn_nuevo;
        private System.Windows.Forms.PictureBox pic_gym;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Panel panel_cuota;
        private System.Windows.Forms.Panel panel_botones_socio;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbl_nro_socio;
        private System.Windows.Forms.Label lbl_dni;
        private System.Windows.Forms.Label lbl_apellido;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.DataGridView dgv_inscripciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_nro_socio;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_dni;
        private System.Windows.Forms.Button btn_atras;
        private System.Windows.Forms.Panel panel_filtros;
        private System.Windows.Forms.Button btn_actualizar;
        private System.Windows.Forms.TextBox txt_filtro_apellido;
        private System.Windows.Forms.TextBox txt_filtro_nombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgv_socios;
        private System.Windows.Forms.Button btn_vencidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_nombre_socio;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_apellido_socio;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_nro;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_dni_socio;
    }
}