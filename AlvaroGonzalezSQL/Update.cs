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
    public partial class Update : Form
    {
        private Job trabajo;
        public Job Trabajo { get => trabajo; set => trabajo = value; }

        public Update(Job trabajo)
        {
            this.trabajo = trabajo;
            InitializeComponent();
        }

        

        private void cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Update_Load(object sender, EventArgs e)
        {

            jobTitle1.Text = trabajo.Nombre;
            minSalary1.Value = trabajo.MinSalary;
            maxSalary1.Value = trabajo.MaxSalary;

        }

        private void submit_Click(object sender, EventArgs e)
        {
            try
            {
                string job_title = jobTitle1.Text;
                decimal max_salary = minSalary1.Value;
                decimal min_salary = maxSalary1.Value;

                string cadena = "UPDATE jobs SET job_title  = @jobTitle, min_salary = @min, max_salary = @max " +
                    "WHERE job_id = " + trabajo.Id;
                SqlCommand comando = new SqlCommand(cadena, BaseDeDatosForm.conexion);


                //Introducimos parametros
                SqlParameter pJobTitle = new SqlParameter("@jobTitle", SqlDbType.VarChar, 50);
                pJobTitle.Value = job_title;
                comando.Parameters.Add(pJobTitle);

                SqlParameter pMax = new SqlParameter("@max", SqlDbType.Decimal);
                pMax.Value = max_salary;
                comando.Parameters.Add(pMax);

                SqlParameter pMin = new SqlParameter("@min", SqlDbType.Decimal);
                pMin.Value = min_salary;
                comando.Parameters.Add(pMin);

                comando.ExecuteNonQuery();
                MessageBox.Show("Updated");
                BaseDeDatosForm.listaTrabajos.Clear();
                Close();
            }
            catch (Exception error)
            {
                MessageBox.Show("Error abriendo: " + error.Message);
            }
        }
    }
}
