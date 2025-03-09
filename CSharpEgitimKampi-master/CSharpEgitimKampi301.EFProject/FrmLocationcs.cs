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
    public partial class FrmLocationcs : Form
    {
        public FrmLocationcs()
        {
            InitializeComponent();
        }

        EgitimKampiEfTravelDbEntities db=new EgitimKampiEfTravelDbEntities();
        private void BtnList_Click(object sender, EventArgs e)
        {
            var values=db.Location.ToList();
            dataGridView1.DataSource = values;
        }

        private void FrmLocationcs_Load(object sender, EventArgs e)
        {
            var values =db.Guide.Select(x=> new
            {
                FullName =x.GuideName+" "+ x.GuideSurname,
                x.GuideId
            }).ToList();
            CbmRehber.DisplayMember = "FullName";
            CbmRehber.ValueMember = "GuideId";
            CbmRehber.DataSource = values;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            Location location = new Location();
            location.Capacity=byte.Parse(NmrUpDwnKapasite.Value.ToString());
            location.City=TxtSehir.Text;
            location.Countr=TxtUlke.Text;
            location.Price=decimal.Parse(TxtFiyat.Text);
            location.DayNight=TxtGunGece.Text;
            location.GuideId=int.Parse(CbmRehber.SelectedValue.ToString());
            db.Location.Add(location);
            db.SaveChanges();
            MessageBox.Show("Ekleme İşlemi Başarılı");
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            int id=int.Parse(TxtId.Text);
            var deletedValue =db.Location.Find(id);
            db.Location.Remove(deletedValue);
            db.SaveChanges();
            MessageBox.Show("Silme İşlemi Başarılı");
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            int id =int.Parse(TxtId.Text);
            var updatedValue = db.Location.Find(id);
            updatedValue.DayNight =TxtGunGece.Text;
            updatedValue.Price=decimal.Parse(TxtFiyat.Text);
            updatedValue.Capacity=byte.Parse(NmrUpDwnKapasite.Value.ToString());
            updatedValue.Countr=TxtUlke.Text;
            updatedValue.GuideId=int.Parse(CbmRehber.SelectedValue.ToString());
            db.SaveChanges();
            MessageBox.Show("Güncelleme İşlemi Başarılı");
        }
    }
}
