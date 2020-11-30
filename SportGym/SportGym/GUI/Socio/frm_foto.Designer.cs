namespace SportGym.GUI.Socio
{
    partial class frm_foto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_foto));
            this.combo_dispositivos = new System.Windows.Forms.ComboBox();
            this.lbl_dispositivo = new System.Windows.Forms.Label();
            this.btn_tomar_foto = new System.Windows.Forms.Button();
            this.btn_borrar_foto = new System.Windows.Forms.Button();
            this.pic_foto_tomada = new System.Windows.Forms.PictureBox();
            this.pic_foto_vivo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_foto_tomada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_foto_vivo)).BeginInit();
            this.SuspendLayout();
            // 
            // combo_dispositivos
            // 
            this.combo_dispositivos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_dispositivos.FormattingEnabled = true;
            this.combo_dispositivos.Location = new System.Drawing.Point(10, 12);
            this.combo_dispositivos.Name = "combo_dispositivos";
            this.combo_dispositivos.Size = new System.Drawing.Size(392, 28);
            this.combo_dispositivos.TabIndex = 2;
            this.combo_dispositivos.SelectedIndexChanged += new System.EventHandler(this.combo_dispositivos_SelectedIndexChanged);
            // 
            // lbl_dispositivo
            // 
            this.lbl_dispositivo.AutoSize = true;
            this.lbl_dispositivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dispositivo.Location = new System.Drawing.Point(408, 18);
            this.lbl_dispositivo.Name = "lbl_dispositivo";
            this.lbl_dispositivo.Size = new System.Drawing.Size(82, 16);
            this.lbl_dispositivo.TabIndex = 3;
            this.lbl_dispositivo.Text = "Dispositivos";
            // 
            // btn_tomar_foto
            // 
            this.btn_tomar_foto.Enabled = false;
            this.btn_tomar_foto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tomar_foto.Location = new System.Drawing.Point(10, 377);
            this.btn_tomar_foto.Name = "btn_tomar_foto";
            this.btn_tomar_foto.Size = new System.Drawing.Size(480, 44);
            this.btn_tomar_foto.TabIndex = 4;
            this.btn_tomar_foto.Text = "Tomar Foto";
            this.btn_tomar_foto.UseVisualStyleBackColor = true;
            this.btn_tomar_foto.Click += new System.EventHandler(this.btn_tomar_foto_Click);
            // 
            // btn_borrar_foto
            // 
            this.btn_borrar_foto.Enabled = false;
            this.btn_borrar_foto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_borrar_foto.Location = new System.Drawing.Point(510, 377);
            this.btn_borrar_foto.Name = "btn_borrar_foto";
            this.btn_borrar_foto.Size = new System.Drawing.Size(480, 44);
            this.btn_borrar_foto.TabIndex = 5;
            this.btn_borrar_foto.Text = "Borrar";
            this.btn_borrar_foto.UseVisualStyleBackColor = true;
            this.btn_borrar_foto.Click += new System.EventHandler(this.btn_borrar_foto_Click);
            // 
            // pic_foto_tomada
            // 
            this.pic_foto_tomada.Image = global::SportGym.Properties.Resources.camera;
            this.pic_foto_tomada.InitialImage = global::SportGym.Properties.Resources.camera;
            this.pic_foto_tomada.Location = new System.Drawing.Point(509, 50);
            this.pic_foto_tomada.Name = "pic_foto_tomada";
            this.pic_foto_tomada.Size = new System.Drawing.Size(480, 320);
            this.pic_foto_tomada.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_foto_tomada.TabIndex = 1;
            this.pic_foto_tomada.TabStop = false;
            // 
            // pic_foto_vivo
            // 
            this.pic_foto_vivo.Image = global::SportGym.Properties.Resources.camera;
            this.pic_foto_vivo.InitialImage = global::SportGym.Properties.Resources.camera;
            this.pic_foto_vivo.Location = new System.Drawing.Point(10, 50);
            this.pic_foto_vivo.Name = "pic_foto_vivo";
            this.pic_foto_vivo.Size = new System.Drawing.Size(480, 320);
            this.pic_foto_vivo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_foto_vivo.TabIndex = 0;
            this.pic_foto_vivo.TabStop = false;
            // 
            // frm_foto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 431);
            this.Controls.Add(this.btn_borrar_foto);
            this.Controls.Add(this.btn_tomar_foto);
            this.Controls.Add(this.lbl_dispositivo);
            this.Controls.Add(this.combo_dispositivos);
            this.Controls.Add(this.pic_foto_tomada);
            this.Controls.Add(this.pic_foto_vivo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_foto";
            this.Text = "Foto";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frm_foto_FormClosed);
            this.Load += new System.EventHandler(this.frm_foto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_foto_tomada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_foto_vivo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_foto_vivo;
        private System.Windows.Forms.PictureBox pic_foto_tomada;
        private System.Windows.Forms.ComboBox combo_dispositivos;
        private System.Windows.Forms.Label lbl_dispositivo;
        private System.Windows.Forms.Button btn_tomar_foto;
        private System.Windows.Forms.Button btn_borrar_foto;
    }
}