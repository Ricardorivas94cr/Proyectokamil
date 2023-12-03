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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Conexion.conectar();
            MessageBox.Show("Conexion Exitosa");
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Conexion.conectar();
            string insertar = "INSERT INTO Empleados(nombre,apellidoPaterno,apellidoMaterno,fechaNacimiento,RFC,idPuesto,descripcionPuesto,directivo) VALUES (@nombre,@apellidoPaterno,@apellidoMaterno,@fechaNacimiento,@RFC,@idPuesto,@descripcionPuesto,@directivo)";
            SqlCommand cmd1 = new SqlCommand(insertar, Conexion.conectar());
            cmd1.Parameters.AddWithValue("@nombre", txtnombre.Text);
            cmd1.Parameters.AddWithValue("@apellidoPaterno", txtapellidoPaterno.Text);
            cmd1.Parameters.AddWithValue("@apellidoMaterno", txtapellidoMaterno.Text);
            cmd1.Parameters.AddWithValue("@fechaNacimiento", txtfechaNacimiento.Text);
            cmd1.Parameters.AddWithValue("@RFC", txtRFC.Text);
            cmd1.Parameters.AddWithValue("@idPuesto", txtidPuesto.Text);
            cmd1.Parameters.AddWithValue("@descripcionPuesto", txtdescripcionPuesto.Text);
            cmd1.Parameters.AddWithValue("@directivo", txtdirectivo.Text);
        }
    }
}
