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
            this.panel_main = new System.Windows.Forms.Panel();
            this.lbl_gym = new System.Windows.Forms.Label();
            this.panel_titulo = new System.Windows.Forms.Panel();
            this.panel_cuota = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dgv_inscripciones = new System.Windows.Forms.DataGridView();
            this.col_nro_socio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_fecha_vto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_ultimo_pago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtp_fecha_inicio = new System.Windows.Forms.DateTimePicker();
            this.lbl_fecha_inicio = new System.Windows.Forms.Label();
            this.lbl_fecha_fin = new System.Windows.Forms.Label();
            this.dtp_fecha_vto = new System.Windows.Forms.DateTimePicker();
            this.btn_pagar_cuota = new System.Windows.Forms.Button();
            this.pic_restore = new System.Windows.Forms.PictureBox();
            this.pic_max = new System.Windows.Forms.PictureBox();
            this.pic_min = new System.Windows.Forms.PictureBox();
            this.pic_close = new System.Windows.Forms.PictureBox();
            this.btn_vencimientos_mes = new System.Windows.Forms.Button();
            this.btn_vencimientos_dia = new System.Windows.Forms.Button();
            this.btn_cuotas = new System.Windows.Forms.Button();
            this.btn_socios = new System.Windows.Forms.Button();
            this.pic_gym = new System.Windows.Forms.PictureBox();
            this.lbl_monto = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel_main.SuspendLayout();
            this.panel_titulo.SuspendLayout();
            this.panel_cuota.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_inscripciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_restore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_max)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_min)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_gym)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_main
            // 
            this.panel_main.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel_main.Controls.Add(this.btn_vencimientos_mes);
            this.panel_main.Controls.Add(this.btn_vencimientos_dia);
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
            // panel_titulo
            // 
            this.panel_titulo.BackColor = System.Drawing.SystemColors.Control;
            this.panel_titulo.Controls.Add(this.pic_restore);
            this.panel_titulo.Controls.Add(this.pic_max);
            this.panel_titulo.Controls.Add(this.pic_min);
            this.panel_titulo.Controls.Add(this.pic_close);
            this.panel_titulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_titulo.Location = new System.Drawing.Point(270, 0);
            this.panel_titulo.Name = "panel_titulo";
            this.panel_titulo.Size = new System.Drawing.Size(1010, 50);
            this.panel_titulo.TabIndex = 1;
            this.panel_titulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_titulo_MouseDown);
            // 
            // panel_cuota
            // 
            this.panel_cuota.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_cuota.BackColor = System.Drawing.SystemColors.Control;
            this.panel_cuota.Controls.Add(this.textBox1);
            this.panel_cuota.Controls.Add(this.lbl_monto);
            this.panel_cuota.Controls.Add(this.lbl_fecha_fin);
            this.panel_cuota.Controls.Add(this.dtp_fecha_vto);
            this.panel_cuota.Controls.Add(this.lbl_fecha_inicio);
            this.panel_cuota.Controls.Add(this.dtp_fecha_inicio);
            this.panel_cuota.Controls.Add(this.btn_pagar_cuota);
            this.panel_cuota.Controls.Add(this.dgv_inscripciones);
            this.panel_cuota.Location = new System.Drawing.Point(270, 50);
            this.panel_cuota.Name = "panel_cuota";
            this.panel_cuota.Size = new System.Drawing.Size(1010, 670);
            this.panel_cuota.TabIndex = 2;
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
            // dtp_fecha_inicio
            // 
            this.dtp_fecha_inicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_fecha_inicio.Location = new System.Drawing.Point(108, 558);
            this.dtp_fecha_inicio.Name = "dtp_fecha_inicio";
            this.dtp_fecha_inicio.Size = new System.Drawing.Size(99, 20);
            this.dtp_fecha_inicio.TabIndex = 6;
            // 
            // lbl_fecha_inicio
            // 
            this.lbl_fecha_inicio.AutoSize = true;
            this.lbl_fecha_inicio.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fecha_inicio.Location = new System.Drawing.Point(12, 558);
            this.lbl_fecha_inicio.Name = "lbl_fecha_inicio";
            this.lbl_fecha_inicio.Size = new System.Drawing.Size(90, 19);
            this.lbl_fecha_inicio.TabIndex = 7;
            this.lbl_fecha_inicio.Text = "Fecha Inicio:";
            // 
            // lbl_fecha_fin
            // 
            this.lbl_fecha_fin.AutoSize = true;
            this.lbl_fecha_fin.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fecha_fin.Location = new System.Drawing.Point(28, 604);
            this.lbl_fecha_fin.Name = "lbl_fecha_fin";
            this.lbl_fecha_fin.Size = new System.Drawing.Size(74, 19);
            this.lbl_fecha_fin.TabIndex = 9;
            this.lbl_fecha_fin.Text = "Fecha Fin:";
            // 
            // dtp_fecha_vto
            // 
            this.dtp_fecha_vto.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_fecha_vto.Location = new System.Drawing.Point(108, 604);
            this.dtp_fecha_vto.Name = "dtp_fecha_vto";
            this.dtp_fecha_vto.Size = new System.Drawing.Size(99, 20);
            this.dtp_fecha_vto.TabIndex = 8;
            // 
            // btn_pagar_cuota
            // 
            this.btn_pagar_cuota.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_pagar_cuota.FlatAppearance.BorderSize = 0;
            this.btn_pagar_cuota.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btn_pagar_cuota.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pagar_cuota.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pagar_cuota.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_pagar_cuota.Image = global::SportGym.Properties.Resources.icons8_get_cash_50px;
            this.btn_pagar_cuota.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_pagar_cuota.Location = new System.Drawing.Point(728, 560);
            this.btn_pagar_cuota.Name = "btn_pagar_cuota";
            this.btn_pagar_cuota.Size = new System.Drawing.Size(270, 64);
            this.btn_pagar_cuota.TabIndex = 5;
            this.btn_pagar_cuota.Text = "Nuevo pago";
            this.btn_pagar_cuota.UseVisualStyleBackColor = false;
            // 
            // pic_restore
            // 
            this.pic_restore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_restore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_restore.Image = global::SportGym.Properties.Resources.icons8_restore_down_32px;
            this.pic_restore.Location = new System.Drawing.Point(928, 12);
            this.pic_restore.Name = "pic_restore";
            this.pic_restore.Size = new System.Drawing.Size(32, 32);
            this.pic_restore.TabIndex = 0;
            this.pic_restore.TabStop = false;
            this.pic_restore.Visible = false;
            this.pic_restore.Click += new System.EventHandler(this.pic_restore_Click);
            // 
            // pic_max
            // 
            this.pic_max.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_max.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_max.Image = global::SportGym.Properties.Resources.icons8_maximize_button_32px;
            this.pic_max.Location = new System.Drawing.Point(928, 12);
            this.pic_max.Name = "pic_max";
            this.pic_max.Size = new System.Drawing.Size(32, 32);
            this.pic_max.TabIndex = 2;
            this.pic_max.TabStop = false;
            this.pic_max.Click += new System.EventHandler(this.pic_max_Click);
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
            // btn_vencimientos_mes
            // 
            this.btn_vencimientos_mes.FlatAppearance.BorderSize = 0;
            this.btn_vencimientos_mes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btn_vencimientos_mes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_vencimientos_mes.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_vencimientos_mes.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_vencimientos_mes.Image = global::SportGym.Properties.Resources.icons8_leave_52px;
            this.btn_vencimientos_mes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_vencimientos_mes.Location = new System.Drawing.Point(0, 365);
            this.btn_vencimientos_mes.Name = "btn_vencimientos_mes";
            this.btn_vencimientos_mes.Size = new System.Drawing.Size(270, 64);
            this.btn_vencimientos_mes.TabIndex = 3;
            this.btn_vencimientos_mes.Text = "          Vencimientos del mes";
            this.btn_vencimientos_mes.UseVisualStyleBackColor = true;
            // 
            // btn_vencimientos_dia
            // 
            this.btn_vencimientos_dia.FlatAppearance.BorderSize = 0;
            this.btn_vencimientos_dia.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btn_vencimientos_dia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_vencimientos_dia.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_vencimientos_dia.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_vencimientos_dia.Image = global::SportGym.Properties.Resources.icons8_error_52px;
            this.btn_vencimientos_dia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_vencimientos_dia.Location = new System.Drawing.Point(0, 295);
            this.btn_vencimientos_dia.Name = "btn_vencimientos_dia";
            this.btn_vencimientos_dia.Size = new System.Drawing.Size(270, 64);
            this.btn_vencimientos_dia.TabIndex = 2;
            this.btn_vencimientos_dia.Text = "         Vencimientos del dia";
            this.btn_vencimientos_dia.UseVisualStyleBackColor = true;
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
            // lbl_monto
            // 
            this.lbl_monto.AutoSize = true;
            this.lbl_monto.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_monto.Location = new System.Drawing.Point(283, 558);
            this.lbl_monto.Name = "lbl_monto";
            this.lbl_monto.Size = new System.Drawing.Size(55, 19);
            this.lbl_monto.TabIndex = 10;
            this.lbl_monto.Text = "Monto:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(335, 558);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 11;
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
            this.Name = "frm_principal";
            this.Text = " ";
            this.panel_main.ResumeLayout(false);
            this.panel_main.PerformLayout();
            this.panel_titulo.ResumeLayout(false);
            this.panel_cuota.ResumeLayout(false);
            this.panel_cuota.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_inscripciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_restore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_max)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_min)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_gym)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_main;
        private System.Windows.Forms.Panel panel_titulo;
        private System.Windows.Forms.Panel panel_cuota;
        private System.Windows.Forms.PictureBox pic_gym;
        private System.Windows.Forms.Label lbl_gym;
        private System.Windows.Forms.PictureBox pic_max;
        private System.Windows.Forms.PictureBox pic_min;
        private System.Windows.Forms.PictureBox pic_close;
        private System.Windows.Forms.PictureBox pic_restore;
        private System.Windows.Forms.Button btn_cuotas;
        private System.Windows.Forms.Button btn_socios;
        private System.Windows.Forms.Button btn_vencimientos_dia;
        private System.Windows.Forms.Button btn_vencimientos_mes;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridView dgv_inscripciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_nro_socio;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_fecha_vto;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ultimo_pago;
        private System.Windows.Forms.Button btn_pagar_cuota;
        private System.Windows.Forms.DateTimePicker dtp_fecha_inicio;
        private System.Windows.Forms.Label lbl_fecha_fin;
        private System.Windows.Forms.DateTimePicker dtp_fecha_vto;
        private System.Windows.Forms.Label lbl_fecha_inicio;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbl_monto;
    }
}