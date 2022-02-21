
namespace CalorieCalculate.Forms
{
    partial class Interface
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Interface));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pbOgunler = new KLCToolbox.KLCControls.KLCCircularPictureBox();
            this.pbRaporlar = new KLCToolbox.KLCControls.KLCCircularPictureBox();
            this.pbKitle = new KLCToolbox.KLCControls.KLCCircularPictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbOgunler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRaporlar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbKitle)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pbOgunler);
            this.panel1.Controls.Add(this.pbRaporlar);
            this.panel1.Controls.Add(this.pbKitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(316, 459);
            this.panel1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.OrangeRed;
            this.label2.Location = new System.Drawing.Point(201, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 15);
            this.label2.TabIndex = 16;
            this.label2.Text = "Raporlarım";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.OrangeRed;
            this.label3.Location = new System.Drawing.Point(45, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 15);
            this.label3.TabIndex = 17;
            this.label3.Text = "Öğünlerim";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.OrangeRed;
            this.label1.Location = new System.Drawing.Point(23, 353);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 15);
            this.label1.TabIndex = 15;
            this.label1.Text = "Beden Kitle İndeksim";
            // 
            // pbOgunler
            // 
            this.pbOgunler.Image = global::CalorieCalculate.Properties.Resources.ogun_atlamanin_zararlari_nelerdir;
            this.pbOgunler.KLCBorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.pbOgunler.KLCBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pbOgunler.KLCBorderColor2 = System.Drawing.Color.OrangeRed;
            this.pbOgunler.KLCBorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.pbOgunler.KLCBorderSize = 2;
            this.pbOgunler.KLCGradientAngle = 50F;
            this.pbOgunler.Location = new System.Drawing.Point(23, 12);
            this.pbOgunler.Name = "pbOgunler";
            this.pbOgunler.Size = new System.Drawing.Size(107, 107);
            this.pbOgunler.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbOgunler.TabIndex = 14;
            this.pbOgunler.TabStop = false;
            // 
            // pbRaporlar
            // 
            this.pbRaporlar.Image = global::CalorieCalculate.Properties.Resources.rapor;
            this.pbRaporlar.KLCBorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.pbRaporlar.KLCBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pbRaporlar.KLCBorderColor2 = System.Drawing.Color.OrangeRed;
            this.pbRaporlar.KLCBorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.pbRaporlar.KLCBorderSize = 2;
            this.pbRaporlar.KLCGradientAngle = 50F;
            this.pbRaporlar.Location = new System.Drawing.Point(188, 82);
            this.pbRaporlar.Name = "pbRaporlar";
            this.pbRaporlar.Size = new System.Drawing.Size(100, 100);
            this.pbRaporlar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbRaporlar.TabIndex = 13;
            this.pbRaporlar.TabStop = false;
            // 
            // pbKitle
            // 
            this.pbKitle.Image = ((System.Drawing.Image)(resources.GetObject("pbKitle.Image")));
            this.pbKitle.KLCBorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.pbKitle.KLCBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pbKitle.KLCBorderColor2 = System.Drawing.Color.OrangeRed;
            this.pbKitle.KLCBorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.pbKitle.KLCBorderSize = 2;
            this.pbKitle.KLCGradientAngle = 50F;
            this.pbKitle.Location = new System.Drawing.Point(36, 243);
            this.pbKitle.Name = "pbKitle";
            this.pbKitle.Size = new System.Drawing.Size(107, 107);
            this.pbKitle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbKitle.TabIndex = 12;
            this.pbKitle.TabStop = false;
            // 
            // Interface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 459);
            this.Controls.Add(this.panel1);
            this.Name = "Interface";
            this.Text = "Interface";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbOgunler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRaporlar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbKitle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private KLCToolbox.KLCControls.KLCCircularPictureBox pbOgunler;
        private KLCToolbox.KLCControls.KLCCircularPictureBox pbRaporlar;
        private KLCToolbox.KLCControls.KLCCircularPictureBox pbKitle;
    }
}