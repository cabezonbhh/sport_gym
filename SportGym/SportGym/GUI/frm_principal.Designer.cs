﻿namespace SportGym.GUI
{
    partial class frm_principal
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_principal));
            this.panel_main = new System.Windows.Forms.Panel();
            this.btn_estadisticas = new System.Windows.Forms.Button();
            this.btn_vencidos = new System.Windows.Forms.Button();
            this.btn_horarios = new System.Windows.Forms.Button();
            this.lbl_hora_chico = new System.Windows.Forms.Label();
            this.btn_salir = new System.Windows.Forms.Button();
            this.lbl_fecha = new System.Windows.Forms.Label();
            this.btn_historial_pago_socio = new System.Windows.Forms.Button();
            this.lbl_gym = new System.Windows.Forms.Label();
            this.btn_socios = new System.Windows.Forms.Button();
            this.pic_gym = new System.Windows.Forms.PictureBox();
            this.panel_titulo = new System.Windows.Forms.Panel();
            this.btn_refresh_socio = new System.Windows.Forms.Button();
            this.btn_covid = new System.Windows.Forms.Button();
            this.pic_restaurar = new System.Windows.Forms.PictureBox();
            this.pic_maximizar = new System.Windows.Forms.PictureBox();
            this.pic_min = new System.Windows.Forms.PictureBox();
            this.pic_close = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel_cuota = new System.Windows.Forms.Panel();
            this.panel_botones_cuota = new System.Windows.Forms.Panel();
            this.btn_pagar_cuota = new System.Windows.Forms.Button();
            this.txt_monto_pagar = new System.Windows.Forms.TextBox();
            this.lbl_monto = new System.Windows.Forms.Label();
            this.lbl_fecha_fin = new System.Windows.Forms.Label();
            this.dtp_fecha_vto = new System.Windows.Forms.DateTimePicker();
            this.lbl_fecha_inicio = new System.Windows.Forms.Label();
            this.dtp_fecha_inicio = new System.Windows.Forms.DateTimePicker();
            this.dgv_inscripciones = new System.Windows.Forms.DataGridView();
            this.col_nro_socio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_fecha_vto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_ultimo_pago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_gym)).BeginInit();
            this.panel_titulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_restaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_maximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_min)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_close)).BeginInit();
            this.panel_cuota.SuspendLayout();
            this.panel_botones_cuota.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_inscripciones)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_main
            // 
            this.panel_main.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel_main.Controls.Add(this.btn_estadisticas);
            this.panel_main.Controls.Add(this.btn_vencidos);
            this.panel_main.Controls.Add(this.btn_horarios);
            this.panel_main.Controls.Add(this.lbl_hora_chico);
            this.panel_main.Controls.Add(this.btn_salir);
            this.panel_main.Controls.Add(this.lbl_fecha);
            this.panel_main.Controls.Add(this.btn_historial_pago_socio);
            this.panel_main.Controls.Add(this.lbl_gym);
            this.panel_main.Controls.Add(this.btn_socios);
            this.panel_main.Controls.Add(this.pic_gym);
            this.panel_main.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_main.Location = new System.Drawing.Point(0, 0);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(260, 580);
            this.panel_main.TabIndex = 0;
            // 
            // btn_estadisticas
            // 
            this.btn_estadisticas.Enabled = false;
            this.btn_estadisticas.FlatAppearance.BorderSize = 0;
            this.btn_estadisticas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btn_estadisticas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_estadisticas.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_estadisticas.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_estadisticas.Image = global::SportGym.Properties.Resources.icons8_statistics_52px;
            this.btn_estadisticas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_estadisticas.Location = new System.Drawing.Point(0, 435);
            this.btn_estadisticas.Name = "btn_estadisticas";
            this.btn_estadisticas.Size = new System.Drawing.Size(270, 64);
            this.btn_estadisticas.TabIndex = 8;
            this.btn_estadisticas.Text = "     Estadisticas";
            this.btn_estadisticas.UseVisualStyleBackColor = true;
            this.btn_estadisticas.Click += new System.EventHandler(this.btn_estadisticas_Click);
            // 
            // btn_vencidos
            // 
            this.btn_vencidos.Enabled = false;
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
            this.btn_vencidos.TabIndex = 7;
            this.btn_vencidos.Text = "     Vencidos";
            this.btn_vencidos.UseVisualStyleBackColor = true;
            this.btn_vencidos.Click += new System.EventHandler(this.btn_vencidos_Click);
            // 
            // btn_horarios
            // 
            this.btn_horarios.Enabled = false;
            this.btn_horarios.FlatAppearance.BorderSize = 0;
            this.btn_horarios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btn_horarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_horarios.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_horarios.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_horarios.Image = global::SportGym.Properties.Resources.icons8_clock_52px;
            this.btn_horarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_horarios.Location = new System.Drawing.Point(0, 295);
            this.btn_horarios.Name = "btn_horarios";
            this.btn_horarios.Size = new System.Drawing.Size(270, 64);
            this.btn_horarios.TabIndex = 6;
            this.btn_horarios.Text = "     Horarios";
            this.btn_horarios.UseVisualStyleBackColor = true;
            this.btn_horarios.Click += new System.EventHandler(this.btn_horarios_Click);
            // 
            // lbl_hora_chico
            // 
            this.lbl_hora_chico.AutoSize = true;
            this.lbl_hora_chico.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hora_chico.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_hora_chico.Location = new System.Drawing.Point(12, 115);
            this.lbl_hora_chico.Name = "lbl_hora_chico";
            this.lbl_hora_chico.Size = new System.Drawing.Size(65, 29);
            this.lbl_hora_chico.TabIndex = 4;
            this.lbl_hora_chico.Text = "hora";
            // 
            // btn_salir
            // 
            this.btn_salir.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_salir.FlatAppearance.BorderSize = 0;
            this.btn_salir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btn_salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_salir.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salir.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_salir.Image = global::SportGym.Properties.Resources.icons8_exit_sign_52px;
            this.btn_salir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_salir.Location = new System.Drawing.Point(0, 516);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(260, 64);
            this.btn_salir.TabIndex = 3;
            this.btn_salir.Text = "     Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // lbl_fecha
            // 
            this.lbl_fecha.AutoSize = true;
            this.lbl_fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fecha.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_fecha.Location = new System.Drawing.Point(118, 83);
            this.lbl_fecha.Name = "lbl_fecha";
            this.lbl_fecha.Size = new System.Drawing.Size(76, 29);
            this.lbl_fecha.TabIndex = 5;
            this.lbl_fecha.Text = "fecha";
            // 
            // btn_historial_pago_socio
            // 
            this.btn_historial_pago_socio.Enabled = false;
            this.btn_historial_pago_socio.FlatAppearance.BorderSize = 0;
            this.btn_historial_pago_socio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btn_historial_pago_socio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_historial_pago_socio.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_historial_pago_socio.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_historial_pago_socio.Image = global::SportGym.Properties.Resources.icons8_general_ledger_52px;
            this.btn_historial_pago_socio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_historial_pago_socio.Location = new System.Drawing.Point(0, 225);
            this.btn_historial_pago_socio.Name = "btn_historial_pago_socio";
            this.btn_historial_pago_socio.Size = new System.Drawing.Size(270, 64);
            this.btn_historial_pago_socio.TabIndex = 2;
            this.btn_historial_pago_socio.Text = "     Historial de pagos";
            this.btn_historial_pago_socio.UseVisualStyleBackColor = true;
            this.btn_historial_pago_socio.Click += new System.EventHandler(this.btn_historial_pago_socio_Click);
            // 
            // lbl_gym
            // 
            this.lbl_gym.AutoSize = true;
            this.lbl_gym.Font = new System.Drawing.Font("ROG Fonts v1.6", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_gym.ForeColor = System.Drawing.Color.White;
            this.lbl_gym.Location = new System.Drawing.Point(118, 12);
            this.lbl_gym.Name = "lbl_gym";
            this.lbl_gym.Size = new System.Drawing.Size(138, 29);
            this.lbl_gym.TabIndex = 0;
            this.lbl_gym.Text = "Sport Gym";
            // 
            // btn_socios
            // 
            this.btn_socios.FlatAppearance.BorderSize = 0;
            this.btn_socios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btn_socios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_socios.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_socios.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_socios.Image = global::SportGym.Properties.Resources.icons8_treadmill_52px;
            this.btn_socios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_socios.Location = new System.Drawing.Point(0, 155);
            this.btn_socios.Name = "btn_socios";
            this.btn_socios.Size = new System.Drawing.Size(270, 64);
            this.btn_socios.TabIndex = 0;
            this.btn_socios.Text = "    Socios";
            this.btn_socios.UseVisualStyleBackColor = true;
            this.btn_socios.Click += new System.EventHandler(this.btn_socios_Click);
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
            // panel_titulo
            // 
            this.panel_titulo.AutoSize = true;
            this.panel_titulo.BackColor = System.Drawing.SystemColors.Control;
            this.panel_titulo.Controls.Add(this.btn_refresh_socio);
            this.panel_titulo.Controls.Add(this.btn_covid);
            this.panel_titulo.Controls.Add(this.pic_restaurar);
            this.panel_titulo.Controls.Add(this.pic_maximizar);
            this.panel_titulo.Controls.Add(this.pic_min);
            this.panel_titulo.Controls.Add(this.pic_close);
            this.panel_titulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_titulo.Location = new System.Drawing.Point(260, 0);
            this.panel_titulo.Name = "panel_titulo";
            this.panel_titulo.Size = new System.Drawing.Size(730, 47);
            this.panel_titulo.TabIndex = 1;
            this.panel_titulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_titulo_MouseDown);
            // 
            // btn_refresh_socio
            // 
            this.btn_refresh_socio.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_refresh_socio.FlatAppearance.BorderSize = 0;
            this.btn_refresh_socio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btn_refresh_socio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_refresh_socio.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_refresh_socio.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_refresh_socio.Image = global::SportGym.Properties.Resources.icons8_restart_26px;
            this.btn_refresh_socio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_refresh_socio.Location = new System.Drawing.Point(59, 6);
            this.btn_refresh_socio.Name = "btn_refresh_socio";
            this.btn_refresh_socio.Size = new System.Drawing.Size(36, 38);
            this.btn_refresh_socio.TabIndex = 21;
            this.btn_refresh_socio.UseVisualStyleBackColor = false;
            this.btn_refresh_socio.Click += new System.EventHandler(this.btn_refresh_socio_Click);
            // 
            // btn_covid
            // 
            this.btn_covid.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_covid.Enabled = false;
            this.btn_covid.FlatAppearance.BorderSize = 0;
            this.btn_covid.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btn_covid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_covid.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_covid.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_covid.Image = global::SportGym.Properties.Resources.icons8_coronavirus_26px;
            this.btn_covid.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_covid.Location = new System.Drawing.Point(15, 6);
            this.btn_covid.Name = "btn_covid";
            this.btn_covid.Size = new System.Drawing.Size(38, 38);
            this.btn_covid.TabIndex = 20;
            this.btn_covid.UseVisualStyleBackColor = false;
            this.btn_covid.Click += new System.EventHandler(this.btn_covid_Click);
            // 
            // pic_restaurar
            // 
            this.pic_restaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_restaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_restaurar.Image = global::SportGym.Properties.Resources.icons8_restore_down_32px;
            this.pic_restaurar.Location = new System.Drawing.Point(642, 12);
            this.pic_restaurar.Name = "pic_restaurar";
            this.pic_restaurar.Size = new System.Drawing.Size(32, 32);
            this.pic_restaurar.TabIndex = 3;
            this.pic_restaurar.TabStop = false;
            this.pic_restaurar.Visible = false;
            this.pic_restaurar.Click += new System.EventHandler(this.pic_restaurar_Click);
            // 
            // pic_maximizar
            // 
            this.pic_maximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_maximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_maximizar.Image = global::SportGym.Properties.Resources.icons8_maximize_button_32px;
            this.pic_maximizar.Location = new System.Drawing.Point(642, 12);
            this.pic_maximizar.Name = "pic_maximizar";
            this.pic_maximizar.Size = new System.Drawing.Size(32, 32);
            this.pic_maximizar.TabIndex = 2;
            this.pic_maximizar.TabStop = false;
            this.pic_maximizar.Click += new System.EventHandler(this.pic_maximizar_Click);
            // 
            // pic_min
            // 
            this.pic_min.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_min.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_min.Image = global::SportGym.Properties.Resources.icons8_minimize_window_32px;
            this.pic_min.Location = new System.Drawing.Point(604, 12);
            this.pic_min.Name = "pic_min";
            this.pic_min.Size = new System.Drawing.Size(32, 32);
            this.pic_min.TabIndex = 1;
            this.pic_min.TabStop = false;
            this.pic_min.Click += new System.EventHandler(this.pic_min_Click);
            // 
            // pic_close
            // 
            this.pic_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_close.Image = global::SportGym.Properties.Resources.icons8_delete_32px;
            this.pic_close.Location = new System.Drawing.Point(680, 12);
            this.pic_close.Name = "pic_close";
            this.pic_close.Size = new System.Drawing.Size(32, 32);
            this.pic_close.TabIndex = 0;
            this.pic_close.TabStop = false;
            this.pic_close.Click += new System.EventHandler(this.pic_close_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel_cuota
            // 
            this.panel_cuota.AutoSize = true;
            this.panel_cuota.BackColor = System.Drawing.SystemColors.Control;
            this.panel_cuota.Controls.Add(this.panel_botones_cuota);
            this.panel_cuota.Controls.Add(this.dgv_inscripciones);
            this.panel_cuota.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_cuota.Location = new System.Drawing.Point(260, 47);
            this.panel_cuota.Name = "panel_cuota";
            this.panel_cuota.Size = new System.Drawing.Size(730, 533);
            this.panel_cuota.TabIndex = 2;
            // 
            // panel_botones_cuota
            // 
            this.panel_botones_cuota.Controls.Add(this.btn_pagar_cuota);
            this.panel_botones_cuota.Controls.Add(this.txt_monto_pagar);
            this.panel_botones_cuota.Controls.Add(this.lbl_monto);
            this.panel_botones_cuota.Controls.Add(this.lbl_fecha_fin);
            this.panel_botones_cuota.Controls.Add(this.dtp_fecha_vto);
            this.panel_botones_cuota.Controls.Add(this.lbl_fecha_inicio);
            this.panel_botones_cuota.Controls.Add(this.dtp_fecha_inicio);
            this.panel_botones_cuota.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_botones_cuota.Location = new System.Drawing.Point(0, 478);
            this.panel_botones_cuota.Name = "panel_botones_cuota";
            this.panel_botones_cuota.Size = new System.Drawing.Size(730, 55);
            this.panel_botones_cuota.TabIndex = 5;
            // 
            // btn_pagar_cuota
            // 
            this.btn_pagar_cuota.Location = new System.Drawing.Point(637, 4);
            this.btn_pagar_cuota.Name = "btn_pagar_cuota";
            this.btn_pagar_cuota.Size = new System.Drawing.Size(75, 43);
            this.btn_pagar_cuota.TabIndex = 19;
            this.btn_pagar_cuota.Text = "Registrar cobro";
            this.btn_pagar_cuota.UseVisualStyleBackColor = true;
            this.btn_pagar_cuota.Click += new System.EventHandler(this.btn_pagar_cuota_Click);
            // 
            // txt_monto_pagar
            // 
            this.txt_monto_pagar.Enabled = false;
            this.txt_monto_pagar.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_monto_pagar.Location = new System.Drawing.Point(515, 13);
            this.txt_monto_pagar.MaxLength = 10;
            this.txt_monto_pagar.Name = "txt_monto_pagar";
            this.txt_monto_pagar.Size = new System.Drawing.Size(100, 26);
            this.txt_monto_pagar.TabIndex = 18;
            this.txt_monto_pagar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_monto_pagar_KeyPress);
            // 
            // lbl_monto
            // 
            this.lbl_monto.AutoSize = true;
            this.lbl_monto.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_monto.Location = new System.Drawing.Point(455, 16);
            this.lbl_monto.Name = "lbl_monto";
            this.lbl_monto.Size = new System.Drawing.Size(54, 18);
            this.lbl_monto.TabIndex = 17;
            this.lbl_monto.Text = "Monto:";
            // 
            // lbl_fecha_fin
            // 
            this.lbl_fecha_fin.AutoSize = true;
            this.lbl_fecha_fin.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fecha_fin.Location = new System.Drawing.Point(236, 16);
            this.lbl_fecha_fin.Name = "lbl_fecha_fin";
            this.lbl_fecha_fin.Size = new System.Drawing.Size(70, 18);
            this.lbl_fecha_fin.TabIndex = 16;
            this.lbl_fecha_fin.Text = "Fecha Fin:";
            // 
            // dtp_fecha_vto
            // 
            this.dtp_fecha_vto.Enabled = false;
            this.dtp_fecha_vto.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_fecha_vto.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_fecha_vto.Location = new System.Drawing.Point(312, 13);
            this.dtp_fecha_vto.Name = "dtp_fecha_vto";
            this.dtp_fecha_vto.Size = new System.Drawing.Size(132, 26);
            this.dtp_fecha_vto.TabIndex = 15;
            // 
            // lbl_fecha_inicio
            // 
            this.lbl_fecha_inicio.AutoSize = true;
            this.lbl_fecha_inicio.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fecha_inicio.Location = new System.Drawing.Point(6, 16);
            this.lbl_fecha_inicio.Name = "lbl_fecha_inicio";
            this.lbl_fecha_inicio.Size = new System.Drawing.Size(85, 18);
            this.lbl_fecha_inicio.TabIndex = 14;
            this.lbl_fecha_inicio.Text = "Fecha Inicio:";
            // 
            // dtp_fecha_inicio
            // 
            this.dtp_fecha_inicio.CalendarFont = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_fecha_inicio.Enabled = false;
            this.dtp_fecha_inicio.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_fecha_inicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_fecha_inicio.Location = new System.Drawing.Point(94, 13);
            this.dtp_fecha_inicio.Name = "dtp_fecha_inicio";
            this.dtp_fecha_inicio.Size = new System.Drawing.Size(132, 26);
            this.dtp_fecha_inicio.TabIndex = 13;
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
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.col_fecha_vto,
            this.col_estado,
            this.col_ultimo_pago});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_inscripciones.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_inscripciones.Location = new System.Drawing.Point(6, 6);
            this.dgv_inscripciones.MultiSelect = false;
            this.dgv_inscripciones.Name = "dgv_inscripciones";
            this.dgv_inscripciones.ReadOnly = true;
            this.dgv_inscripciones.RowHeadersVisible = false;
            this.dgv_inscripciones.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgv_inscripciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_inscripciones.Size = new System.Drawing.Size(714, 466);
            this.dgv_inscripciones.TabIndex = 4;
            this.dgv_inscripciones.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgv_inscripciones_CellFormatting_1);
            this.dgv_inscripciones.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_inscripciones_CellMouseClick);
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
            // col_fecha_vto
            // 
            this.col_fecha_vto.HeaderText = "Fecha vto";
            this.col_fecha_vto.MinimumWidth = 10;
            this.col_fecha_vto.Name = "col_fecha_vto";
            this.col_fecha_vto.ReadOnly = true;
            // 
            // col_estado
            // 
            this.col_estado.HeaderText = "Estado";
            this.col_estado.MinimumWidth = 10;
            this.col_estado.Name = "col_estado";
            this.col_estado.ReadOnly = true;
            // 
            // col_ultimo_pago
            // 
            this.col_ultimo_pago.HeaderText = "Ultimo pago";
            this.col_ultimo_pago.MinimumWidth = 10;
            this.col_ultimo_pago.Name = "col_ultimo_pago";
            this.col_ultimo_pago.ReadOnly = true;
            // 
            // frm_principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(990, 580);
            this.Controls.Add(this.panel_cuota);
            this.Controls.Add(this.panel_titulo);
            this.Controls.Add(this.panel_main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.frm_principal_Load);
            this.panel_main.ResumeLayout(false);
            this.panel_main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_gym)).EndInit();
            this.panel_titulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_restaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_maximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_min)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_close)).EndInit();
            this.panel_cuota.ResumeLayout(false);
            this.panel_botones_cuota.ResumeLayout(false);
            this.panel_botones_cuota.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_inscripciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_main;
        private System.Windows.Forms.Panel panel_titulo;
        private System.Windows.Forms.PictureBox pic_gym;
        private System.Windows.Forms.Label lbl_gym;
        private System.Windows.Forms.PictureBox pic_min;
        private System.Windows.Forms.PictureBox pic_close;
        private System.Windows.Forms.Button btn_socios;
        private System.Windows.Forms.PictureBox pic_restaurar;
        private System.Windows.Forms.PictureBox pic_maximizar;
        private System.Windows.Forms.Button btn_historial_pago_socio;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Label lbl_hora_chico;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbl_fecha;
        private System.Windows.Forms.Button btn_horarios;
        private System.Windows.Forms.Button btn_covid;
        private System.Windows.Forms.Button btn_vencidos;
        private System.Windows.Forms.Button btn_estadisticas;
        private System.Windows.Forms.Button btn_refresh_socio;
        private System.Windows.Forms.Panel panel_cuota;
        private System.Windows.Forms.Panel panel_botones_cuota;
        private System.Windows.Forms.TextBox txt_monto_pagar;
        private System.Windows.Forms.Label lbl_monto;
        private System.Windows.Forms.Label lbl_fecha_fin;
        private System.Windows.Forms.DateTimePicker dtp_fecha_vto;
        private System.Windows.Forms.Label lbl_fecha_inicio;
        private System.Windows.Forms.DateTimePicker dtp_fecha_inicio;
        private System.Windows.Forms.DataGridView dgv_inscripciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_nro_socio;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_fecha_vto;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ultimo_pago;
        private System.Windows.Forms.Button btn_pagar_cuota;
    }
}