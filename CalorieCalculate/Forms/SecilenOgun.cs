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
        List<YenenYemekDTO> _yenenYemekDTOList;
        BindingList<YemekDTO> _secilenYemekler;
        BindingList<YenenYemekDTO> _silinecekYemekler;
        BindingList<YenenYemekDTO> _guncellemeList;
        string _dosyaYolu = default;
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
            _yenenYemekDTOList = DataRead.RepastRaport(user, dgvOgun, repast.RepastName);
            yemekDTOList = DataRead.YemekListele();
            _secilenYemekler = new BindingList<YemekDTO>();
            _silinecekYemekler = new BindingList<YenenYemekDTO>();
            _guncellemeList = new BindingList<YenenYemekDTO>();
        }
        private void SecilenOgun_Load(object sender, EventArgs e)
        {
            if (_yenenYemekDTOList != null)
            {
                dgvOgun.DataSource = new BindingList<YenenYemekDTO>(_yenenYemekDTOList);
            }
        }
        private void btnListe_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            switch (btn.Tag.ToString())
            {
                case "1":
                    dgvOgun.DataSource = yemekDTOList;
                    break;
                case "2":
                    YemekSil();
                    break;
                case "3":
                    YemekEkle();
                    break;
                case "4":
                    PorsiyonGuncelle();
                    break;
            }
        }

        private void PorsiyonGuncelle()
        {
            for (int i = 0; i < _guncellemeList.Count; i++)
            {
                DataUpdate.Update(user, repast, _guncellemeList[i]);
            }
        }

        private void YemekSil()
        {
            for (int i = 0; i < _silinecekYemekler.Count; i++)
            {
                DataDelete.Delete(user, _silinecekYemekler[i], repast);
            }
        }

        private void YemekEkle()
        {
            for (int i = 0; i < _secilenYemekler.Count; i++)
            {
                DataCreate.Create(repast, _secilenYemekler[i], _secilenYemekler[i].Portion, _dosyaYolu);
            }
        }

        private void Guncelleme(int id)
        {
            if (_yenenYemekDTOList != null)
            {
                YenenYemekDTO guncellenecekYemek = _yenenYemekDTOList.Where(x => x.Id.Equals(id)).FirstOrDefault();

                if (guncellenecekYemek != null)
                {
                    double porsiyon;
                    bool pors = double.TryParse(txtPortion.KLCText, out porsiyon);

                    if (String.IsNullOrEmpty(txtPortion.KLCText) || !pors)
                    { guncellenecekYemek.EatenPortion = 1; }

                    else { guncellenecekYemek.EatenPortion = (float)porsiyon; }

                    if (!_guncellemeList.Contains(guncellenecekYemek))
                    { _guncellemeList.Add(guncellenecekYemek); }

                    else { _guncellemeList.Remove(guncellenecekYemek); }
                }
            }
        }

        private void SilinecekYemekListesi(int id)
        {
            if (_yenenYemekDTOList != null)
            {
                var silinecelYemek = _yenenYemekDTOList.Where(x => x.Id.Equals(id)).FirstOrDefault();

                if (silinecelYemek != null)
                {
                    if (!_silinecekYemekler.Contains(silinecelYemek))
                    { _silinecekYemekler.Add(silinecelYemek); }
                    else { _silinecekYemekler.Remove(silinecelYemek); }
                }
            }
        }

        private void SecilenYemekListesi(int id)
        {
            var secilenYemek = yemekDTOList.Where(x => x.Id.Equals(id)).FirstOrDefault();

            double porsiyon;
            bool pors = double.TryParse(txtPortion.KLCText, out porsiyon);

            if (String.IsNullOrEmpty(txtPortion.KLCText) || !pors)
            { secilenYemek.Portion = 1; }
            else { secilenYemek.Portion = porsiyon; }

            if (!_secilenYemekler.Contains(secilenYemek))
            { _secilenYemekler.Add(secilenYemek); }
            else { _secilenYemekler.Remove(secilenYemek); }
        }

        private void pbBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvOgun_CellMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            int id = int.Parse(dgvOgun[0, rowIndex].Value.ToString());
            if (e.Button.Equals(MouseButtons.Left))
            {
                SecilenYemekListesi(id);
                SilinecekYemekListesi(id);
                Guncelleme(id);
            }
        }

        private void dgvOgun_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            int rowIndex = e.RowIndex;

            if ((e.ColumnIndex == this.dgvOgun.Columns["Id"].Index) && e.Value != null)
            {
                int id = int.Parse(dgvOgun[0, rowIndex].Value.ToString());
                DataGridViewCell cell = dgvOgun.Rows[rowIndex].Cells[e.ColumnIndex];
                cell.ToolTipText = DataRead.MealDescription(id);
            }
        }
    }
}
