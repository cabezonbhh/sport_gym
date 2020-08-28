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
            this.txt_nro_socio_eliminar = new System.Windows.Forms.TextBox();
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
            // 
            // txt_nro_socio_eliminar
            // 
            this.txt_nro_socio_eliminar.Location = new System.Drawing.Point(51, 71);
            this.txt_nro_socio_eliminar.MaxLength = 4;
            this.txt_nro_socio_eliminar.Name = "txt_nro_socio_eliminar";
            this.txt_nro_socio_eliminar.Size = new System.Drawing.Size(99, 20);
            this.txt_nro_socio_eliminar.TabIndex = 1;
            this.txt_nro_socio_eliminar.TextChanged += new System.EventHandler(this.txt_nro_socio_eliminar_TextChanged);
            this.txt_nro_socio_eliminar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_nro_socio_eliminar_KeyPress);
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
            // 
            // btn_borrar
            // 
            this.btn_borrar.Location = new System.Drawing.Point(224, 69);
            this.btn_borrar.Name = "btn_borrar";
            this.btn_borrar.Size = new System.Drawing.Size(75, 23);
            this.btn_borrar.TabIndex = 4;
            this.btn_borrar.Text = "Borrar";
            this.btn_borrar.UseVisualStyleBackColor = true;
            this.btn_borrar.Click += new System.EventHandler(this.btn_borrar_Click);
            // 
            // frm_eliminar_socio
            // 
            this.AcceptButton = this.btn_borrar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(311, 110);
            this.Controls.Add(this.btn_borrar);
            this.Controls.Add(this.lbl_socio_borrar);
            this.Controls.Add(this.lbl_nro_borrar);
            this.Controls.Add(this.txt_nro_socio_eliminar);
            this.Controls.Add(this.lbl_info_borrar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_eliminar_socio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Eliminar";
            this.Load += new System.EventHandler(this.frm_eliminar_socio_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_info_borrar;
        private System.Windows.Forms.TextBox txt_nro_socio_eliminar;
        private System.Windows.Forms.Label lbl_nro_borrar;
        private System.Windows.Forms.Label lbl_socio_borrar;
        private System.Windows.Forms.Button btn_borrar;
    }
}