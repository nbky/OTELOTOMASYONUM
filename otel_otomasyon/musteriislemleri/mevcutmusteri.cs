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
    public partial class mevcutmusteri : Form
    {
        yenimusteri yenimusteriler;
       

        public mevcutmusteri()
        {
            InitializeComponent();
        }
       
        public void musteribilgidoldurma()
        {
           

            DataTable veriler = new DataTable();

            musteribilgiformu.View = View.Details;
            musteribilgiformu.Columns.Clear();
            musteribilgiformu.Columns.Add("T.C. Kimlik Numarası", 150, HorizontalAlignment.Center);
            musteribilgiformu.Columns.Add("Adı Soyadı", 100, HorizontalAlignment.Center);
            musteribilgiformu.Columns.Add("Giriş Tarihi", 100, HorizontalAlignment.Left);
            musteribilgiformu.Columns.Add("Çıkış Tarihi", 100, HorizontalAlignment.Left);
            musteribilgiformu.Columns.Add("Oda Numarası", 100, HorizontalAlignment.Center);
            musteribilgiformu.Columns.Add("Telefon Numarası", 100, HorizontalAlignment.Center);

            try
            {

                baglantiayarlari.baglan();
               
                yenimusteriler = new yenimusteri();

      
                
                SqlCommand komut = new SqlCommand("SELECT TOP 1 m.TCKimlik,(m.Ad+' '+m.Soyad) as [Ad Soyad],h.GirisTarihi,h.CikisTarihi,o.isim,m.Telefon from musteriler as m left join hangiodadakimvar as h on m.ID=h.MusteriID left join odalar as o on o.ID=h.OdaID where o.durum='Dolu' and o.isim=@odaisim", baglantiayarlari.bagla);
                komut.Parameters.AddWithValue("@odaisim",yenimusteriler.odanokutu.SelectedText);
               
                SqlDataAdapter tablo = new SqlDataAdapter(komut);

                tablo.Fill(veriler);


                musteribilgiformu.Items.Clear();

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
                        musteribilgiformu.Items.Add(item);
                    }
                }
               
                 baglantiayarlari.baglanma();
                 MessageBox.Show(yenimusteriler.odanokutu.SelectedText);
            }
            catch (SqlException hata)
            {
                MessageBox.Show(hata.Message);
            }

        }

        private void mevcutmusteri_Load(object sender, EventArgs e)
        {
         
            musteribilgidoldurma();
        }
    }
}
