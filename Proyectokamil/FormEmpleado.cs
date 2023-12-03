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
    public partial class FormEmpleado : Form
    {
        public FormEmpleado()
        {
            InitializeComponent();
        }

        private void FormEmpleado_Load(object sender, EventArgs e)
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

        private void button1_Click_1(object sender, EventArgs e)
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
            cmd1.ExecuteNonQuery();

            MessageBox.Show("Los datos Fueron Agregados con exito");

            dataGridView1.DataSource = llenar_grid();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Conexion.conectar();

            string actualizar = "UPDATE Empleados  SET nombre=@nombre, apellidoPaterno=@apellidoPaterno, apellidoMaterno=@apellidoMaterno, fechaNacimiento=@fechaNacimiento, RFC=@RFC, idPuesto=@idPuesto, descripcionPuesto=@descripcionPuesto, Directivo=@Directivo";

            SqlCommand cmd2 = new SqlCommand(actualizar, Conexion.conectar());

            cmd2.Parameters.AddWithValue("@nombre", txtnombre.Text);
            cmd2.Parameters.AddWithValue("@apellidoPaterno", txtnombre.Text);
            cmd2.Parameters.AddWithValue("@apellidoMaterno", txtnombre.Text);
            cmd2.Parameters.AddWithValue("@fechaNacimiento", txtnombre.Text);
            cmd2.Parameters.AddWithValue("@RFC", txtnombre.Text);
            cmd2.Parameters.AddWithValue("@idPuesto", txtnombre.Text);
            cmd2.Parameters.AddWithValue("@descripcionPuesto", txtnombre.Text);
            cmd2.Parameters.AddWithValue("@Directivo", txtnombre.Text);

            cmd2.ExecuteNonQuery();
            MessageBox.Show("Los datos fueron actualizados Exitosamente");
            dataGridView1.DataSource = llenar_grid();

        }

        private void Datagrid(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                txtnombre.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                txtapellidoPaterno.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                txtapellidoMaterno.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                txtfechaNacimiento.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                txtRFC.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                txtidPuesto.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                txtdescripcionPuesto.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                txtdirectivo.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();



            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Conexion.conectar();
            string eliminar = "DELETE  FROM Empleado WHERE nombre=@nombre";
            SqlCommand cmd3 = new SqlCommand(eliminar, Conexion.conectar());
            cmd3.Parameters.AddWithValue("@nombre", txtnombre.Text);
            cmd3.ExecuteNonQuery();
            MessageBox.Show("Los datos fueron eliminados con exito");
            dataGridView1.DataSource = llenar_grid();
        }
    }
}
