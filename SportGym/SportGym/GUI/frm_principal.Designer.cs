namespace SportGym.GUI
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
            this.btn_cuotas = new System.Windows.Forms.Button();
            this.lbl_gym = new System.Windows.Forms.Label();
            this.btn_socios = new System.Windows.Forms.Button();
            this.pic_gym = new System.Windows.Forms.PictureBox();
            this.panel_titulo = new System.Windows.Forms.Panel();
            this.pic_restaurar = new System.Windows.Forms.PictureBox();
            this.pic_maximizar = new System.Windows.Forms.PictureBox();
            this.pic_min = new System.Windows.Forms.PictureBox();
            this.pic_close = new System.Windows.Forms.PictureBox();
            this.panel_cuota = new System.Windows.Forms.Panel();
            this.panel_botones_cuota = new System.Windows.Forms.Panel();
            this.lbl_monto = new System.Windows.Forms.Label();
            this.lbl_fecha_fin = new System.Windows.Forms.Label();
            this.dtp_fecha_vto = new System.Windows.Forms.DateTimePicker();
            this.lbl_fecha_inicio = new System.Windows.Forms.Label();
            this.dtp_fecha_inicio = new System.Windows.Forms.DateTimePicker();
            this.btn_pagar_cuota = new System.Windows.Forms.Button();
            this.dgv_inscripciones = new System.Windows.Forms.DataGridView();
            this.col_nro_socio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_fecha_vto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_ultimo_pago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txt_monto_pagar = new System.Windows.Forms.TextBox();
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
            this.panel_main.Controls.Add(this.btn_cuotas);
            this.panel_main.Controls.Add(this.lbl_gym);
            this.panel_main.Controls.Add(this.btn_socios);
            this.panel_main.Controls.Add(this.pic_gym);
            this.panel_main.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_main.Location = new System.Drawing.Point(0, 0);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(270, 720);
            this.panel_main.TabIndex = 0;
            // 
            // btn_cuotas
            // 
            this.btn_cuotas.FlatAppearance.BorderSize = 0;
            this.btn_cuotas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btn_cuotas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cuotas.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cuotas.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_cuotas.Image = global::SportGym.Properties.Resources.icons8_average_2_52px;
            this.btn_cuotas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cuotas.Location = new System.Drawing.Point(0, 225);
            this.btn_cuotas.Name = "btn_cuotas";
            this.btn_cuotas.Size = new System.Drawing.Size(270, 64);
            this.btn_cuotas.TabIndex = 1;
            this.btn_cuotas.Text = "     Ultimos pagos";
            this.btn_cuotas.UseVisualStyleBackColor = true;
            this.btn_cuotas.Click += new System.EventHandler(this.btn_cuotas_Click);
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
            this.panel_titulo.BackColor = System.Drawing.SystemColors.Control;
            this.panel_titulo.Controls.Add(this.pic_restaurar);
            this.panel_titulo.Controls.Add(this.pic_maximizar);
            this.panel_titulo.Controls.Add(this.pic_min);
            this.panel_titulo.Controls.Add(this.pic_close);
            this.panel_titulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_titulo.Location = new System.Drawing.Point(270, 0);
            this.panel_titulo.Name = "panel_titulo";
            this.panel_titulo.Size = new System.Drawing.Size(1010, 50);
            this.panel_titulo.TabIndex = 1;
            this.panel_titulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_titulo_MouseDown);
            // 
            // pic_restaurar
            // 
            this.pic_restaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_restaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_restaurar.Image = global::SportGym.Properties.Resources.icons8_restore_down_32px;
            this.pic_restaurar.Location = new System.Drawing.Point(928, 12);
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
            this.pic_maximizar.Location = new System.Drawing.Point(928, 12);
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
            this.pic_min.Location = new System.Drawing.Point(890, 12);
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
            this.pic_close.Location = new System.Drawing.Point(966, 12);
            this.pic_close.Name = "pic_close";
            this.pic_close.Size = new System.Drawing.Size(32, 32);
            this.pic_close.TabIndex = 0;
            this.pic_close.TabStop = false;
            this.pic_close.Click += new System.EventHandler(this.pic_close_Click);
            // 
            // panel_cuota
            // 
            this.panel_cuota.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_cuota.BackColor = System.Drawing.SystemColors.Control;
            this.panel_cuota.Controls.Add(this.panel_botones_cuota);
            this.panel_cuota.Controls.Add(this.dgv_inscripciones);
            this.panel_cuota.Location = new System.Drawing.Point(270, 50);
            this.panel_cuota.Name = "panel_cuota";
            this.panel_cuota.Size = new System.Drawing.Size(1010, 670);
            this.panel_cuota.TabIndex = 2;
            // 
            // panel_botones_cuota
            // 
            this.panel_botones_cuota.Controls.Add(this.txt_monto_pagar);
            this.panel_botones_cuota.Controls.Add(this.lbl_monto);
            this.panel_botones_cuota.Controls.Add(this.lbl_fecha_fin);
            this.panel_botones_cuota.Controls.Add(this.dtp_fecha_vto);
            this.panel_botones_cuota.Controls.Add(this.lbl_fecha_inicio);
            this.panel_botones_cuota.Controls.Add(this.dtp_fecha_inicio);
            this.panel_botones_cuota.Controls.Add(this.btn_pagar_cuota);
            this.panel_botones_cuota.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_botones_cuota.Location = new System.Drawing.Point(0, 534);
            this.panel_botones_cuota.Name = "panel_botones_cuota";
            this.panel_botones_cuota.Size = new System.Drawing.Size(1010, 136);
            this.panel_botones_cuota.TabIndex = 5;
            // 
            // lbl_monto
            // 
            this.lbl_monto.AutoSize = true;
            this.lbl_monto.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_monto.Location = new System.Drawing.Point(272, 76);
            this.lbl_monto.Name = "lbl_monto";
            this.lbl_monto.Size = new System.Drawing.Size(55, 19);
            this.lbl_monto.TabIndex = 17;
            this.lbl_monto.Text = "Monto:";
            // 
            // lbl_fecha_fin
            // 
            this.lbl_fecha_fin.AutoSize = true;
            this.lbl_fecha_fin.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fecha_fin.Location = new System.Drawing.Point(28, 76);
            this.lbl_fecha_fin.Name = "lbl_fecha_fin";
            this.lbl_fecha_fin.Size = new System.Drawing.Size(74, 19);
            this.lbl_fecha_fin.TabIndex = 16;
            this.lbl_fecha_fin.Text = "Fecha Fin:";
            // 
            // dtp_fecha_vto
            // 
            this.dtp_fecha_vto.Enabled = false;
            this.dtp_fecha_vto.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_fecha_vto.Location = new System.Drawing.Point(108, 76);
            this.dtp_fecha_vto.Name = "dtp_fecha_vto";
            this.dtp_fecha_vto.Size = new System.Drawing.Size(99, 20);
            this.dtp_fecha_vto.TabIndex = 15;
            // 
            // lbl_fecha_inicio
            // 
            this.lbl_fecha_inicio.AutoSize = true;
            this.lbl_fecha_inicio.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fecha_inicio.Location = new System.Drawing.Point(12, 36);
            this.lbl_fecha_inicio.Name = "lbl_fecha_inicio";
            this.lbl_fecha_inicio.Size = new System.Drawing.Size(90, 19);
            this.lbl_fecha_inicio.TabIndex = 14;
            this.lbl_fecha_inicio.Text = "Fecha Inicio:";
            // 
            // dtp_fecha_inicio
            // 
            this.dtp_fecha_inicio.Enabled = false;
            this.dtp_fecha_inicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_fecha_inicio.Location = new System.Drawing.Point(108, 36);
            this.dtp_fecha_inicio.Name = "dtp_fecha_inicio";
            this.dtp_fecha_inicio.Size = new System.Drawing.Size(99, 20);
            this.dtp_fecha_inicio.TabIndex = 13;
            // 
            // btn_pagar_cuota
            // 
            this.btn_pagar_cuota.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_pagar_cuota.Enabled = false;
            this.btn_pagar_cuota.FlatAppearance.BorderSize = 0;
            this.btn_pagar_cuota.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btn_pagar_cuota.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pagar_cuota.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pagar_cuota.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_pagar_cuota.Image = global::SportGym.Properties.Resources.icons8_get_cash_50px;
            this.btn_pagar_cuota.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_pagar_cuota.Location = new System.Drawing.Point(722, 36);
            this.btn_pagar_cuota.Name = "btn_pagar_cuota";
            this.btn_pagar_cuota.Size = new System.Drawing.Size(270, 64);
            this.btn_pagar_cuota.TabIndex = 12;
            this.btn_pagar_cuota.Text = "Nuevo pago";
            this.btn_pagar_cuota.UseVisualStyleBackColor = false;
            this.btn_pagar_cuota.Click += new System.EventHandler(this.btn_pagar_cuota_Click);
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
            this.col_fecha_vto,
            this.col_estado,
            this.col_ultimo_pago});
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
            this.dgv_inscripciones.Size = new System.Drawing.Size(983, 533);
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
            // txt_monto_pagar
            // 
            this.txt_monto_pagar.Enabled = false;
            this.txt_monto_pagar.Location = new System.Drawing.Point(333, 77);
            this.txt_monto_pagar.Name = "txt_monto_pagar";
            this.txt_monto_pagar.Size = new System.Drawing.Size(100, 20);
            this.txt_monto_pagar.TabIndex = 18;
            // 
            // frm_principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.panel_cuota);
            this.Controls.Add(this.panel_titulo);
            this.Controls.Add(this.panel_main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_principal";
            this.Text = " ";
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

        }

        #endregion

        private System.Windows.Forms.Panel panel_main;
        private System.Windows.Forms.Panel panel_titulo;
        private System.Windows.Forms.Panel panel_cuota;
        private System.Windows.Forms.PictureBox pic_gym;
        private System.Windows.Forms.Label lbl_gym;
        private System.Windows.Forms.PictureBox pic_min;
        private System.Windows.Forms.PictureBox pic_close;
        private System.Windows.Forms.Button btn_cuotas;
        private System.Windows.Forms.Button btn_socios;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridView dgv_inscripciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_nro_socio;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_fecha_vto;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ultimo_pago;
        private System.Windows.Forms.PictureBox pic_restaurar;
        private System.Windows.Forms.PictureBox pic_maximizar;
        private System.Windows.Forms.Panel panel_botones_cuota;
        private System.Windows.Forms.Label lbl_monto;
        private System.Windows.Forms.Label lbl_fecha_fin;
        private System.Windows.Forms.DateTimePicker dtp_fecha_vto;
        private System.Windows.Forms.Label lbl_fecha_inicio;
        private System.Windows.Forms.DateTimePicker dtp_fecha_inicio;
        private System.Windows.Forms.Button btn_pagar_cuota;
        private System.Windows.Forms.TextBox txt_monto_pagar;
    }
}