using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpEgitimKampi301.EFProject
{
    public partial class FrmStatistics : Form
    {
        public FrmStatistics()
        {
            InitializeComponent();
        }

        EgitimKampiEfTravelDbEntities db= new EgitimKampiEfTravelDbEntities();

        private void FrmStatistics_Load(object sender, EventArgs e)
        {
            
            LblLocationCount.Text=db.Location.Count().ToString();

           LblSumCapacity.Text=db.Location.Sum(x=>x.Capacity).ToString();

            LblGuidecount.Text=db.Location.Count().ToString();
            LblAvgCapacity.Text=db.Location.Average(x=>x.Capacity).ToString();
            LblLocationAvgPrice.Text=db.Location.Average(x=> x.Price).ToString();
            int lastCounrtyId = db.Location.Max(x => x.LocationId);
            LblLastCountry.Text = db.Location.Where(x => x.LocationId == lastCounrtyId).Select(y => y.Countr).FirstOrDefault();

            LblKapadokya.Text=db.Location.Where(x=>x.City=="Kapadokya").Select(y => y.Capacity).FirstOrDefault().ToString();

            LblTurkiyeKapasite.Text=db.Location.Where(x=>x.Countr=="Türkiye").Average(y=>y.Capacity).ToString();

            var romeGuideId=db.Location.Where(x=> x.City =="Roma").Select(y=>y.GuideId).FirstOrDefault();
            LblRomaRehberIsmi.Text=db.Guide.Where(x=>x.GuideId==romeGuideId).Select(y=>y.GuideName +" "+ y.GuideSurname).FirstOrDefault();

            var maxCapacity=db.Location.Max(y=>y.Capacity);
            LblEnyüksekKapasiteliTur.Text=db.Location.Where(x=>x.Capacity==maxCapacity).Select(y=>y.City).FirstOrDefault().ToString();

            var maxPrice=db.Location.Max(x=>x.Price);
            LblEnPahalıTur.Text = db.Location.Where(x=>x.Price==maxPrice).Select(y=>y.City).FirstOrDefault().ToString();

            var minPrice = db.Location.Min(x => x.Price);
            LblEnUcuzTur.Text = db.Location.Where(x => x.Price == minPrice).Select(y => y.City).FirstOrDefault().ToString();
        }
    }
}
