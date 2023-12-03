using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Drawing;

namespace ProyectoKamil
{
    class Conexion
    {
        public static SqlConnection conectar()
        {
            SqlConnection cn = new SqlConnection("SERVER=DESKTOP-6GRGUBO\\SQLEXPRESS;DATABASE=Kamil;integrated security=true");
            cn.Open();
            return cn;


        }


    }
}

