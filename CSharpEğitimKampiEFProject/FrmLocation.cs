using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpEğitimKampiEFProject
{
    public partial class FrmLocation : Form
    {
        public FrmLocation()
        {
            InitializeComponent();
        }

        EgitimKampiEFTravelDbEntities db = new EgitimKampiEFTravelDbEntities();

        private void btnLİstele_Click(object sender, EventArgs e)
        {
            var values = db.TBLLocations.ToList();
            dataGridView1.DataSource = values;

        }

        private void FrmLocation_Load(object sender, EventArgs e)
        {
            var values = db.TBLGuides.Select(x => new
            {
                FullName = x.Name + " " + x.Surname,
                x.GuideId
            }).ToList();
            cmbRehber.DisplayMember = "FullName";
            cmbRehber.ValueMember = "GuideId";
            cmbRehber.DataSource = values;
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
           TBLLocation location = new TBLLocation();
            location.Capacity=byte.Parse(numericUpDown1.Value.ToString());
            location.City=txtSehir.Text;
            location.Country=txtÜlke.Text;
            location.Price = decimal.Parse(txtFiyat.Text);
            location.DayNight = txtGünGece.Text;
            location.GuideId=int.Parse(cmbRehber.SelectedValue.ToString());
            db.TBLLocations.Add(location);
            db.SaveChanges();
            MessageBox.Show("Ekleme Başarılı");

        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            int id=int.Parse(txtId.Text);
            var deletedValue = db.TBLLocations.Find(id);
            db.TBLLocations.Remove(deletedValue);
            db.SaveChanges() ;
            MessageBox.Show("Silme İşlemi Başarılı");

        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var updatedValue = db.TBLLocations.Find(id);
            updatedValue.DayNight = txtGünGece.Text;
            updatedValue.Price=decimal.Parse(txtFiyat.Text);
            updatedValue.Capacity = byte.Parse(numericUpDown1.Value.ToString());
            updatedValue.City=txtSehir.Text;
            updatedValue.Country=txtÜlke.Text;
            updatedValue.GuideId = int.Parse(cmbRehber.SelectedValue.ToString());
            db.SaveChanges();
            MessageBox.Show("Güncelleme İşlemi Başarılı");

        }
    }
}