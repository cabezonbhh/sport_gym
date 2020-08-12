namespace SportGym.GUI.Cuota
{
    partial class frm_historial_pagos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_historial_pagos));
            this.dgv_cuotas = new System.Windows.Forms.DataGridView();
            this.col_codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_fecha_pago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_fecha_inicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_fecha_fin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cuotas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_cuotas
            // 
            this.dgv_cuotas.AllowUserToAddRows = false;
            this.dgv_cuotas.AllowUserToDeleteRows = false;
            this.dgv_cuotas.AllowUserToOrderColumns = true;
            this.dgv_cuotas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_cuotas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_cuotas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_cuotas.ColumnHeadersHeight = 30;
            this.dgv_cuotas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_codigo,
            this.col_fecha_pago,
            this.col_monto,
            this.col_fecha_inicio,
            this.col_fecha_fin});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_cuotas.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_cuotas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_cuotas.Location = new System.Drawing.Point(0, 0);
            this.dgv_cuotas.MultiSelect = false;
            this.dgv_cuotas.Name = "dgv_cuotas";
            this.dgv_cuotas.ReadOnly = true;
            this.dgv_cuotas.RowHeadersVisible = false;
            this.dgv_cuotas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgv_cuotas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_cuotas.Size = new System.Drawing.Size(784, 561);
            this.dgv_cuotas.TabIndex = 5;
            // 
            // col_codigo
            // 
            this.col_codigo.HeaderText = "Codigo";
            this.col_codigo.MinimumWidth = 10;
            this.col_codigo.Name = "col_codigo";
            this.col_codigo.ReadOnly = true;
            // 
            // col_fecha_pago
            // 
            this.col_fecha_pago.HeaderText = "Fecha Pago";
            this.col_fecha_pago.MinimumWidth = 10;
            this.col_fecha_pago.Name = "col_fecha_pago";
            this.col_fecha_pago.ReadOnly = true;
            // 
            // col_monto
            // 
            this.col_monto.HeaderText = "Monto";
            this.col_monto.MinimumWidth = 10;
            this.col_monto.Name = "col_monto";
            this.col_monto.ReadOnly = true;
            // 
            // col_fecha_inicio
            // 
            this.col_fecha_inicio.HeaderText = "Fecha Inicio";
            this.col_fecha_inicio.Name = "col_fecha_inicio";
            this.col_fecha_inicio.ReadOnly = true;
            // 
            // col_fecha_fin
            // 
            this.col_fecha_fin.HeaderText = "Fecha Fin";
            this.col_fecha_fin.Name = "col_fecha_fin";
            this.col_fecha_fin.ReadOnly = true;
            // 
            // frm_historial_pagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.dgv_cuotas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_historial_pagos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Historial de pagos";
            this.Load += new System.EventHandler(this.frm_historial_pagos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cuotas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_cuotas;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_fecha_pago;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_monto;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_fecha_inicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_fecha_fin;
    }
}