using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace otel_otomasyon
{


    public partial class yenimusteri : Form
    {
        string gtarih, ctarih; int sonmusteriid, sonodaid;
        bool kontrol = false;
        public yenimusteri()
        {

            InitializeComponent();

        }
        public void listelemeişlemi()
        {
            {
                DataTable veriler = new DataTable();
                eklenenkisilerebak.View = View.Details;
                eklenenkisilerebak.Columns.Clear();
                eklenenkisilerebak.Columns.Add("T.C. Kimlik Numarası", 150, HorizontalAlignment.Center);
                eklenenkisilerebak.Columns.Add("Adı Soyadı", 100, HorizontalAlignment.Center);
                eklenenkisilerebak.Columns.Add("Giriş Tarihi", 100, HorizontalAlignment.Left);
                eklenenkisilerebak.Columns.Add("Çıkış Tarihi", 100, HorizontalAlignment.Left);
                eklenenkisilerebak.Columns.Add("Oda Numarası", 100, HorizontalAlignment.Center);
                eklenenkisilerebak.Columns.Add("Telefon Numarası", 100, HorizontalAlignment.Center);

                try
                {

                    baglantiayarlari.baglan();

                    SqlCommand komut = new SqlCommand("SELECT TOP 10 m.TCKimlik,(m.Ad+' '+m.Soyad) as [Ad Soyad],h.GirisTarihi,h.CikisTarihi,o.isim,m.Telefon from musteriler as m left join hangiodadakimvar as h on m.ID=h.MusteriID left join odalar as o on o.ID=h.OdaID where m.TCKimlik='" + tckimliknokutu.Text.ToString() + "'", baglantiayarlari.bagla);

                    SqlDataAdapter tablo = new SqlDataAdapter(komut);

                    tablo.Fill(veriler);

                    eklenenkisilerebak.Items.Clear();

                    for (int i = 0; i < veriler.Rows.Count; i++)
                    {
                        DataRow satir = veriler.Rows[i];

                        if (satir.RowState != DataRowState.Deleted)
                        {
                            ListViewItem item = new ListViewItem(satir["TCKimlik"].ToString());
                            item.SubItems.Add(satir["Ad Soyad"].ToString());
                            item.SubItems.Add(satir["GirisTarihi"].ToString());
                            item.SubItems.Add(satir["GirisTarihi"].ToString());
                            item.SubItems.Add(satir["isim"].ToString());
                            item.SubItems.Add(satir["Telefon"].ToString());
                            eklenenkisilerebak.Items.Add(item);
                        }
                    }

                    baglantiayarlari.baglanma();

                }
                catch (SqlException hata)
                {
                    MessageBox.Show(hata.Message);
                }

            }
        }
        public void kalacakgun()
        {
            TimeSpan tarih = new TimeSpan(int.Parse(kalacaksurekutu.Text), 0, 0, 0);
            DateTime yeni = giristarihikutu.Value + tarih;
            cikistarihikutu.Value = yeni;
        }

        public void panelitemizle()
        {
            tckimliknokutu.ResetText();
            adkutu.ResetText();
            soyadkutu.ResetText();
            telefonnokutu.ResetText();
            medenihal.ResetText();
            cinsiyetkutu.ResetText();
            odanokutu.ResetText();
            giristarihikutu.ResetText();
            cikistarihikutu.ResetText();
            kalacaksurekutu.ResetText();
            odaturukutu.ResetText();
            kalacaksurekutu.ResetText();

        }

        public void mevcutmusteritckontrolu()
        {
            if (tckimliknokutu.TextLength == 11)
            {                                     
                baglantiayarlari.baglan();

                SqlCommand komut = new SqlCommand("SELECT * from musteriler  where TCKimlik='" + tckimliknokutu.Text.ToString() + "'", baglantiayarlari.bagla);             
                
                SqlDataReader oku = komut.ExecuteReader();
              
                if (oku.Read())
                {
                     kontrol = true;
                    adkutu.Text = oku["Ad"].ToString();
                    soyadkutu.Text = oku["Soyad"].ToString();
                    telefonnokutu.Text = oku["Telefon"].ToString();
                    medenihal.Text = oku["Medenihal"].ToString();
                    cinsiyetkutu.Text = oku["Cinsiyet"].ToString();
                }
                else
                {
                    kontrol = false;
                }

                baglantiayarlari.baglanma();
            }
        }

        public void yenimusterikaydi()
        {
            try
            {
                baglantiayarlari.baglan();

                gtarih = giristarihikutu.Value.ToString("yyyy-MM-dd");
                ctarih = cikistarihikutu.Value.ToString("yyyy-MM-dd");

                SqlCommand musterikomut = new SqlCommand("INSERT INTO musteriler (TCKimlik,Ad,Soyad,Telefon,Cinsiyet,Medenihal) values (@TCKimlik,@Ad,@Soyad,@Telefon,@Cinsiyet,@Medenihal) select scope_identity()", baglantiayarlari.bagla);
                musterikomut.Parameters.AddWithValue("@TCKimlik", tckimliknokutu.Text);
                musterikomut.Parameters.AddWithValue("@Ad", adkutu.Text);
                musterikomut.Parameters.AddWithValue("@Soyad", soyadkutu.Text);
                musterikomut.Parameters.AddWithValue("@Telefon", telefonnokutu.Text);
                musterikomut.Parameters.AddWithValue("@Cinsiyet", cinsiyetkutu.Text);
                musterikomut.Parameters.AddWithValue("@Medenihal", medenihal.Text);

                sonmusteriid = Convert.ToInt32(musterikomut.ExecuteScalar());

                MessageBox.Show(sonmusteriid.ToString());
                
                
                SqlCommand odakomut = new SqlCommand("INSERT INTO odalar (isim,limit) values (@isim,@limit) select scope_identity()", baglantiayarlari.bagla);
                odakomut.Parameters.AddWithValue("@isim", odanokutu.Text);
                odakomut.Parameters.AddWithValue("@limit", odaturukutu.Text);
                sonodaid = Convert.ToInt32(odakomut.ExecuteScalar());



                SqlCommand odadurumkomut = new SqlCommand("INSERT INTO hangiodadakimvar (OdaID, MusteriID, GirisTarihi,CikisTarihi) values (@odaid, @musteriid, @giristarihi,@cikistarihi)", baglantiayarlari.bagla);
                odadurumkomut.Parameters.AddWithValue("@odaid", sonodaid);
                odadurumkomut.Parameters.AddWithValue("@musteriid", sonmusteriid);
                odadurumkomut.Parameters.AddWithValue("@giristarihi", gtarih);
                odadurumkomut.Parameters.AddWithValue("@cikistarihi", ctarih);
                odadurumkomut.ExecuteNonQuery();

                baglantiayarlari.baglanma();
                MessageBox.Show("Müşteri Kayıt İşlemi Gerçekleşti.(" + sonmusteriid.ToString() + ")");
                

            }
            catch (SqlException hata)
            {
                MessageBox.Show(hata.Message);
            }
            catch (InvalidCastException hata)
            {
                MessageBox.Show(hata.Message);
            }

        }

        private void yenimusteri_Load(object sender, EventArgs e)
        {

        }

        private void temizlebutonu_Click(object sender, EventArgs e)
        {
            panelitemizle();
        }

        private void kayitbutonu_Click(object sender, EventArgs e)
        {
            if (kontrol == false)
            {
                yenimusterikaydi();
                listelemeişlemi();
                panelitemizle();
            }
            else
            {
                dahaoncevarolanmusteriekleme(sonmusteriid);
                panelitemizle();
                listelemeişlemi();
            }
        }

        private void kalacaksurekutu_TextChanged(object sender, EventArgs e)
        {
            kalacakgun();
        }

        private void tckimliknokutu_TextChanged(object sender, EventArgs e)
        {
            mevcutmusteritckontrolu();
        }
    }
}
