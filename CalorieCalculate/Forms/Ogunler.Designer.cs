
namespace CalorieCalculate.Forms
{
    partial class Ogunler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ogunler));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnOgunEkle = new KLCToolbox.KLCControls.KLCButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbBack = new System.Windows.Forms.PictureBox();
            this.dtpDate = new KLCToolbox.KLCControls.KLCDatePicker();
            this.pbProfil = new KLCToolbox.KLCControls.KLCCircularPictureBox();
            this.btnOgleYemegi = new KLCToolbox.KLCControls.KLCButton();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnKahvalti = new KLCToolbox.KLCControls.KLCButton();
            this.btnAksamYemegi = new KLCToolbox.KLCControls.KLCButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfil)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.btnOgunEkle);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.pbBack);
            this.panel1.Controls.Add(this.dtpDate);
            this.panel1.Controls.Add(this.pbProfil);
            this.panel1.Controls.Add(this.btnOgleYemegi);
            this.panel1.Controls.Add(this.btnKahvalti);
            this.panel1.Controls.Add(this.btnAksamYemegi);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(379, 657);
            this.panel1.TabIndex = 3;
            // 
            // btnOgunEkle
            // 
            this.btnOgunEkle.BackColor = System.Drawing.Color.Transparent;
            this.btnOgunEkle.FlatAppearance.BorderSize = 0;
            this.btnOgunEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOgunEkle.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnOgunEkle.ForeColor = System.Drawing.Color.Black;
            this.btnOgunEkle.KLCBackgroundColor = System.Drawing.Color.Transparent;
            this.btnOgunEkle.KLCBorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnOgunEkle.KLCBorderRadius = 29;
            this.btnOgunEkle.KLCBorderSize = 0;
            this.btnOgunEkle.KLCTextColor = System.Drawing.Color.Black;
            this.btnOgunEkle.Location = new System.Drawing.Point(129, 554);
            this.btnOgunEkle.Margin = new System.Windows.Forms.Padding(2);
            this.btnOgunEkle.Name = "btnOgunEkle";
            this.btnOgunEkle.Size = new System.Drawing.Size(121, 29);
            this.btnOgunEkle.TabIndex = 26;
            this.btnOgunEkle.Text = "Öğün Ekle";
            this.btnOgunEkle.UseVisualStyleBackColor = false;
            this.btnOgunEkle.Click += new System.EventHandler(this.Interface_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(151, 602);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 53);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // pbBack
            // 
            this.pbBack.BackColor = System.Drawing.Color.Transparent;
            this.pbBack.Image = ((System.Drawing.Image)(resources.GetObject("pbBack.Image")));
            this.pbBack.Location = new System.Drawing.Point(0, 0);
            this.pbBack.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pbBack.Name = "pbBack";
            this.pbBack.Size = new System.Drawing.Size(65, 45);
            this.pbBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBack.TabIndex = 24;
            this.pbBack.TabStop = false;
            this.pbBack.Tag = "4";
            this.pbBack.Click += new System.EventHandler(this.pbBack_Click);
            // 
            // dtpDate
            // 
            this.dtpDate.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpDate.KLCBorderColor = System.Drawing.Color.PaleVioletRed;
            this.dtpDate.KLCBorderSize = 0;
            this.dtpDate.KLCSkinColor = System.Drawing.Color.DarkSalmon;
            this.dtpDate.KLCTextColor = System.Drawing.Color.Black;
            this.dtpDate.Location = new System.Drawing.Point(79, 47);
            this.dtpDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpDate.MinimumSize = new System.Drawing.Size(4, 35);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(217, 35);
            this.dtpDate.TabIndex = 23;
            // 
            // pbProfil
            // 
            this.pbProfil.Image = global::CalorieCalculate.Properties.Resources.pp;
            this.pbProfil.KLCBorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.pbProfil.KLCBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.pbProfil.KLCBorderColor2 = System.Drawing.Color.OrangeRed;
            this.pbProfil.KLCBorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.pbProfil.KLCBorderSize = 2;
            this.pbProfil.KLCGradientAngle = 50F;
            this.pbProfil.Location = new System.Drawing.Point(319, 4);
            this.pbProfil.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pbProfil.Name = "pbProfil";
            this.pbProfil.Size = new System.Drawing.Size(39, 39);
            this.pbProfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbProfil.TabIndex = 22;
            this.pbProfil.TabStop = false;
            this.pbProfil.Tag = "5";
            this.pbProfil.Click += new System.EventHandler(this.pbProfil_Click);
            // 
            // btnOgleYemegi
            // 
            this.btnOgleYemegi.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnOgleYemegi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOgleYemegi.FlatAppearance.BorderSize = 0;
            this.btnOgleYemegi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOgleYemegi.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnOgleYemegi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnOgleYemegi.ImageIndex = 2;
            this.btnOgleYemegi.ImageList = this.ımageList1;
            this.btnOgleYemegi.KLCBackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnOgleYemegi.KLCBorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnOgleYemegi.KLCBorderRadius = 40;
            this.btnOgleYemegi.KLCBorderSize = 0;
            this.btnOgleYemegi.KLCTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnOgleYemegi.Location = new System.Drawing.Point(89, 269);
            this.btnOgleYemegi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnOgleYemegi.Name = "btnOgleYemegi";
            this.btnOgleYemegi.Size = new System.Drawing.Size(197, 124);
            this.btnOgleYemegi.TabIndex = 2;
            this.btnOgleYemegi.Tag = "2";
            this.btnOgleYemegi.Text = " Öğle Yemeği";
            this.btnOgleYemegi.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnOgleYemegi.UseVisualStyleBackColor = false;
            this.btnOgleYemegi.Click += new System.EventHandler(this.Interface_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "1c.jpg");
            this.ımageList1.Images.SetKeyName(1, "new din.jpg");
            this.ımageList1.Images.SetKeyName(2, "Newww.jpg");
            // 
            // btnKahvalti
            // 
            this.btnKahvalti.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnKahvalti.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnKahvalti.FlatAppearance.BorderSize = 0;
            this.btnKahvalti.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKahvalti.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnKahvalti.ImageIndex = 0;
            this.btnKahvalti.ImageList = this.ımageList1;
            this.btnKahvalti.KLCBackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnKahvalti.KLCBorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnKahvalti.KLCBorderRadius = 40;
            this.btnKahvalti.KLCBorderSize = 0;
            this.btnKahvalti.KLCTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnKahvalti.Location = new System.Drawing.Point(89, 119);
            this.btnKahvalti.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnKahvalti.Name = "btnKahvalti";
            this.btnKahvalti.Size = new System.Drawing.Size(197, 124);
            this.btnKahvalti.TabIndex = 1;
            this.btnKahvalti.Tag = "1";
            this.btnKahvalti.Text = " Kahvaltı";
            this.btnKahvalti.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnKahvalti.UseVisualStyleBackColor = false;
            this.btnKahvalti.Click += new System.EventHandler(this.Interface_Click);
            // 
            // btnAksamYemegi
            // 
            this.btnAksamYemegi.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnAksamYemegi.FlatAppearance.BorderSize = 0;
            this.btnAksamYemegi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAksamYemegi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnAksamYemegi.ImageIndex = 1;
            this.btnAksamYemegi.ImageList = this.ımageList1;
            this.btnAksamYemegi.KLCBackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnAksamYemegi.KLCBorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAksamYemegi.KLCBorderRadius = 40;
            this.btnAksamYemegi.KLCBorderSize = 0;
            this.btnAksamYemegi.KLCTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnAksamYemegi.Location = new System.Drawing.Point(89, 424);
            this.btnAksamYemegi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAksamYemegi.Name = "btnAksamYemegi";
            this.btnAksamYemegi.Size = new System.Drawing.Size(197, 124);
            this.btnAksamYemegi.TabIndex = 3;
            this.btnAksamYemegi.Tag = "3";
            this.btnAksamYemegi.Text = " Akşam Yemeği";
            this.btnAksamYemegi.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnAksamYemegi.UseVisualStyleBackColor = false;
            this.btnAksamYemegi.Click += new System.EventHandler(this.Interface_Click);
            // 
            // Ogunler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 657);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Ogunler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AVOCADO";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfil)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.PictureBox pbBack;
        public KLCToolbox.KLCControls.KLCDatePicker dtpDate;
        public KLCToolbox.KLCControls.KLCCircularPictureBox pbProfil;
        public KLCToolbox.KLCControls.KLCButton btnOgleYemegi;
        public KLCToolbox.KLCControls.KLCButton btnKahvalti;
        public KLCToolbox.KLCControls.KLCButton btnAksamYemegi;
        private KLCToolbox.KLCControls.KLCButton btnOgunEkle;
    }
}