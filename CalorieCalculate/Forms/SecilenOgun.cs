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
        public SecilenOgun()
        {
            InitializeComponent();
        }
        BindingList<YemekDTO> yemekDTOList;
        public SecilenOgun(Repast repast, User user)
        {
            InitializeComponent();
            this.repast = repast;
            this.user = user;
            lblOgunAdi.Text = repast.RepastName;
            DataRead.RepastRaport(user, dgvOgun, repast.RepastName);
            yemekDTOList = DataRead.YemekListele();
            
            for (int i = 0; i < yemekDTOList.Count; i++)
            {
                if (dgvOgun.Bounds.Contains(MousePosition))
                {
                    string result = _db.Meals.Where(x => x.MealName.Equals(yemekDTOList[i].MealName)).Select(x => x.MealDescription).ToString();
                    dgvOgun.Columns["MealName"].ToolTipText = result;

                 }
            }
        }
        // DataGridView den seçilen yemekler RepastMeal a eklenecek

        List<string> _yemek = new List<string>();
        private void Click(object sender, EventArgs e)
        {
            if (dgvOgun.Rows.Count != 0)
                dgvOgun.Rows.Clear();

            Button btn = (Button)sender;
            switch (btn.Tag.ToString())
            {
                case "1":
                    //KolonDuzeni();
                    dgvOgun.DataSource = yemekDTOList;
                    break;
                case "2":

                    //DataDelete.Delete(, user);
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
            int indext = e.RowIndex;
            int index = dgvOgun.SelectedRows[0].Index;
            var yemek = dgvOgun.SelectedRows[0].DataBoundItem as YemekDTO;
            var listItem = yemekDTOList.FirstOrDefault(x => x.Id == yemek.Id);
            ///istItem.Portion = double.Parse(dgvOgun[2, indext].Value).ToString(); //yeni forma parametre olarak listitem gönder nud dan değeri al 5 yerine güncelle .
            dgvOgun.SelectedRows[0].Selected = false;
            dgvOgun.Rows[index].Selected = true;
            _yemek.Add(yemek.MealName);
            string image = null;

            if (!_yemek.Contains(yemek.MealName))
            {
                DataCreate.Create(repast, listItem, listItem.Portion, image);
            }

        }
    }
}
