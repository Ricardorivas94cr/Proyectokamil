using ProyectoKamil;
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

namespace Proyectokamil
{
    public partial class Formulario_Directivos : Form
    {
        public Formulario_Directivos()
        {
            InitializeComponent();
        }

        private void Formulario_Directivos_Load(object sender, EventArgs e)
        {
            Conexion.conectar();
            MessageBox.Show("Conexion Exitosa");
            dataGridView1.DataSource = llenar_grid();
        }

        public DataTable llenar_grid()
        {
            Conexion.conectar();
            DataTable dt = new DataTable();
            string consulta = "SELECT*FROM Directivos";
            SqlCommand cmd = new SqlCommand(consulta, Conexion.conectar());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }
    }
}
