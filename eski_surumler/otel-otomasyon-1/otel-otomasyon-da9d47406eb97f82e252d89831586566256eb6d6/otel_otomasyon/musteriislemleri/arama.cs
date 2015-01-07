using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace otel_otomasyon
{
    public partial class aramaislmleriformu : Form
    {
        string aramakutu;

        public aramaislmleriformu()
        {
            InitializeComponent();
        }
        public void kututemizle() {
            
            hizliaramakutu.Clear();

        }
     
        public void MusteriArama()
        {
            DataTable veriler = new DataTable();
            musteribilgileri.View = View.Details;
            musteribilgileri.Columns.Clear();
            musteribilgileri.Columns.Add("T.C. Kimlik Numarası",150,HorizontalAlignment.Center);
            musteribilgileri.Columns.Add("Adı Soyadı",100,HorizontalAlignment.Center);
            musteribilgileri.Columns.Add("Giriş Tarihi",100,HorizontalAlignment.Left);
            musteribilgileri.Columns.Add("Çıkış Tarihi",100,HorizontalAlignment.Left);
            musteribilgileri.Columns.Add("Oda Numarası", 100, HorizontalAlignment.Center);
            musteribilgileri.Columns.Add("Telefon Numarası",100, HorizontalAlignment.Center);
           
        try
           
              {

               baglantiayarlari.baglan();

                aramakutu = hizliaramakutu.Text.ToString();
                
                SqlCommand komut = new SqlCommand("SELECT TOP 10 m.TCKimlik,(m.Ad+' '+m.Soyad) as [Ad Soyad],h.GirisTarihi,h.CikisTarihi,o.isim,m.Telefon from musteriler as m left join hangiodadakimvar as h on m.ID=h.MusteriID left join odalar as o on o.ID=h.OdaID where m.TCKimlik='"+aramakutu+"'",baglantiayarlari.bagla);

                SqlDataAdapter tablo = new SqlDataAdapter(komut);

                tablo.Fill(veriler);

                musteribilgileri.Items.Clear();

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
                        musteribilgileri.Items.Add(item);
                    }
                }

              baglantiayarlari.baglanma();

            }
            catch (SqlException hata)
            {
                MessageBox.Show(hata.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MusteriArama();
        }

        private void hizliaramakutu_MouseDown(object sender, MouseEventArgs e)
        {
            kututemizle();
        }

        private void aramakategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            gelismisaramakutu.Focus();
        }

        private void hizliaramakutu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                MusteriArama();
            }
        }

      
                     
    }
      
    }

