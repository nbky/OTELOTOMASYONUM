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
  
    public partial class odaislemleri : Form
    {

        yenimusteri yenimusteriler;
        mevcutmusteri musteribilgileri;
       
       public odaislemleri()
        {
            InitializeComponent();
        }
     

        private void oda201_Click(object sender, EventArgs e)
        {

            musteribilgileri = new mevcutmusteri();
            musteribilgileri.Show();
                    
        }

        private void odaislemleri_Load(object sender, EventArgs e)
        {
            yenimusteriler = new yenimusteri();
            yenimusteriler.doluodalar();
        }

              
    }
}
