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
        string gtarih, ctarih,odaturu; int sonmusteriid, sonodaid;
        bool kontrol= false;
      
        public yenimusteri()
        {
            InitializeComponent();
        }

        public void listelemeişlemi()
        {
            
                DataTable veriler = new DataTable();
                
                try
                {

                    baglantiayarlari.baglan();

                    SqlCommand komut = new SqlCommand("SELECT TOP 10 m.TCKimlik,(m.Ad+' '+m.Soyad) as [Ad Soyad],h.GirisTarihi,h.CikisTarihi,o.isim,m.Telefon from musteriler as m left join hangiodadakimvar as h on m.ID=h.MusteriID left join odalar as o on o.ID=h.OdaID where m.TCKimlik='" + tckimliknokutu.Text + "'", baglantiayarlari.bagla);

                    SqlDataAdapter tablo = new SqlDataAdapter(komut);

                    tablo.Fill(veriler);

                    //eklenenkisilerebak.Items.Clear();

                    for (int i = 0; i < veriler.Rows.Count; i++)
                    {
                        DataRow satir = veriler.Rows[i];

                        if (satir.RowState != DataRowState.Deleted)
                        {
                            ListViewItem item = new ListViewItem(satir["TCKimlik"].ToString());
                            item.SubItems.Add(satir["Ad Soyad"].ToString());
                            item.SubItems.Add(String.Format("{0:dd.MM.yyyy}",satir["GirisTarihi"]));
                            item.SubItems.Add(String.Format("{0:dd.MM.yyyy}",satir["CikisTarihi"]));
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
        public void odanumaralari() {

         //s   odanokutu.Items.Add("Eklenecek Veri");
        }
            
        public void kalacakgun()
        {

            if (kalacaksurekutu.Text.Length > 0)
            {
                TimeSpan tarih = new TimeSpan(int.Parse(kalacaksurekutu.Text), 0, 0, 0);
                DateTime yeni = giristarihikutu.Value + tarih;
                cikistarihikutu.Value = yeni;
            }

                
            
            
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
         
        }

        public void mevcutmusteritckontrolu()
        {
            if (tckimliknokutu.Text.Length== 11)
            {
                
                baglantiayarlari.baglan();

                SqlCommand komut = new SqlCommand("SELECT * from musteriler where TCKimlik='" + tckimliknokutu.Text + "'", baglantiayarlari.bagla);             
                
                SqlDataReader oku = komut.ExecuteReader();
              
                if (oku.Read())
                {
                    kontrol = true;
                    sonmusteriid = Convert.ToInt32(oku["ID"]);
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
        public void dahaoncevarolanmusteriekleme(int sonmusteriid)
        {
            try
            {
                baglantiayarlari.baglan();

                gtarih = giristarihikutu.Value.ToString("yyyy-MM-dd");
                ctarih = cikistarihikutu.Value.ToString("yyyy-MM-dd");

                SqlCommand odakomut = new SqlCommand("update odalar set durum='Dolu' where isim='" + odanokutu.Text + "", baglantiayarlari.bagla);//'select scope_identity()"
               //sonodaid = Convert.ToInt32(odakomut.ExecuteScalar());
                odakomut.ExecuteNonQuery();
                SqlCommand odadurumkomut = new SqlCommand("INSERT INTO hangiodadakimvar (MusteriID, GirisTarihi,CikisTarihi) values (@musteriid, @giristarihi,@cikistarihi)", baglantiayarlari.bagla);
                //odadurumkomut.Parameters.AddWithValue("@odaid", sonodaid);
                odadurumkomut.Parameters.AddWithValue("@musteriid", sonmusteriid);
                odadurumkomut.Parameters.AddWithValue("@giristarihi", gtarih);
                odadurumkomut.Parameters.AddWithValue("@cikistarihi", ctarih);

                odadurumkomut.ExecuteNonQuery();

                baglantiayarlari.baglanma();
                MessageBox.Show("Müşteri Kayıt İşlemi Gerçekleşti.");
            }
            catch (SqlException hata)
            {
                MessageBox.Show(hata.Message);
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



                SqlCommand odakomut = new SqlCommand("update odalar set durum='Dolu' where isim='" + odanokutu.Text + "'select scope_identity()", baglantiayarlari.bagla);
                sonodaid = Convert.ToInt32(odakomut.ExecuteScalar());
             

                
                SqlCommand odadurumkomut = new SqlCommand("INSERT INTO hangiodadakimvar (OdaID, MusteriID, GirisTarihi,CikisTarihi) values (@odaid, @musteriid, @giristarihi,@cikistarihi)", baglantiayarlari.bagla);
                odadurumkomut.Parameters.AddWithValue("@odaid", sonodaid);
                odadurumkomut.Parameters.AddWithValue("@musteriid", sonmusteriid);
                odadurumkomut.Parameters.AddWithValue("@giristarihi", gtarih);
                odadurumkomut.Parameters.AddWithValue("@cikistarihi", ctarih);
                odadurumkomut.ExecuteNonQuery();

                baglantiayarlari.baglanma();
                MessageBox.Show("Müşteri Kayıt İşlemi Gerçekleşti.");
                

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
            if (kontrol==false)
            {
                yenimusterikaydi();
            }
            else
            {
                dahaoncevarolanmusteriekleme(sonmusteriid);
            }
            listelemeişlemi();
            panelitemizle();
        }

        private void kalacaksurekutu_TextChanged(object sender, EventArgs e)
        {
            kalacakgun();
        }

        private void tckimliknokutu_TextChanged(object sender, EventArgs e)
        {
            mevcutmusteritckontrolu();
        }

        private void odaturukutu_SelectedIndexChanged(object sender, EventArgs e)
        {
            odaturu=odaturukutu.Text.ToString();
           
            if (odaturu=="2")
            {

            }
            else if (odaturu=="3")
            {
                
            }
        }

        private void guncellebutonu_Click(object sender, EventArgs e)
        {
            listelemeişlemi();
        }
               
       
                      
    }
}
