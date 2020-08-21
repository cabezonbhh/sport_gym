namespace SportGym.GUI.Horarios
{
    partial class frm_horarios_automaticos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_horarios_automaticos));
            this.dgv_horarios = new System.Windows.Forms.DataGridView();
            this.col_orden = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_nombre_socio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_apellido_socio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_horario_inicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_horario_fin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_horarios)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_horarios
            // 
            this.dgv_horarios.AllowUserToAddRows = false;
            this.dgv_horarios.AllowUserToDeleteRows = false;
            this.dgv_horarios.AllowUserToOrderColumns = true;
            this.dgv_horarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_horarios.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_horarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_horarios.ColumnHeadersHeight = 30;
            this.dgv_horarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_orden,
            this.col_nombre_socio,
            this.col_apellido_socio,
            this.col_horario_inicio,
            this.col_horario_fin});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_horarios.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_horarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_horarios.Location = new System.Drawing.Point(0, 0);
            this.dgv_horarios.MultiSelect = false;
            this.dgv_horarios.Name = "dgv_horarios";
            this.dgv_horarios.ReadOnly = true;
            this.dgv_horarios.RowHeadersVisible = false;
            this.dgv_horarios.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgv_horarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_horarios.Size = new System.Drawing.Size(800, 450);
            this.dgv_horarios.TabIndex = 6;
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
            this.col_horario_inicio.HeaderText = "Hora inicio";
            this.col_horario_inicio.Name = "col_horario_inicio";
            this.col_horario_inicio.ReadOnly = true;
            // 
            // col_horario_fin
            // 
            this.col_horario_fin.FillWeight = 113.9086F;
            this.col_horario_fin.HeaderText = "Horario fin";
            this.col_horario_fin.Name = "col_horario_fin";
            this.col_horario_fin.ReadOnly = true;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frm_horarios_automaticos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgv_horarios);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_horarios_automaticos";
            this.Text = "Horarios COVID-19";
            this.Load += new System.EventHandler(this.frm_horarios_automaticos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_horarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_horarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_orden;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_nombre_socio;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_apellido_socio;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_horario_inicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_horario_fin;
        private System.Windows.Forms.Timer timer1;
    }
}