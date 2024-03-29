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

namespace RegistroDePersona
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=hacknetwork\SQLEXPRESS;Initial Catalog=DBpersona;Integrated Security=True");
            conn.Open();
            string query = "INSERT INTO Persona (nombre, edad, celular) VALUES (@nombre,@edad,@celular)";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@nombre", nombre_insertar.Text);
            cmd.Parameters.AddWithValue("@edad", int.Parse(edad_insertar.Text));
            cmd.Parameters.AddWithValue("@celular", celular_insertar.Text);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Datos insertados exitosamente");
        }


    }
}
