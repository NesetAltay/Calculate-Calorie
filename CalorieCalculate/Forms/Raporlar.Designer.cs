
namespace CalorieCalculate.Forms
{
    partial class Raporlar
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Raporlar));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbBack = new System.Windows.Forms.PictureBox();
            this.pbProfil = new KLCToolbox.KLCControls.KLCCircularPictureBox();
            this.btnRekabetRaporu = new KLCToolbox.KLCControls.KLCButton();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnKaloriRaporu = new KLCToolbox.KLCControls.KLCButton();
            this.btnEnCokTercih = new KLCToolbox.KLCControls.KLCButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pbBack);
            this.panel1.Controls.Add(this.pbProfil);
            this.panel1.Controls.Add(this.btnRekabetRaporu);
            this.panel1.Controls.Add(this.btnKaloriRaporu);
            this.panel1.Controls.Add(this.btnEnCokTercih);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(340, 498);
            this.panel1.TabIndex = 0;
            // 
            // pbBack
            // 
            this.pbBack.BackColor = System.Drawing.Color.Transparent;
            this.pbBack.Image = ((System.Drawing.Image)(resources.GetObject("pbBack.Image")));
            this.pbBack.Location = new System.Drawing.Point(0, 0);
            this.pbBack.Name = "pbBack";
            this.pbBack.Size = new System.Drawing.Size(57, 34);
            this.pbBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBack.TabIndex = 22;
            this.pbBack.TabStop = false;
            this.pbBack.Tag = "4";
            // 
            // pbProfil
            // 
            this.pbProfil.Image = ((System.Drawing.Image)(resources.GetObject("pbProfil.Image")));
            this.pbProfil.KLCBorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.pbProfil.KLCBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.pbProfil.KLCBorderColor2 = System.Drawing.Color.OrangeRed;
            this.pbProfil.KLCBorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.pbProfil.KLCBorderSize = 2;
            this.pbProfil.KLCGradientAngle = 50F;
            this.pbProfil.Location = new System.Drawing.Point(280, 0);
            this.pbProfil.Name = "pbProfil";
            this.pbProfil.Size = new System.Drawing.Size(34, 34);
            this.pbProfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbProfil.TabIndex = 21;
            this.pbProfil.TabStop = false;
            this.pbProfil.Tag = "5";
            // 
            // btnRekabetRaporu
            // 
            this.btnRekabetRaporu.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnRekabetRaporu.FlatAppearance.BorderSize = 0;
            this.btnRekabetRaporu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRekabetRaporu.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRekabetRaporu.ForeColor = System.Drawing.Color.Black;
            this.btnRekabetRaporu.ImageIndex = 1;
            this.btnRekabetRaporu.ImageList = this.ımageList1;
            this.btnRekabetRaporu.KLCBackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnRekabetRaporu.KLCBorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnRekabetRaporu.KLCBorderRadius = 40;
            this.btnRekabetRaporu.KLCBorderSize = 0;
            this.btnRekabetRaporu.KLCTextColor = System.Drawing.Color.Black;
            this.btnRekabetRaporu.Location = new System.Drawing.Point(90, 156);
            this.btnRekabetRaporu.Name = "btnRekabetRaporu";
            this.btnRekabetRaporu.Size = new System.Drawing.Size(162, 82);
            this.btnRekabetRaporu.TabIndex = 18;
            this.btnRekabetRaporu.Tag = "2";
            this.btnRekabetRaporu.Text = "Rekabet Raporum";
            this.btnRekabetRaporu.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnRekabetRaporu.UseVisualStyleBackColor = false;
            // 
            // ımageList1
            // 
            this.ımageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "55.png");
            this.ımageList1.Images.SetKeyName(1, "eticarette-rekabet-etmek.jpg");
            this.ımageList1.Images.SetKeyName(2, "istanbul-rekabet-forumu-25-26-kasim-da-gerceklestirilecek-8708.jpg");
            // 
            // btnKaloriRaporu
            // 
            this.btnKaloriRaporu.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnKaloriRaporu.FlatAppearance.BorderSize = 0;
            this.btnKaloriRaporu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKaloriRaporu.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnKaloriRaporu.ForeColor = System.Drawing.Color.Black;
            this.btnKaloriRaporu.ImageIndex = 2;
            this.btnKaloriRaporu.ImageList = this.ımageList1;
            this.btnKaloriRaporu.KLCBackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnKaloriRaporu.KLCBorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnKaloriRaporu.KLCBorderRadius = 40;
            this.btnKaloriRaporu.KLCBorderSize = 0;
            this.btnKaloriRaporu.KLCTextColor = System.Drawing.Color.Black;
            this.btnKaloriRaporu.Location = new System.Drawing.Point(90, 47);
            this.btnKaloriRaporu.Name = "btnKaloriRaporu";
            this.btnKaloriRaporu.Size = new System.Drawing.Size(162, 93);
            this.btnKaloriRaporu.TabIndex = 19;
            this.btnKaloriRaporu.Tag = "1";
            this.btnKaloriRaporu.Text = "Kalori Raporum";
            this.btnKaloriRaporu.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnKaloriRaporu.UseVisualStyleBackColor = false;
            // 
            // btnEnCokTercih
            // 
            this.btnEnCokTercih.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnEnCokTercih.FlatAppearance.BorderSize = 0;
            this.btnEnCokTercih.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnCokTercih.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEnCokTercih.ForeColor = System.Drawing.Color.Black;
            this.btnEnCokTercih.ImageIndex = 0;
            this.btnEnCokTercih.ImageList = this.ımageList1;
            this.btnEnCokTercih.KLCBackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnEnCokTercih.KLCBorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnEnCokTercih.KLCBorderRadius = 40;
            this.btnEnCokTercih.KLCBorderSize = 0;
            this.btnEnCokTercih.KLCTextColor = System.Drawing.Color.Black;
            this.btnEnCokTercih.Location = new System.Drawing.Point(90, 259);
            this.btnEnCokTercih.Name = "btnEnCokTercih";
            this.btnEnCokTercih.Size = new System.Drawing.Size(162, 82);
            this.btnEnCokTercih.TabIndex = 20;
            this.btnEnCokTercih.Tag = "3";
            this.btnEnCokTercih.Text = "En çok Tercih Edilenler";
            this.btnEnCokTercih.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnEnCokTercih.UseVisualStyleBackColor = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(127, 416);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(61, 40);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 23;
            this.pictureBox2.TabStop = false;
            // 
            // Raporlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 459);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Raporlar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AVOCADO";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbBack;
        private KLCToolbox.KLCControls.KLCCircularPictureBox pbProfil;
        private KLCToolbox.KLCControls.KLCButton btnRekabetRaporu;
        private System.Windows.Forms.ImageList ımageList1;
        private KLCToolbox.KLCControls.KLCButton btnKaloriRaporu;
        private KLCToolbox.KLCControls.KLCButton btnEnCokTercih;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}