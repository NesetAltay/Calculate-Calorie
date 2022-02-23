
namespace CalorieCalculate.Forms
{
    partial class OturumAc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OturumAc));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lnkKayitOl = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.btnGirisYap = new KLCToolbox.KLCControls.KLCButton();
            this.label3 = new System.Windows.Forms.Label();
            this.klcToggleButton1 = new KLCToolbox.KLCControls.KLCToggleButton();
            this.txtEmail = new KLCToolbox.KLCControls.KLCTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPassword = new KLCToolbox.KLCControls.KLCTextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lnkKayitOl);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnGirisYap);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.klcToggleButton1);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtPassword);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(379, 664);
            this.panel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(143, 580);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 53);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // lnkKayitOl
            // 
            this.lnkKayitOl.AutoSize = true;
            this.lnkKayitOl.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lnkKayitOl.LinkColor = System.Drawing.Color.OrangeRed;
            this.lnkKayitOl.Location = new System.Drawing.Point(143, 539);
            this.lnkKayitOl.Name = "lnkKayitOl";
            this.lnkKayitOl.Size = new System.Drawing.Size(81, 20);
            this.lnkKayitOl.TabIndex = 22;
            this.lnkKayitOl.TabStop = true;
            this.lnkKayitOl.Text = "Kayıt Ol";
            this.lnkKayitOl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkKayitOl_LinkClicked);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(78, 488);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 20);
            this.label4.TabIndex = 25;
            this.label4.Text = "Beni Hatırla";
            // 
            // btnGirisYap
            // 
            this.btnGirisYap.BackColor = System.Drawing.Color.OrangeRed;
            this.btnGirisYap.FlatAppearance.BorderSize = 0;
            this.btnGirisYap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGirisYap.ForeColor = System.Drawing.Color.Black;
            this.btnGirisYap.KLCBackgroundColor = System.Drawing.Color.OrangeRed;
            this.btnGirisYap.KLCBorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnGirisYap.KLCBorderRadius = 24;
            this.btnGirisYap.KLCBorderSize = 0;
            this.btnGirisYap.KLCTextColor = System.Drawing.Color.Black;
            this.btnGirisYap.Location = new System.Drawing.Point(186, 455);
            this.btnGirisYap.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGirisYap.Name = "btnGirisYap";
            this.btnGirisYap.Size = new System.Drawing.Size(109, 41);
            this.btnGirisYap.TabIndex = 21;
            this.btnGirisYap.Text = "Giriş Yap";
            this.btnGirisYap.UseVisualStyleBackColor = false;
            this.btnGirisYap.Click += new System.EventHandler(this.btnGirisYap_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(91, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(203, 213);
            this.label3.TabIndex = 23;
            this.label3.Text = "AVOCADO Tarafından geliştirilen ücretsiz Kalori Sayacı Uygulaması ile yiyecek gün" +
    "lüğünü yönetebilir ve başarıyla kilo verebilirsin. Kalori saymak ve kilo vermek " +
    "hiç bu kadar kolay olmamıştı!";
            // 
            // klcToggleButton1
            // 
            this.klcToggleButton1.AutoSize = true;
            this.klcToggleButton1.KLCOffBackColor = System.Drawing.Color.Pink;
            this.klcToggleButton1.KLCOffToggleColor = System.Drawing.Color.OrangeRed;
            this.klcToggleButton1.KLCOnBackColor = System.Drawing.Color.SeaGreen;
            this.klcToggleButton1.KLCOnToggleColor = System.Drawing.Color.MediumSeaGreen;
            this.klcToggleButton1.Location = new System.Drawing.Point(78, 455);
            this.klcToggleButton1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.klcToggleButton1.MinimumSize = new System.Drawing.Size(51, 29);
            this.klcToggleButton1.Name = "klcToggleButton1";
            this.klcToggleButton1.Size = new System.Drawing.Size(51, 29);
            this.klcToggleButton1.TabIndex = 24;
            this.klcToggleButton1.UseVisualStyleBackColor = true;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.SystemColors.Window;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEmail.ForeColor = System.Drawing.Color.DimGray;
            this.txtEmail.KLCBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.txtEmail.KLCBorderFocusColor = System.Drawing.Color.OrangeRed;
            this.txtEmail.KLCBorderRadius = 0;
            this.txtEmail.KLCBorderSize = 2;
            this.txtEmail.KLCMultiline = false;
            this.txtEmail.KLCPasswordChar = false;
            this.txtEmail.KLCPlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtEmail.KLCPlaceholderText = "";
            this.txtEmail.KLCText = "";
            this.txtEmail.KLCUnderlinedStyle = false;
            this.txtEmail.Location = new System.Drawing.Point(78, 329);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Padding = new System.Windows.Forms.Padding(11, 9, 11, 9);
            this.txtEmail.Size = new System.Drawing.Size(217, 39);
            this.txtEmail.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(78, 301);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "E-mail :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(78, 376);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "Şifre :";
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.SystemColors.Window;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPassword.ForeColor = System.Drawing.Color.DimGray;
            this.txtPassword.KLCBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.txtPassword.KLCBorderFocusColor = System.Drawing.Color.OrangeRed;
            this.txtPassword.KLCBorderRadius = 0;
            this.txtPassword.KLCBorderSize = 2;
            this.txtPassword.KLCMultiline = false;
            this.txtPassword.KLCPasswordChar = false;
            this.txtPassword.KLCPlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtPassword.KLCPlaceholderText = "";
            this.txtPassword.KLCText = "";
            this.txtPassword.KLCUnderlinedStyle = false;
            this.txtPassword.Location = new System.Drawing.Point(78, 404);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Padding = new System.Windows.Forms.Padding(11, 9, 11, 9);
            this.txtPassword.Size = new System.Drawing.Size(217, 39);
            this.txtPassword.TabIndex = 17;
            // 
            // OturumAc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 664);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OturumAc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AVOCADO";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel lnkKayitOl;
        private System.Windows.Forms.Label label4;
        private KLCToolbox.KLCControls.KLCButton btnGirisYap;
        private System.Windows.Forms.Label label3;
        private KLCToolbox.KLCControls.KLCToggleButton klcToggleButton1;
        private KLCToolbox.KLCControls.KLCTextBox txtEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private KLCToolbox.KLCControls.KLCTextBox txtPassword;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}