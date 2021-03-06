﻿namespace SportGym.GUI
{
    partial class frm_horarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_horarios));
            this.panel_hora_filtro = new System.Windows.Forms.Panel();
            this.lbl_cantidad_resultado = new System.Windows.Forms.Label();
            this.lbl_cantidad = new System.Windows.Forms.Label();
            this.combo_fin = new System.Windows.Forms.ComboBox();
            this.combo_inicio = new System.Windows.Forms.ComboBox();
            this.lbl_hora_fin = new System.Windows.Forms.Label();
            this.btn_filtrar = new System.Windows.Forms.Button();
            this.lbl_hora_inicio = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgv_horarios = new System.Windows.Forms.DataGridView();
            this.col_orden = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_nombre_socio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_apellido_socio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_horario_inicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_horario_fin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_socio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel_hora_filtro.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_horarios)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_hora_filtro
            // 
            this.panel_hora_filtro.Controls.Add(this.lbl_cantidad_resultado);
            this.panel_hora_filtro.Controls.Add(this.lbl_cantidad);
            this.panel_hora_filtro.Controls.Add(this.combo_fin);
            this.panel_hora_filtro.Controls.Add(this.combo_inicio);
            this.panel_hora_filtro.Controls.Add(this.lbl_hora_fin);
            this.panel_hora_filtro.Controls.Add(this.btn_filtrar);
            this.panel_hora_filtro.Controls.Add(this.lbl_hora_inicio);
            this.panel_hora_filtro.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_hora_filtro.Location = new System.Drawing.Point(0, 374);
            this.panel_hora_filtro.Name = "panel_hora_filtro";
            this.panel_hora_filtro.Size = new System.Drawing.Size(714, 86);
            this.panel_hora_filtro.TabIndex = 6;
            // 
            // lbl_cantidad_resultado
            // 
            this.lbl_cantidad_resultado.AutoSize = true;
            this.lbl_cantidad_resultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cantidad_resultado.Location = new System.Drawing.Point(255, 19);
            this.lbl_cantidad_resultado.Name = "lbl_cantidad_resultado";
            this.lbl_cantidad_resultado.Size = new System.Drawing.Size(68, 16);
            this.lbl_cantidad_resultado.TabIndex = 7;
            this.lbl_cantidad_resultado.Text = "cantidad";
            // 
            // lbl_cantidad
            // 
            this.lbl_cantidad.AutoSize = true;
            this.lbl_cantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cantidad.Location = new System.Drawing.Point(12, 19);
            this.lbl_cantidad.Name = "lbl_cantidad";
            this.lbl_cantidad.Size = new System.Drawing.Size(237, 16);
            this.lbl_cantidad.TabIndex = 6;
            this.lbl_cantidad.Text = "Cantidad de lugares disponibles:";
            // 
            // combo_fin
            // 
            this.combo_fin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_fin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_fin.FormattingEnabled = true;
            this.combo_fin.Location = new System.Drawing.Point(367, 56);
            this.combo_fin.Name = "combo_fin";
            this.combo_fin.Size = new System.Drawing.Size(121, 24);
            this.combo_fin.TabIndex = 5;
            // 
            // combo_inicio
            // 
            this.combo_inicio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_inicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_inicio.FormattingEnabled = true;
            this.combo_inicio.Location = new System.Drawing.Point(106, 56);
            this.combo_inicio.Name = "combo_inicio";
            this.combo_inicio.Size = new System.Drawing.Size(121, 24);
            this.combo_inicio.TabIndex = 4;
            this.combo_inicio.SelectedIndexChanged += new System.EventHandler(this.combo_inicio_SelectedIndexChanged);
            // 
            // lbl_hora_fin
            // 
            this.lbl_hora_fin.AutoSize = true;
            this.lbl_hora_fin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hora_fin.Location = new System.Drawing.Point(290, 59);
            this.lbl_hora_fin.Name = "lbl_hora_fin";
            this.lbl_hora_fin.Size = new System.Drawing.Size(71, 16);
            this.lbl_hora_fin.TabIndex = 3;
            this.lbl_hora_fin.Text = "Hora Fin:";
            // 
            // btn_filtrar
            // 
            this.btn_filtrar.Location = new System.Drawing.Point(627, 19);
            this.btn_filtrar.Name = "btn_filtrar";
            this.btn_filtrar.Size = new System.Drawing.Size(75, 54);
            this.btn_filtrar.TabIndex = 2;
            this.btn_filtrar.Text = "Listar";
            this.btn_filtrar.UseVisualStyleBackColor = true;
            this.btn_filtrar.Click += new System.EventHandler(this.btn_filtrar_Click);
            // 
            // lbl_hora_inicio
            // 
            this.lbl_hora_inicio.AutoSize = true;
            this.lbl_hora_inicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hora_inicio.Location = new System.Drawing.Point(13, 59);
            this.lbl_hora_inicio.Name = "lbl_hora_inicio";
            this.lbl_hora_inicio.Size = new System.Drawing.Size(87, 16);
            this.lbl_hora_inicio.TabIndex = 0;
            this.lbl_hora_inicio.Text = "Hora Inicio:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgv_horarios);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(714, 374);
            this.panel1.TabIndex = 7;
            // 
            // dgv_horarios
            // 
            this.dgv_horarios.AllowUserToAddRows = false;
            this.dgv_horarios.AllowUserToDeleteRows = false;
            this.dgv_horarios.AllowUserToOrderColumns = true;
            this.dgv_horarios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_horarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_horarios.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_horarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_horarios.ColumnHeadersHeight = 30;
            this.dgv_horarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_orden,
            this.col_nombre_socio,
            this.col_apellido_socio,
            this.col_horario_inicio,
            this.col_horario_fin,
            this.col_socio});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_horarios.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_horarios.Location = new System.Drawing.Point(6, 12);
            this.dgv_horarios.MultiSelect = false;
            this.dgv_horarios.Name = "dgv_horarios";
            this.dgv_horarios.ReadOnly = true;
            this.dgv_horarios.RowHeadersVisible = false;
            this.dgv_horarios.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgv_horarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_horarios.Size = new System.Drawing.Size(696, 356);
            this.dgv_horarios.TabIndex = 7;
            this.dgv_horarios.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_horarios_CellDoubleClick);
            this.dgv_horarios.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgv_horarios_CellFormatting);
            // 
            // col_orden
            // 
            this.col_orden.FillWeight = 30.45685F;
            this.col_orden.HeaderText = "*";
            this.col_orden.Name = "col_orden";
            this.col_orden.ReadOnly = true;
            // 
            // col_nombre_socio
            // 
            this.col_nombre_socio.FillWeight = 113.9086F;
            this.col_nombre_socio.HeaderText = "Nombre";
            this.col_nombre_socio.MinimumWidth = 10;
            this.col_nombre_socio.Name = "col_nombre_socio";
            this.col_nombre_socio.ReadOnly = true;
            // 
            // col_apellido_socio
            // 
            this.col_apellido_socio.FillWeight = 113.9086F;
            this.col_apellido_socio.HeaderText = "Apellido";
            this.col_apellido_socio.MinimumWidth = 10;
            this.col_apellido_socio.Name = "col_apellido_socio";
            this.col_apellido_socio.ReadOnly = true;
            // 
            // col_horario_inicio
            // 
            this.col_horario_inicio.FillWeight = 113.9086F;
            this.col_horario_inicio.HeaderText = "Hora ingreso";
            this.col_horario_inicio.Name = "col_horario_inicio";
            this.col_horario_inicio.ReadOnly = true;
            // 
            // col_horario_fin
            // 
            this.col_horario_fin.FillWeight = 113.9086F;
            this.col_horario_fin.HeaderText = "Horario egreso";
            this.col_horario_fin.Name = "col_horario_fin";
            this.col_horario_fin.ReadOnly = true;
            // 
            // col_socio
            // 
            this.col_socio.HeaderText = "Socio";
            this.col_socio.Name = "col_socio";
            this.col_socio.ReadOnly = true;
            this.col_socio.Visible = false;
            // 
            // frm_horarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(714, 460);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel_hora_filtro);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(650, 490);
            this.Name = "frm_horarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Horarios";
            this.Load += new System.EventHandler(this.frm_horarios_Load);
            this.panel_hora_filtro.ResumeLayout(false);
            this.panel_hora_filtro.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_horarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_hora_filtro;
        private System.Windows.Forms.ComboBox combo_fin;
        private System.Windows.Forms.ComboBox combo_inicio;
        private System.Windows.Forms.Label lbl_hora_fin;
        private System.Windows.Forms.Button btn_filtrar;
        private System.Windows.Forms.Label lbl_hora_inicio;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgv_horarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_orden;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_nombre_socio;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_apellido_socio;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_horario_inicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_horario_fin;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_socio;
        private System.Windows.Forms.Label lbl_cantidad_resultado;
        private System.Windows.Forms.Label lbl_cantidad;
    }
}