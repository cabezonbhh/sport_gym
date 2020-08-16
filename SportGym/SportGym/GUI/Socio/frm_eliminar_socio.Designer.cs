namespace SportGym.GUI.Socio
{
    partial class frm_eliminar_socio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_eliminar_socio));
            this.lbl_info_borrar = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbl_nro_borrar = new System.Windows.Forms.Label();
            this.lbl_socio_borrar = new System.Windows.Forms.Label();
            this.btn_borrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_info_borrar
            // 
            this.lbl_info_borrar.AutoSize = true;
            this.lbl_info_borrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_info_borrar.Location = new System.Drawing.Point(12, 9);
            this.lbl_info_borrar.Name = "lbl_info_borrar";
            this.lbl_info_borrar.Size = new System.Drawing.Size(296, 16);
            this.lbl_info_borrar.TabIndex = 0;
            this.lbl_info_borrar.Text = "Ingrese numero de socio para confirmar borrado";
            this.lbl_info_borrar.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(51, 71);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(99, 20);
            this.textBox1.TabIndex = 1;
            // 
            // lbl_nro_borrar
            // 
            this.lbl_nro_borrar.AutoSize = true;
            this.lbl_nro_borrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nro_borrar.Location = new System.Drawing.Point(12, 72);
            this.lbl_nro_borrar.Name = "lbl_nro_borrar";
            this.lbl_nro_borrar.Size = new System.Drawing.Size(33, 16);
            this.lbl_nro_borrar.TabIndex = 2;
            this.lbl_nro_borrar.Text = "Nro:";
            // 
            // lbl_socio_borrar
            // 
            this.lbl_socio_borrar.AutoSize = true;
            this.lbl_socio_borrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_socio_borrar.Location = new System.Drawing.Point(12, 40);
            this.lbl_socio_borrar.Name = "lbl_socio_borrar";
            this.lbl_socio_borrar.Size = new System.Drawing.Size(49, 16);
            this.lbl_socio_borrar.TabIndex = 3;
            this.lbl_socio_borrar.Text = "Socio: ";
            this.lbl_socio_borrar.Visible = false;
            // 
            // btn_borrar
            // 
            this.btn_borrar.Location = new System.Drawing.Point(224, 69);
            this.btn_borrar.Name = "btn_borrar";
            this.btn_borrar.Size = new System.Drawing.Size(75, 23);
            this.btn_borrar.TabIndex = 4;
            this.btn_borrar.Text = "Borrar";
            this.btn_borrar.UseVisualStyleBackColor = true;
            // 
            // frm_eliminar_socio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 110);
            this.Controls.Add(this.btn_borrar);
            this.Controls.Add(this.lbl_socio_borrar);
            this.Controls.Add(this.lbl_nro_borrar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbl_info_borrar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_eliminar_socio";
            this.Text = "Eliminar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_info_borrar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbl_nro_borrar;
        private System.Windows.Forms.Label lbl_socio_borrar;
        private System.Windows.Forms.Button btn_borrar;
    }
}