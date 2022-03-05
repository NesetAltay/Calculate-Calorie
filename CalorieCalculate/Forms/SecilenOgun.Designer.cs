
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtPortion = new KLCToolbox.KLCControls.KLCTextBox();
            this.pbBack = new System.Windows.Forms.PictureBox();
            this.lblOgunAdi = new System.Windows.Forms.Label();
            this.dgvOgun = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnEkle = new KLCToolbox.KLCControls.KLCButton();
            this.btnSil = new KLCToolbox.KLCControls.KLCButton();
            this.btnListe = new KLCToolbox.KLCControls.KLCButton();
            this.ofdPictureFile = new System.Windows.Forms.OpenFileDialog();
            this.klcButton1 = new KLCToolbox.KLCControls.KLCButton();
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
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtPortion);
            this.panel1.Controls.Add(this.pbBack);
            this.panel1.Controls.Add(this.lblOgunAdi);
            this.panel1.Controls.Add(this.dgvOgun);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnEkle);
            this.panel1.Controls.Add(this.klcButton1);
            this.panel1.Controls.Add(this.btnSil);
            this.panel1.Controls.Add(this.btnListe);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(379, 657);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Constantia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(3, 437);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 33);
            this.label1.TabIndex = 27;
            this.label1.Text = "Porsiyon";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPortion
            // 
            this.txtPortion.BackColor = System.Drawing.SystemColors.Window;
            this.txtPortion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPortion.ForeColor = System.Drawing.Color.DimGray;
            this.txtPortion.KLCBorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtPortion.KLCBorderFocusColor = System.Drawing.Color.HotPink;
            this.txtPortion.KLCBorderRadius = 0;
            this.txtPortion.KLCBorderSize = 2;
            this.txtPortion.KLCMultiline = false;
            this.txtPortion.KLCPasswordChar = false;
            this.txtPortion.KLCPlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtPortion.KLCPlaceholderText = "";
            this.txtPortion.KLCText = "";
            this.txtPortion.KLCUnderlinedStyle = false;
            this.txtPortion.Location = new System.Drawing.Point(129, 437);
            this.txtPortion.Margin = new System.Windows.Forms.Padding(4);
            this.txtPortion.Name = "txtPortion";
            this.txtPortion.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtPortion.Size = new System.Drawing.Size(250, 35);
            this.txtPortion.TabIndex = 26;
            // 
            // pbBack
            // 
            this.pbBack.BackColor = System.Drawing.Color.Transparent;
            this.pbBack.Image = ((System.Drawing.Image)(resources.GetObject("pbBack.Image")));
            this.pbBack.Location = new System.Drawing.Point(3, 0);
            this.pbBack.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pbBack.Name = "pbBack";
            this.pbBack.Size = new System.Drawing.Size(65, 45);
            this.pbBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBack.TabIndex = 24;
            this.pbBack.TabStop = false;
            this.pbBack.Tag = "4";
            this.pbBack.Click += new System.EventHandler(this.pbBack_Click);
            // 
            // lblOgunAdi
            // 
            this.lblOgunAdi.AutoSize = true;
            this.lblOgunAdi.BackColor = System.Drawing.Color.Silver;
            this.lblOgunAdi.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblOgunAdi.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblOgunAdi.Location = new System.Drawing.Point(14, 83);
            this.lblOgunAdi.Name = "lblOgunAdi";
            this.lblOgunAdi.Size = new System.Drawing.Size(80, 22);
            this.lblOgunAdi.TabIndex = 23;
            this.lblOgunAdi.Text = "OgunAdi";
            // 
            // dgvOgun
            // 
            this.dgvOgun.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOgun.Location = new System.Drawing.Point(0, 115);
            this.dgvOgun.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.dgvOgun.MultiSelect = false;
            this.dgvOgun.Name = "dgvOgun";
            this.dgvOgun.RowHeadersWidth = 51;
            this.dgvOgun.RowTemplate.Height = 25;
            this.dgvOgun.RowTemplate.ReadOnly = true;
            this.dgvOgun.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOgun.Size = new System.Drawing.Size(383, 313);
            this.dgvOgun.TabIndex = 3;
            this.dgvOgun.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvOgun_CellMouseClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(146, 604);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 53);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.OrangeRed;
            this.btnEkle.FlatAppearance.BorderSize = 0;
            this.btnEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEkle.ForeColor = System.Drawing.Color.Black;
            this.btnEkle.KLCBackgroundColor = System.Drawing.Color.OrangeRed;
            this.btnEkle.KLCBorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnEkle.KLCBorderRadius = 24;
            this.btnEkle.KLCBorderSize = 0;
            this.btnEkle.KLCTextColor = System.Drawing.Color.Black;
            this.btnEkle.Location = new System.Drawing.Point(194, 496);
            this.btnEkle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(173, 41);
            this.btnEkle.TabIndex = 2;
            this.btnEkle.Tag = "3";
            this.btnEkle.Text = "Gıda Ekle";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnListe_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.OrangeRed;
            this.btnSil.FlatAppearance.BorderSize = 0;
            this.btnSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSil.ForeColor = System.Drawing.Color.Black;
            this.btnSil.KLCBackgroundColor = System.Drawing.Color.OrangeRed;
            this.btnSil.KLCBorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnSil.KLCBorderRadius = 24;
            this.btnSil.KLCBorderSize = 0;
            this.btnSil.KLCTextColor = System.Drawing.Color.Black;
            this.btnSil.Location = new System.Drawing.Point(3, 496);
            this.btnSil.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(157, 41);
            this.btnSil.TabIndex = 2;
            this.btnSil.Tag = "2";
            this.btnSil.Text = "Gıda Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnListe_Click);
            // 
            // btnListe
            // 
            this.btnListe.BackColor = System.Drawing.Color.OrangeRed;
            this.btnListe.FlatAppearance.BorderSize = 0;
            this.btnListe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListe.ForeColor = System.Drawing.Color.Black;
            this.btnListe.KLCBackgroundColor = System.Drawing.Color.OrangeRed;
            this.btnListe.KLCBorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnListe.KLCBorderRadius = 24;
            this.btnListe.KLCBorderSize = 0;
            this.btnListe.KLCTextColor = System.Drawing.Color.Black;
            this.btnListe.Location = new System.Drawing.Point(286, 16);
            this.btnListe.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnListe.Name = "btnListe";
            this.btnListe.Size = new System.Drawing.Size(94, 41);
            this.btnListe.TabIndex = 1;
            this.btnListe.Tag = "1";
            this.btnListe.Text = "Gıda Listesi";
            this.btnListe.UseVisualStyleBackColor = false;
            this.btnListe.Click += new System.EventHandler(this.btnListe_Click);
            // 
            // ofdPictureFile
            // 
            this.ofdPictureFile.FileName = "openFileDialog1";
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
            this.klcButton1.Location = new System.Drawing.Point(3, 545);
            this.klcButton1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.klcButton1.Name = "klcButton1";
            this.klcButton1.Size = new System.Drawing.Size(157, 41);
            this.klcButton1.TabIndex = 2;
            this.klcButton1.Tag = "4";
            this.klcButton1.Text = "Güncelle";
            this.klcButton1.UseVisualStyleBackColor = false;
            this.klcButton1.Click += new System.EventHandler(this.btnListe_Click);
            // 
            // SecilenOgun
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
            this.Name = "SecilenOgun";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AVOCADO";
            this.Load += new System.EventHandler(this.SecilenOgun_Load);
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
        private KLCToolbox.KLCControls.KLCButton btnListe;
        private System.Windows.Forms.DataGridView dgvOgun;
        private System.Windows.Forms.Label lblOgunAdi;
        private System.Windows.Forms.PictureBox pbBack;
        private System.Windows.Forms.OpenFileDialog ofdPictureFile;
//=======
        private KLCToolbox.KLCControls.KLCButton Ekle;
        private System.Windows.Forms.Label label1;
        private KLCToolbox.KLCControls.KLCTextBox txtPortion;
        private KLCToolbox.KLCControls.KLCButton btnEkle;
        private KLCToolbox.KLCControls.KLCButton btnSil;
        private KLCToolbox.KLCControls.KLCButton klcButton1;
        //>>>>>>> d4e158d73931f2355e2c65dc17812d64cb7cc1df
    }
}