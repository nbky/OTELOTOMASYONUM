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
            bagla = new SqlConnection("Data Source=PC\\SA; Initial Catalog=OtelOtomasyonu;user id =sa;Password=1234; Integrated Security=true");

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
