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
    class baglantiayarlari
    {
        public static SqlConnection bagla;

        public static void baglan()
        {
            bagla = new SqlConnection("Data Source=localhost; Initial Catalog=OtelOtomasyon;user id =nbky-Bilgisayar\nbky;Password=''; Integrated Security=true");

            if (bagla.State == ConnectionState.Closed)
            {
                bagla.Open();
            }
        }
       
        public static void baglanma()
        {
            bagla.Close();
        }


    }
}
