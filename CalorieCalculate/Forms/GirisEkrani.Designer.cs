
namespace CalorieCalculate.Forms
{
    partial class GirisEkrani
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GirisEkrani));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblOturumAc = new System.Windows.Forms.Label();
            this.lblKayitOl = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lblOturumAc);
            this.panel1.Controls.Add(this.lblKayitOl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(379, 664);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CalorieCalculate.Properties.Resources.apple;
            this.pictureBox1.Location = new System.Drawing.Point(153, 307);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(89, 49);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(192, 395);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "I";
            // 
            // lblOturumAc
            // 
            this.lblOturumAc.AutoSize = true;
            this.lblOturumAc.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblOturumAc.Location = new System.Drawing.Point(210, 395);
            this.lblOturumAc.Name = "lblOturumAc";
            this.lblOturumAc.Size = new System.Drawing.Size(90, 20);
            this.lblOturumAc.TabIndex = 0;
            this.lblOturumAc.Tag = "2";
            this.lblOturumAc.Text = "Oturum Aç";
            this.lblOturumAc.Click += new System.EventHandler(this.Click);
            // 
            // lblKayitOl
            // 
            this.lblKayitOl.AutoSize = true;
            this.lblKayitOl.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblKayitOl.Location = new System.Drawing.Point(113, 395);
            this.lblKayitOl.Name = "lblKayitOl";
            this.lblKayitOl.Size = new System.Drawing.Size(81, 20);
            this.lblKayitOl.TabIndex = 0;
            this.lblKayitOl.Tag = "1";
            this.lblKayitOl.Text = "Kayıt Ol";
            this.lblKayitOl.Click += new System.EventHandler(this.Click);
            // 
            // GirisEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 664);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GirisEkrani";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GirisEkrani";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblOturumAc;
        private System.Windows.Forms.Label lblKayitOl;
    }
}