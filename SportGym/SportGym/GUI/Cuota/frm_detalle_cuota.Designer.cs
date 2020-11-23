namespace SportGym.GUI.Cuota
{
    partial class frm_detalle_cuota
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_detalle_cuota));
            this.dtp_fecha_vto = new System.Windows.Forms.DateTimePicker();
            this.dtp_fecha_inicio = new System.Windows.Forms.DateTimePicker();
            this.txt_monto = new System.Windows.Forms.TextBox();
            this.lbl_fecha_fin = new System.Windows.Forms.Label();
            this.lbl_fecha_inicio = new System.Windows.Forms.Label();
            this.lbl_monto = new System.Windows.Forms.Label();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dtp_fecha_vto
            // 
            this.dtp_fecha_vto.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_fecha_vto.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_fecha_vto.Location = new System.Drawing.Point(117, 67);
            this.dtp_fecha_vto.Name = "dtp_fecha_vto";
            this.dtp_fecha_vto.Size = new System.Drawing.Size(132, 26);
            this.dtp_fecha_vto.TabIndex = 17;
            // 
            // dtp_fecha_inicio
            // 
            this.dtp_fecha_inicio.CalendarFont = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_fecha_inicio.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_fecha_inicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_fecha_inicio.Location = new System.Drawing.Point(117, 18);
            this.dtp_fecha_inicio.Name = "dtp_fecha_inicio";
            this.dtp_fecha_inicio.Size = new System.Drawing.Size(132, 26);
            this.dtp_fecha_inicio.TabIndex = 16;
            this.dtp_fecha_inicio.ValueChanged += new System.EventHandler(this.dtp_fecha_inicio_ValueChanged);
            // 
            // txt_monto
            // 
            this.txt_monto.Location = new System.Drawing.Point(117, 117);
            this.txt_monto.Name = "txt_monto";
            this.txt_monto.Size = new System.Drawing.Size(100, 20);
            this.txt_monto.TabIndex = 18;
            this.txt_monto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_monto_KeyPress);
            // 
            // lbl_fecha_fin
            // 
            this.lbl_fecha_fin.AutoSize = true;
            this.lbl_fecha_fin.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fecha_fin.Location = new System.Drawing.Point(32, 73);
            this.lbl_fecha_fin.Name = "lbl_fecha_fin";
            this.lbl_fecha_fin.Size = new System.Drawing.Size(70, 18);
            this.lbl_fecha_fin.TabIndex = 20;
            this.lbl_fecha_fin.Text = "Fecha Fin:";
            // 
            // lbl_fecha_inicio
            // 
            this.lbl_fecha_inicio.AutoSize = true;
            this.lbl_fecha_inicio.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fecha_inicio.Location = new System.Drawing.Point(17, 24);
            this.lbl_fecha_inicio.Name = "lbl_fecha_inicio";
            this.lbl_fecha_inicio.Size = new System.Drawing.Size(85, 18);
            this.lbl_fecha_inicio.TabIndex = 19;
            this.lbl_fecha_inicio.Text = "Fecha Inicio:";
            // 
            // lbl_monto
            // 
            this.lbl_monto.AutoSize = true;
            this.lbl_monto.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_monto.Location = new System.Drawing.Point(48, 117);
            this.lbl_monto.Name = "lbl_monto";
            this.lbl_monto.Size = new System.Drawing.Size(54, 18);
            this.lbl_monto.TabIndex = 21;
            this.lbl_monto.Text = "Monto:";
            // 
            // btn_guardar
            // 
            this.btn_guardar.Location = new System.Drawing.Point(174, 167);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(75, 23);
            this.btn_guardar.TabIndex = 22;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // frm_detalle_cuota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 201);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.lbl_monto);
            this.Controls.Add(this.lbl_fecha_fin);
            this.Controls.Add(this.lbl_fecha_inicio);
            this.Controls.Add(this.txt_monto);
            this.Controls.Add(this.dtp_fecha_vto);
            this.Controls.Add(this.dtp_fecha_inicio);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_detalle_cuota";
            this.Text = "Cuota";
            this.Load += new System.EventHandler(this.frm_detalle_cuota_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtp_fecha_vto;
        private System.Windows.Forms.DateTimePicker dtp_fecha_inicio;
        private System.Windows.Forms.TextBox txt_monto;
        private System.Windows.Forms.Label lbl_fecha_fin;
        private System.Windows.Forms.Label lbl_fecha_inicio;
        private System.Windows.Forms.Label lbl_monto;
        private System.Windows.Forms.Button btn_guardar;
    }
}