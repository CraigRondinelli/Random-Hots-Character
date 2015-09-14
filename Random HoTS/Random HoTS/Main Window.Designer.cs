namespace Random_HoTS
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.picHotsLogo = new System.Windows.Forms.PictureBox();
            this.lblPapachips = new System.Windows.Forms.Label();
            this.picGo = new System.Windows.Forms.PictureBox();
            this.picChar = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picHotsLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picChar)).BeginInit();
            this.SuspendLayout();
            // 
            // picHotsLogo
            // 
            this.picHotsLogo.BackColor = System.Drawing.Color.Transparent;
            this.picHotsLogo.Image = ((System.Drawing.Image)(resources.GetObject("picHotsLogo.Image")));
            this.picHotsLogo.Location = new System.Drawing.Point(344, 48);
            this.picHotsLogo.Name = "picHotsLogo";
            this.picHotsLogo.Size = new System.Drawing.Size(354, 135);
            this.picHotsLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picHotsLogo.TabIndex = 0;
            this.picHotsLogo.TabStop = false;
            // 
            // lblPapachips
            // 
            this.lblPapachips.AutoSize = true;
            this.lblPapachips.BackColor = System.Drawing.Color.Transparent;
            this.lblPapachips.Font = new System.Drawing.Font("Moire", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPapachips.ForeColor = System.Drawing.Color.White;
            this.lblPapachips.Location = new System.Drawing.Point(336, 0);
            this.lblPapachips.Name = "lblPapachips";
            this.lblPapachips.Size = new System.Drawing.Size(408, 45);
            this.lblPapachips.TabIndex = 1;
            this.lblPapachips.Text = "Papachips\' Random";
            // 
            // picGo
            // 
            this.picGo.Location = new System.Drawing.Point(470, 679);
            this.picGo.Name = "picGo";
            this.picGo.Size = new System.Drawing.Size(100, 44);
            this.picGo.TabIndex = 2;
            this.picGo.TabStop = false;
            this.picGo.Click += new System.EventHandler(this.picGo_Click);
            // 
            // picChar
            // 
            this.picChar.BackColor = System.Drawing.Color.Transparent;
            this.picChar.Image = ((System.Drawing.Image)(resources.GetObject("picChar.Image")));
            this.picChar.Location = new System.Drawing.Point(103, 120);
            this.picChar.Name = "picChar";
            this.picChar.Size = new System.Drawing.Size(695, 541);
            this.picChar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picChar.TabIndex = 3;
            this.picChar.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1025, 322);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(982, 741);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picGo);
            this.Controls.Add(this.lblPapachips);
            this.Controls.Add(this.picHotsLogo);
            this.Controls.Add(this.picChar);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picHotsLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picChar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picHotsLogo;
        private System.Windows.Forms.Label lblPapachips;
        private System.Windows.Forms.PictureBox picGo;
        private System.Windows.Forms.PictureBox picChar;
        private System.Windows.Forms.Label label1;
    }
}

