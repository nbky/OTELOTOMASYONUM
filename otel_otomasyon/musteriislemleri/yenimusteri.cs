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
        odaislemleri odaislem;
        string gtarih, ctarih,odaturu; int sonmusteriid, sonodaid;
        bool kontrol= false, doluoda=false;
        
      

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
      
        public void kalacakgun()
        {

            if (kalacaksurekutu.Text.Length > 0)
            {
                TimeSpan tarih = new TimeSpan(int.Parse(kalacaksurekutu.Text), 0, 0, 0);
                DateTime yeni = giristarihikutu.Value + tarih;
                cikistarihikutu.Value = yeni;
            }
           
        }
       
        public void odadurumguncelle() 
        {
            SqlCommand odadurumuguncelleme = new SqlCommand("update odalar set durum='Dolu' where isim='" + odanokutu.SelectedText + "'", baglantiayarlari.bagla);
            odadurumuguncelleme.ExecuteNonQuery();    
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
        
        public void dolubosodakontrolu()
        {

         //Dolu ve girilen odayı burada kontrol ettirmek istemiştim. odanakutunun text ini de denedim Selectedtext nide denedim
            //Bir türlü mevcutmusteribilgileri formunda yakalatamadım içindeki degeri hep boş döndü orada
         
            baglantiayarlari.baglan();

            SqlCommand komut = new SqlCommand("select * from odalar where  durum ='Dolu' and isim='"+odanokutu.SelectedText+"'", baglantiayarlari.bagla);
            
            SqlDataReader oku = komut.ExecuteReader();

            if (oku.Read())
            {
                           
                doluoda = true;
            }
            
            else {

                doluoda = false;
            }


            baglantiayarlari.baglanma();
        }
       
        public void doluodalar()
        {
            //deneme amaçlı 201 nolu odanın rengini değiştirdim hapsi için ayrı ayrı yapacaktım sizin yaptınığızı uyarlayamadım :( 
            odaislem = new odaislemleri();   
            
            if (doluoda==false)
	         {
		         odaislem.oda201.BackColor=Color.Green;
             }
          
           else
            {
                odaislem.oda201.BackColor=Color.Red;
       
            }
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

                SqlCommand odakomut = new SqlCommand("INSERT INTO odalar (isim,limit) values (@isim,@limit) select scope_identity()", baglantiayarlari.bagla);
                odakomut.Parameters.AddWithValue("@isim", odanokutu.Text);
                odakomut.Parameters.AddWithValue("@limit", odaturukutu.Text);
                sonodaid = Convert.ToInt32(odakomut.ExecuteScalar());

                odadurumguncelle();

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
                                      
                
                SqlCommand odakomut = new SqlCommand("INSERT INTO odalar (isim,limit) values (@isim,@limit) select scope_identity()", baglantiayarlari.bagla);
                odakomut.Parameters.AddWithValue("@isim", odanokutu.Text);
                odakomut.Parameters.AddWithValue("@limit", odaturukutu.Text);
                sonodaid = Convert.ToInt32(odakomut.ExecuteScalar());

                odadurumguncelle();

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
        private void temizlebutonu_Click(object sender, EventArgs e)
        {
            panelitemizle();
            eklenenkisilerebak.Clear(); 
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
           
            dolubosodakontrolu();
            doluodalar();
            listelemeişlemi();
         // panelitemizle();
            odaislem.Show();
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
    }
}
