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
    
    
    public partial class kullanicigirisi : Form
    {
        anasayfa anaform;
     
        public kullanicigirisi()
        {
            InitializeComponent();
        }

        private void girisbutonu_Click(object sender, EventArgs e)
        {
            kullanicigirisi giris = new kullanicigirisi();
            giris.Close();
           
            anaform = new anasayfa(); 
            anaform.Show();
            anaform.Focus();
            this.Hide();
            
     
        }
    }
}
