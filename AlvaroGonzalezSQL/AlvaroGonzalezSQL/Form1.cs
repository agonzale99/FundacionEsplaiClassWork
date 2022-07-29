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

namespace AlvaroGonzalezSQL
{
    public partial class BaseDeDatosForm : Form
    {
        public static SqlConnection conexion = new SqlConnection("Data source = 185.166.215.109,54321; Initial Catalog = AlvaroEmployees; " +
                "Persist Security Info = True; User Id = sa; Password = 123456789");

        public static List<Job> listaTrabajos = new List<Job>();
        public BaseDeDatosForm()
        {
            InitializeComponent();
        }

        private void ConectarServidor_Click(object sender, EventArgs e)
        {
            try
            {
                

                conectarServidor.Enabled = false;
                insertarValor.Enabled = true;
                cerrarConexionGlobal.Enabled = true;
                jobTitle.Enabled = true;
                maxSalary.Enabled = true;
                minSalary.Enabled = true;
                listaDeSelects.Enabled = true;
                deleteList.Enabled = true;
                deletePrueba.Enabled = true;
                conexion.Open();

                MessageBox.Show("Se abrió correctamente");
            }
            catch (Exception error)
            {
                MessageBox.Show("Error abriendo: " + error.Message);
            }
            
            RefreshList();
        }

        private void cerrarConexionGlobal_Click(object sender, EventArgs e)
        {
            conectarServidor.Enabled = true;
            insertarValor.Enabled = false;
            cerrarConexionGlobal.Enabled = false;
            jobTitle.Enabled = false;
            maxSalary.Enabled = false;
            minSalary.Enabled = false;
            listaDeSelects.Enabled = false;
            deleteList.Enabled = false;
            deletePrueba.Enabled = false;
            listaDeSelects.Items.Clear();
            conexion.Close();

        }

        private void insertarValor_Click(object sender, EventArgs e)
        {
            try
            {
                string job_title = jobTitle.Text;
                decimal max_salary = maxSalary.Value;
                decimal min_salary = minSalary.Value;

                string cadena = "INSERT INTO jobs(job_title, min_salary, max_salary) values ('" + job_title + "', "
                    + min_salary + ", " + max_salary + ")";

                SqlCommand comando = new SqlCommand(cadena, conexion);
                comando.ExecuteNonQuery();
                
  
            }
            catch(Exception error)
            {
                MessageBox.Show("Error abriendo: " + error.Message);
            }
            RefreshList();
        }

        private static void consulta()
        {
            try
            {
                string cadena = "SELECT * FROM jobs";
                SqlCommand comando = new SqlCommand(cadena, conexion);
                SqlDataReader registros = comando.ExecuteReader();
                while (registros.Read())
                {
                    listaTrabajos.Add(new Job((int)registros["job_id"], (string)registros["job_title"], (decimal)registros["min_salary"],
                        (decimal)registros["max_salary"]));
                }
                registros.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show("Error abriendo: " + error.Message);
            }

        }

        

        private void BaseDeDatosForm_Load(object sender, EventArgs e)
        {
            
        }

        public void RefreshList()
        {
            consulta();
            listaDeSelects.Items.Clear();
            deleteList.Items.Clear();
            foreach (Job j in listaTrabajos)
            {
                listaDeSelects.Items.Add(j);
                deleteList.Items.Add(j);
            }
            
            
        }

        private void deletePrueba_Click(object sender, EventArgs e)
        {
            if (deleteList.SelectedItem == null)
            {
                MessageBox.Show("Por favor seleccione un job");
                return; 
            }
            try
            {
                Job j = (Job)deleteList.SelectedItem;
                string cadena = "DELETE from jobs where job_id = " + j.Id;
                SqlCommand comando = new SqlCommand(cadena, conexion);
                comando.ExecuteNonQuery();
                listaTrabajos.Remove(j);
                MessageBox.Show("Eliminado");
                RefreshList();
            }
            catch (Exception error)
            {
                MessageBox.Show("Error abriendo: " + error.Message);
            }
            
                

        }

        private void pruebaUpdate_Click(object sender, EventArgs e)
        {
            Form f = new Update((Job)deleteList.SelectedItem);
            f.ShowDialog();

        }
    }
}
