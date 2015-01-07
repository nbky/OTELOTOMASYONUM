using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace otel_otomasyon
{ 
  
    public partial class odaislemleri : Form
    {

        yenimusteri yenimusteriler;
        mevcutmusteri musteribilgileri;
        public odaislemleri()
        {
            InitializeComponent();
        }
        void bosodayenimusterikaydi()// bos ise yeni musteri kaydı acılacak odaya tıklayınca
        {
            yenimusteriler = new yenimusteri();
            yenimusteriler.Show();
            yenimusteriler.Focus();
                     
        }
        void doluodamusteribilgileri()//dolu odaysa buradan tıklayınca musterılerın bılgılerı gelecek
        {
            musteribilgileri = new mevcutmusteri();
            musteribilgileri.Show();
            musteribilgileri.Focus();
        }
        void dolumubosmu()//bosluk doluluk kontrolu yapacam
        {
            
        }
         private void bosbuton201_Click(object sender, EventArgs e)
         {
             bosodayenimusterikaydi();
         }

        
        
    }
}
