namespace promosyonTakip.UI.Musteri
{
    partial class hediyeGoster
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(hediyeGoster));
            this.button1 = new System.Windows.Forms.Button();
            this.pctHediyeResim = new System.Windows.Forms.PictureBox();
            this.lblAciklama = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pctHediyeResim)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(9, 306);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(635, 41);
            this.button1.TabIndex = 0;
            this.button1.Text = "Yeni Kayıt Giriş";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pctHediyeResim
            // 
            this.pctHediyeResim.Image = ((System.Drawing.Image)(resources.GetObject("pctHediyeResim.Image")));
            this.pctHediyeResim.Location = new System.Drawing.Point(12, 12);
            this.pctHediyeResim.Name = "pctHediyeResim";
            this.pctHediyeResim.Size = new System.Drawing.Size(263, 288);
            this.pctHediyeResim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctHediyeResim.TabIndex = 1;
            this.pctHediyeResim.TabStop = false;
            // 
            // lblAciklama
            // 
            this.lblAciklama.AutoSize = true;
            this.lblAciklama.Location = new System.Drawing.Point(281, 151);
            this.lblAciklama.Name = "lblAciklama";
            this.lblAciklama.Size = new System.Drawing.Size(100, 16);
            this.lblAciklama.TabIndex = 2;
            this.lblAciklama.Text = "ABC kazandınız";
            // 
            // hediyeGoster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 359);
            this.Controls.Add(this.lblAciklama);
            this.Controls.Add(this.pctHediyeResim);
            this.Controls.Add(this.button1);
            this.Name = "hediyeGoster";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "hediyeGoster";
            this.Load += new System.EventHandler(this.hediyeGoster_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctHediyeResim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pctHediyeResim;
        private System.Windows.Forms.Label lblAciklama;
    }
}