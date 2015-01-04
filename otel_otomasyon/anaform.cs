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
    public partial class anasayfa : Form
    {
        yenimusteri yenimusteri; 
        mevcutmusteri mevcutmusteri;
        aramaislmleriformu musteriarama;
     
        odaislemleri odalar;
       
     /* AÇIKLAMALAR-1: Metotların üzerinde ki açıklama numarasına göre nerede ne yapılmış daha kolay çözebilirsiniz.
            * Burada İstenilen form açılıyor ayrıca bir kaç ekleme yaptık.
            * Açılan form sadece Konteynırın içinde açıla bilmesi için MdiParent ı kullandık şartı sağlıyorsa formu açıyor.
            * Sağlamıyorsa formu yenide açmıyor odaklanıyor.*/

        void yenimusterikaydi(){
            //AÇIKLAMALAR-1

            if (yenimusteri == null || yenimusteri.IsDisposed)
            {
                yenimusteri = new yenimusteri();
                yenimusteri.MdiParent = this;
                yenimusteri.Show();
            }
            else
            {
                yenimusteri.Focus();
            }
                    }
        void mevcutmusteriler()
        {
            //AÇIKLAMALAR-1

          if (mevcutmusteri == null || mevcutmusteri.IsDisposed)
            {
                mevcutmusteri = new mevcutmusteri();
                mevcutmusteri.MdiParent = this;
                mevcutmusteri.Show();
            }
            else
            {
                mevcutmusteri.Focus();
            }
        }
        void musteriaramalar()
        {
            //AÇIKLAMALAR-1

            if (musteriarama == null || musteriarama.IsDisposed)
            {
                musteriarama = new aramaislmleriformu();
                musteriarama.MdiParent = this;
                musteriarama.Show();
            }
            else
            {
                musteriarama.Focus();

            }
        }

        public anasayfa()
        {
            InitializeComponent();
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Çıkış Yapacaksınız Eminmisiniz?", "Çıkış İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Stop) == DialogResult.Yes)
            {
                Application.Exit();
            }

           }

        private void yeniMüşteriGirişiToolStripMenuItem_Click(object sender, EventArgs e)
        {

            yenimusterikaydi();
            
        }

        private void mevcutOlanMüşterilerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mevcutmusteriler();
        
        }

        private void müşteriAramaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            musteriaramalar();
                    }

                            
                private void anasayfa_Load(object sender, EventArgs e)
        {
           
                 

                 
                }

                private void odalarToolStripMenuItem_Click(object sender, EventArgs e)
                {
                    if (odalar == null || odalar.IsDisposed)
                    {
                        odalar = new odaislemleri();
                        odalar.MdiParent = this;
                        odalar.Show();
                    }
                    else
                    {
                        odalar.Focus();
                    }
                }

                private void anasayfa_FormClosed(object sender, FormClosedEventArgs e)
                {
                    if (MessageBox.Show("Çıkış Yapacaksınız Eminmisiniz?", "Çıkış İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Stop) == DialogResult.Yes)
                    {
                        Application.Exit();
                    }
                }
                     
        }
             
    }

