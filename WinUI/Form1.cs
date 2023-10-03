using DAL;
using Entities;

namespace WinUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Context db;
        private void Form1_Load(object sender, EventArgs e)
        {
            db = new Context();
            rdbErkek.Checked = true;
            btnTemizle.Enabled = false;
            btniletisimBilgisi.Enabled = db.Personeller.ToList().Count > 0 ? true : false;

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if(Metotlar.BosAlanVarMi(grpPersonelKayit))
            {
                MessageBox.Show("Lütfen Boş Alan Bırakmayınız.");
            }
            else
            {
                Personel personel = db.Personeller.FirstOrDefault(x => x.TCKimlikNo == txtTCNo.Text);
                if(personel == null)
                {
                    personel = new Personel()
                    {
                        Isim = txtAd.Text,
                        Soyisim = txtSoyad.Text,
                        TCKimlikNo = txtTCNo.Text,
                        DogumTarihi = dtDogumTarihi.Value,
                        Cinsiyet = rdbErkek.Checked,
                        Birim = cmbBirim.Text
                    };
                    db.Personeller.Add(personel);
                    db.SaveChanges();
                    btnTemizle.Enabled = btniletisimBilgisi.Enabled = true;
                    MessageBox.Show("Personel Başarıyla Eklendi");
                }
                else
                {
                    MessageBox.Show("Aynı TcNo ile Personel Ekleyemezsiniz");
                }
            }
        }
    }
}