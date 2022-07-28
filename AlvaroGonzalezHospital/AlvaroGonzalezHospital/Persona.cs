using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlvaroGonzalezHospital
{
    public class Persona
    {
        //Nombre
        private string nombre;
        public string Nombre { get => nombre; set => nombre = value; }
        
        //Apellido
        private string apellido;
        public string Apellido { get => apellido; set => apellido = value; }

        public Persona(string nombre, string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }



        //ToString
        public override string ToString()
        {
            return nombre + " " + apellido;
        }



    }
}
