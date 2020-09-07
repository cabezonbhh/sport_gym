namespace SportGym.GUI.Cuota
{
    partial class frm_vencidos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_vencidos));
            this.panel_info = new System.Windows.Forms.Panel();
            this.lbl_cantidad = new System.Windows.Forms.Label();
            this.dgv_cuotas = new System.Windows.Forms.DataGridView();
            this.col_nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_fecha_pago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_fecha_fin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_celular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel_info.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cuotas)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_info
            // 
            this.panel_info.Controls.Add(this.lbl_cantidad);
            this.panel_info.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_info.Location = new System.Drawing.Point(0, 350);
            this.panel_info.Name = "panel_info";
            this.panel_info.Size = new System.Drawing.Size(684, 61);
            this.panel_info.TabIndex = 0;
            // 
            // lbl_cantidad
            // 
            this.lbl_cantidad.AutoSize = true;
            this.lbl_cantidad.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cantidad.Location = new System.Drawing.Point(3, 13);
            this.lbl_cantidad.Name = "lbl_cantidad";
            this.lbl_cantidad.Size = new System.Drawing.Size(98, 39);
            this.lbl_cantidad.TabIndex = 0;
            this.lbl_cantidad.Text = "label1";
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
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_cuotas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_cuotas.ColumnHeadersHeight = 30;
            this.dgv_cuotas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_nombre,
            this.col_apellido,
            this.col_fecha_pago,
            this.col_fecha_fin,
            this.col_estado,
            this.col_celular});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_cuotas.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_cuotas.RowHeadersVisible = false;
            this.dgv_cuotas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgv_cuotas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_cuotas.Size = new System.Drawing.Size(684, 350);
            this.dgv_cuotas.TabIndex = 6;
            // 
            // col_nombre
            // 
            this.col_nombre.HeaderText = "Nombre";
            this.col_nombre.Name = "col_nombre";
            this.col_nombre.ReadOnly = true;
            // 
            // col_apellido
            // 
            this.col_apellido.HeaderText = "Apellido";
            this.col_apellido.Name = "col_apellido";
            this.col_apellido.ReadOnly = true;
            // 
            // col_fecha_pago
            // 
            this.col_fecha_pago.HeaderText = "Fecha Pago";
            this.col_fecha_pago.MinimumWidth = 10;
            this.col_fecha_pago.Name = "col_fecha_pago";
            this.col_fecha_pago.ReadOnly = true;
            // 
            // col_fecha_fin
            // 
            this.col_fecha_fin.HeaderText = "Fecha Fin";
            this.col_fecha_fin.Name = "col_fecha_fin";
            this.col_fecha_fin.ReadOnly = true;
            // 
            // col_estado
            // 
            this.col_estado.HeaderText = "Estado";
            this.col_estado.Name = "col_estado";
            this.col_estado.ReadOnly = true;
            // 
            // col_celular
            // 
            this.col_celular.HeaderText = "Celular";
            this.col_celular.Name = "col_celular";
            this.col_celular.ReadOnly = true;
            // 
            // frm_vencidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(684, 411);
            this.Controls.Add(this.dgv_cuotas);
            this.Controls.Add(this.panel_info);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_vencidos";
            this.Text = "Vencidos";
            this.Load += new System.EventHandler(this.frm_vencidos_Load);
            this.panel_info.ResumeLayout(false);
            this.panel_info.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cuotas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_info;
        private System.Windows.Forms.DataGridView dgv_cuotas;
        private System.Windows.Forms.Label lbl_cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_fecha_pago;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_fecha_fin;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_celular;
    }
}