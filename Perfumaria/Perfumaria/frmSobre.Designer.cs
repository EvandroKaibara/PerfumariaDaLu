namespace Perfumaria
{
    partial class frmSobre
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
            this.lblTexto = new System.Windows.Forms.Label();
            this.lblSistema = new System.Windows.Forms.Label();
            this.pctCode = new System.Windows.Forms.PictureBox();
            this.pctLogo = new System.Windows.Forms.PictureBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pctCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTexto
            // 
            this.lblTexto.Font = new System.Drawing.Font("Verdana", 12F);
            this.lblTexto.ForeColor = System.Drawing.Color.DimGray;
            this.lblTexto.Location = new System.Drawing.Point(12, 157);
            this.lblTexto.Name = "lblTexto";
            this.lblTexto.Size = new System.Drawing.Size(350, 169);
            this.lblTexto.TabIndex = 38;
            this.lblTexto.Text = "Texto";
            // 
            // lblSistema
            // 
            this.lblSistema.Font = new System.Drawing.Font("Verdana", 12F);
            this.lblSistema.ForeColor = System.Drawing.Color.DimGray;
            this.lblSistema.Location = new System.Drawing.Point(26, 91);
            this.lblSistema.Name = "lblSistema";
            this.lblSistema.Size = new System.Drawing.Size(157, 56);
            this.lblSistema.TabIndex = 37;
            this.lblSistema.Text = "Sistema";
            // 
            // pctCode
            // 
            this.pctCode.Image = global::Perfumaria.Properties.Resources.MicrosoftTeams_image;
            this.pctCode.Location = new System.Drawing.Point(26, 20);
            this.pctCode.Name = "pctCode";
            this.pctCode.Size = new System.Drawing.Size(157, 68);
            this.pctCode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctCode.TabIndex = 36;
            this.pctCode.TabStop = false;
            // 
            // pctLogo
            // 
            this.pctLogo.Image = global::Perfumaria.Properties.Resources.logo_lu;
            this.pctLogo.Location = new System.Drawing.Point(202, 20);
            this.pctLogo.Name = "pctLogo";
            this.pctLogo.Size = new System.Drawing.Size(146, 127);
            this.pctLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctLogo.TabIndex = 35;
            this.pctLogo.TabStop = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.SystemColors.Control;
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.DimGray;
            this.btnCancelar.Location = new System.Drawing.Point(243, 329);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(122, 42);
            this.btnCancelar.TabIndex = 42;
            this.btnCancelar.Text = "&Ok";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmSobre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 384);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.lblTexto);
            this.Controls.Add(this.lblSistema);
            this.Controls.Add(this.pctCode);
            this.Controls.Add(this.pctLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSobre";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sobre";
            this.Load += new System.EventHandler(this.frmSobre_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblTexto;
        private System.Windows.Forms.Label lblSistema;
        private System.Windows.Forms.PictureBox pctCode;
        private System.Windows.Forms.PictureBox pctLogo;
        private System.Windows.Forms.Button btnCancelar;
    }
}