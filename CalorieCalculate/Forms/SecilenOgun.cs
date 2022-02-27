using CalorieCalculate.Crud;
using CalorieCalculate.Model.Data;
using CalorieCalculate.Model.Entities;
using CalorieCalculate.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalorieCalculate.Forms
{

    public partial class SecilenOgun : Form
    {
        private DatabaseContext _db = new DatabaseContext();
        private Repast repast;
        private User user;
        BindingList<YemekDTO> yemekDTOList;
        BindingList<YenenYemekDTO> lst;
        public SecilenOgun()
        {
            InitializeComponent();
        }
        public SecilenOgun(Repast repast, User user)
        {
            InitializeComponent();
            this.repast = repast;
            this.user = user;
            lblOgunAdi.Text = repast.RepastName;
            lst = DataRead.RepastRaport(user, dgvOgun, repast.RepastName);
            yemekDTOList = DataRead.YemekListele();
        }
        // DataGridView den seçilen yemekler RepastMeal a eklenecek

        List<YemekDTO> _yemek = new List<YemekDTO>();
        private void Click(object sender, EventArgs e)
        {
            if (dgvOgun.Rows.Count != 0)
                dgvOgun.Rows.Clear();

            Button btn = (Button)sender;
            switch (btn.Tag.ToString())
            {
                case "1":
                    dgvOgun.DataSource = yemekDTOList;
                    break;
                case "2":
                    //Sil();
                    break;
                case "3":
                    Ekle();
                    break;

                    // Resim ekleme yapısı oluşturulduğunda click event içerisine yazılacak kod, resim yolu aynı zamanda RepastMeals içerisinde Image kısmına aktarılarak 
                    /*
                    pbYemek.SizeMode = PictureBoxSizeMode.StretchImage;
                    ofdPictureFile.ShowDialog();
                    string fileName = ofdPictureFile.FileName;
                    pbYemek.ImageLocation = fileName;
                    */
            }
        }

        private void pbBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvOgun_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dgvOgun.SelectedRows[0].Index;
            var yemek = dgvOgun.SelectedRows[0].DataBoundItem as YemekDTO;
            var listItem = yemekDTOList.FirstOrDefault(x => x.Id == yemek.Id);
            double portion;
            bool p = double.TryParse(txtPortion.KLCText, out portion);

            if (txtPortion.KLCText != "" && p)
            {
                listItem.Portion = portion;
            }
            else
            {
                listItem.Portion = 1;
            }

            dgvOgun.SelectedRows[0].Selected = false;
            dgvOgun.Rows[index].Selected = true;

            if (!_yemek.Contains(yemek))
            {
                _yemek.Add(listItem);
            }
            else
            {
                _yemek.Remove(listItem);
            }
        }
        private void Ekle()
        {
            string image = null;
            for (int i = 0; i < _yemek.Count; i++)
            {
                DataCreate.Create(repast, _yemek[i] , _yemek[i].Portion , image);
            }
        }

        //private void Sil()
        //{
        //    for (int i = 0; i < _yemek.Count; i++)
        //    {
        //        DataDelete.Delete(_yemek[i], repast);
        //    }
        //}

        private void dgvOgun_MouseClick(object sender, MouseEventArgs e)
        {
            int index = dgvOgun.SelectedRows[0].Index;
            var yemek = dgvOgun.SelectedRows[0].DataBoundItem as YenenYemekDTO;
            var yenenYemek = lst.FirstOrDefault(x => x.Id == yemek.Id);
            if (e.Button == MouseButtons.Right)
            {
                DataDelete.Delete(yenenYemek, repast);
            }
        }
    }
}
