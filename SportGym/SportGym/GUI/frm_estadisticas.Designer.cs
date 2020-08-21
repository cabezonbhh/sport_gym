namespace SportGym.GUI
{
    partial class frm_estadisticas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_estadisticas));
            this.lbl_socios_activos = new System.Windows.Forms.Label();
            this.lbl_cuotas_vencidas = new System.Windows.Forms.Label();
            this.lbl_ingresos_estimados = new System.Windows.Forms.Label();
            this.lbl_ingresos_actuales = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_socios_activos
            // 
            this.lbl_socios_activos.AutoSize = true;
            this.lbl_socios_activos.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_socios_activos.Location = new System.Drawing.Point(123, 34);
            this.lbl_socios_activos.Name = "lbl_socios_activos";
            this.lbl_socios_activos.Size = new System.Drawing.Size(72, 26);
            this.lbl_socios_activos.TabIndex = 0;
            this.lbl_socios_activos.Text = "Socios:";
            // 
            // lbl_cuotas_vencidas
            // 
            this.lbl_cuotas_vencidas.AutoSize = true;
            this.lbl_cuotas_vencidas.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cuotas_vencidas.Location = new System.Drawing.Point(39, 79);
            this.lbl_cuotas_vencidas.Name = "lbl_cuotas_vencidas";
            this.lbl_cuotas_vencidas.Size = new System.Drawing.Size(156, 26);
            this.lbl_cuotas_vencidas.TabIndex = 1;
            this.lbl_cuotas_vencidas.Text = "Cuotas vencidas:";
            // 
            // lbl_ingresos_estimados
            // 
            this.lbl_ingresos_estimados.AutoSize = true;
            this.lbl_ingresos_estimados.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ingresos_estimados.Location = new System.Drawing.Point(12, 129);
            this.lbl_ingresos_estimados.Name = "lbl_ingresos_estimados";
            this.lbl_ingresos_estimados.Size = new System.Drawing.Size(183, 26);
            this.lbl_ingresos_estimados.TabIndex = 2;
            this.lbl_ingresos_estimados.Text = "Ingresos estimados:";
            // 
            // lbl_ingresos_actuales
            // 
            this.lbl_ingresos_actuales.AutoSize = true;
            this.lbl_ingresos_actuales.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ingresos_actuales.Location = new System.Drawing.Point(29, 178);
            this.lbl_ingresos_actuales.Name = "lbl_ingresos_actuales";
            this.lbl_ingresos_actuales.Size = new System.Drawing.Size(166, 26);
            this.lbl_ingresos_actuales.TabIndex = 3;
            this.lbl_ingresos_actuales.Text = "Ingresos actuales:";
            // 
            // frm_estadisticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.lbl_ingresos_actuales);
            this.Controls.Add(this.lbl_ingresos_estimados);
            this.Controls.Add(this.lbl_cuotas_vencidas);
            this.Controls.Add(this.lbl_socios_activos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(400, 300);
            this.MinimizeBox = false;
            this.Name = "frm_estadisticas";
            this.Text = "Estadisticas";
            this.Load += new System.EventHandler(this.Estadisticas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_socios_activos;
        private System.Windows.Forms.Label lbl_cuotas_vencidas;
        private System.Windows.Forms.Label lbl_ingresos_estimados;
        private System.Windows.Forms.Label lbl_ingresos_actuales;
    }
}