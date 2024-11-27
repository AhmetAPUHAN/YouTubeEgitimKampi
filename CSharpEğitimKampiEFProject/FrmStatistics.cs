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
    public partial class FrmStatistics : Form
    {
        public FrmStatistics()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        EgitimKampiEFTravelDbEntities db = new EgitimKampiEFTravelDbEntities();
        private void FrmStatistics_Load(object sender, EventArgs e)
        {
          lblLocationCount.Text=db.TBLLocations.Count().ToString(); 
            lblKapasite.Text=db.TBLLocations.Sum(x=>x.Capacity).ToString(); 
            lblRehberSayısı.Text=db.TBLGuides.Count().ToString(); 
            lblOrtalamaKapasite.Text=db.TBLLocations.Average(x=> x.Capacity).ToString();
        lblOrtalamaFiyat.Text=db.TBLLocations.Average(x=>x.Price).ToString();
            int lastCountryId = db.TBLLocations.Max(x => x.LocationId);
            lblSonÜlke.Text=db.TBLLocations.Where(x=>x.LocationId==lastCountryId).Select(y=>y.Country).FirstOrDefault();
            lblKapadokya.Text = db.TBLLocations.Where(x => x.City == "Kapadokya").Select(y => y.Capacity).FirstOrDefault().ToString();
            lblTurkiyeOrt.Text = db.TBLLocations.Where(x => x.Country == "Türkiye").Average(y => y.Capacity).ToString();
            var romeGuideId = db.TBLLocations.Where(x => x.City == "Roma").Select(y => y.GuideId).FirstOrDefault();
            lblRomaGuide.Text = db.TBLGuides.Where(x => x.GuideId == romeGuideId).Select(y => y.Name + " " + y.Surname).FirstOrDefault().FirstOrDefault().ToString();
        var maxCapacity=db.TBLLocations.Max(x=>x.Capacity);
            lblMaxCapa.Text = db.TBLLocations.Where(x => x.Capacity == maxCapacity).Select(y => y.City).FirstOrDefault().ToString();
            var maxPrice = db.TBLLocations.Max(x => x.Price);
            lblPahalı.Text=db.TBLLocations.Where(x=>x.Price==maxPrice).Select(y=>y.City).FirstOrDefault().ToString();
            var GuideIdByAliBahar = db.TBLGuides.Where(x => x.Name == "Ali" && x.Surname == "Bahar").Select(y => y.GuideId).FirstOrDefault();
            lblAli.Text = db.TBLLocations.Where(x => x.GuideId == GuideIdByAliBahar).Count().ToString(); 

        }

        
    }
}
