using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlvaroGonzalezSQL
{
    
    public class Job
    {
        private int id;
        public int Id { get => id; set => id = value; }

        private string nombre;
        public string Nombre { get => nombre; set => nombre = value; }

        private decimal maxSalary;
        public decimal MaxSalary { get => maxSalary; set => maxSalary = value; }

        private decimal minSalary;
        public decimal MinSalary { get => minSalary; set => minSalary = value; }
        

        public Job(int id, string nombre, decimal max, decimal min)
        {
            this.id = id;
            this.nombre = nombre;
            maxSalary = max;
            minSalary = min;
        }

        public override string ToString()
        {
            return "ID: " + id.ToString() + " Job Name: " + nombre + " Min Salary: " + minSalary.ToString() + " Max Salary: " + maxSalary.ToString();
        }



    }
}
