
namespace CalorieCalculate.Forms
{
    partial class SecilenOgun
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SecilenOgun));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbBack = new System.Windows.Forms.PictureBox();
            this.lblOgunAdi = new System.Windows.Forms.Label();
            this.dgvOgun = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.klcButton1 = new KLCToolbox.KLCControls.KLCButton();
            this.btnÜrünEkle = new KLCToolbox.KLCControls.KLCButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOgun)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.pbBack);
            this.panel1.Controls.Add(this.lblOgunAdi);
            this.panel1.Controls.Add(this.dgvOgun);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.klcButton1);
            this.panel1.Controls.Add(this.btnÜrünEkle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(336, 502);
            this.panel1.TabIndex = 3;
            // 
            // pbBack
            // 
            this.pbBack.BackColor = System.Drawing.Color.Transparent;
            this.pbBack.Image = ((System.Drawing.Image)(resources.GetObject("pbBack.Image")));
            this.pbBack.Location = new System.Drawing.Point(3, 0);
            this.pbBack.Name = "pbBack";
            this.pbBack.Size = new System.Drawing.Size(57, 34);
            this.pbBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBack.TabIndex = 24;
            this.pbBack.TabStop = false;
            this.pbBack.Tag = "4";
            // 
            // lblOgunAdi
            // 
            this.lblOgunAdi.AutoSize = true;
            this.lblOgunAdi.BackColor = System.Drawing.Color.Silver;
            this.lblOgunAdi.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblOgunAdi.Location = new System.Drawing.Point(12, 62);
            this.lblOgunAdi.Name = "lblOgunAdi";
            this.lblOgunAdi.Size = new System.Drawing.Size(64, 18);
            this.lblOgunAdi.TabIndex = 23;
            this.lblOgunAdi.Text = "OgunAdi";
            // 
            // dgvOgun
            // 
            this.dgvOgun.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOgun.Location = new System.Drawing.Point(12, 86);
            this.dgvOgun.Name = "dgvOgun";
            this.dgvOgun.RowHeadersWidth = 51;
            this.dgvOgun.RowTemplate.Height = 25;
            this.dgvOgun.Size = new System.Drawing.Size(312, 237);
            this.dgvOgun.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(134, 450);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(61, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // klcButton1
            // 
            this.klcButton1.BackColor = System.Drawing.Color.OrangeRed;
            this.klcButton1.FlatAppearance.BorderSize = 0;
            this.klcButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.klcButton1.ForeColor = System.Drawing.Color.Black;
            this.klcButton1.KLCBackgroundColor = System.Drawing.Color.OrangeRed;
            this.klcButton1.KLCBorderColor = System.Drawing.Color.PaleVioletRed;
            this.klcButton1.KLCBorderRadius = 24;
            this.klcButton1.KLCBorderSize = 0;
            this.klcButton1.KLCTextColor = System.Drawing.Color.Black;
            this.klcButton1.Location = new System.Drawing.Point(242, 49);
            this.klcButton1.Name = "klcButton1";
            this.klcButton1.Size = new System.Drawing.Size(82, 31);
            this.klcButton1.TabIndex = 2;
            this.klcButton1.Tag = "2";
            this.klcButton1.Text = "Gıda Sil";
            this.klcButton1.UseVisualStyleBackColor = false;
            this.klcButton1.Click += new System.EventHandler(this.Click);
            // 
            // btnÜrünEkle
            // 
            this.btnÜrünEkle.BackColor = System.Drawing.Color.OrangeRed;
            this.btnÜrünEkle.FlatAppearance.BorderSize = 0;
            this.btnÜrünEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnÜrünEkle.ForeColor = System.Drawing.Color.Black;
            this.btnÜrünEkle.KLCBackgroundColor = System.Drawing.Color.OrangeRed;
            this.btnÜrünEkle.KLCBorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnÜrünEkle.KLCBorderRadius = 24;
            this.btnÜrünEkle.KLCBorderSize = 0;
            this.btnÜrünEkle.KLCTextColor = System.Drawing.Color.Black;
            this.btnÜrünEkle.Location = new System.Drawing.Point(242, 12);
            this.btnÜrünEkle.Name = "btnÜrünEkle";
            this.btnÜrünEkle.Size = new System.Drawing.Size(82, 31);
            this.btnÜrünEkle.TabIndex = 1;
            this.btnÜrünEkle.Tag = "1";
            this.btnÜrünEkle.Text = "Gıda Ekle";
            this.btnÜrünEkle.UseVisualStyleBackColor = false;
            this.btnÜrünEkle.Click += new System.EventHandler(this.Click);
            // 
            // SecilenOgun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 502);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SecilenOgun";
            this.Text = "AVOCADO";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOgun)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private KLCToolbox.KLCControls.KLCButton btnÜrünEkle;
        private KLCToolbox.KLCControls.KLCButton klcButton1;
        private System.Windows.Forms.DataGridView dgvOgun;
        private System.Windows.Forms.Label lblOgunAdi;
        private System.Windows.Forms.PictureBox pbBack;
    }
}