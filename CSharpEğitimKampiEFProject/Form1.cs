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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
EgitimKampiEFTravelDbEntities db=new EgitimKampiEFTravelDbEntities(); 
        private void btnLİstele_Click(object sender, EventArgs e)
        {
              
            var values=db.TBLGuides.ToList();
            dataGridView1.DataSource = values;

        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            TBLGuide guide=new TBLGuide();
           guide.Name=txtName.Text;
            guide.Surname=txtSurname.Text;
            db.TBLGuides.Add(guide);
            db.SaveChanges();
            MessageBox.Show("Rehber Başarıyla Eklendi.");
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            int id=int.Parse(txtId.Text);
            var removeValue = db.TBLGuides.Find(id);
            db.TBLGuides.Remove(removeValue);
            db.SaveChanges();
            MessageBox.Show("Rehber başarıyla silindi.");
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var updateValue = db.TBLGuides.Find(id);
            updateValue.Name=txtName.Text;
            updateValue.Surname = txtSurname.Text;
            db.SaveChanges();
            MessageBox.Show("Güncelleme Başarılı");
        }

        private void BtnGetById_Click(object sender, EventArgs e)
        {
            int id= int.Parse(txtId.Text);
            var values = db.TBLGuides.Where(x => x.GuideId == id).ToList();
            dataGridView1.DataSource = values;
        }
    }
}
