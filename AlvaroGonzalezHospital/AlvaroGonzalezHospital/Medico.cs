using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlvaroGonzalezHospital
{
    public class Medico : Persona
    {
        //Codigo del Medico 
        private int codigoMedico;       
        public int CodigoMedico { get => codigoMedico; set => codigoMedico = value; }
        
        //Especialidad
        private string especialidad;
        public string Especialidad { get => especialidad; set => especialidad = value; }

        //Constructor
        public Medico(string nombre, string apellido, int codigoMedico) : base(nombre, apellido)
        {
            this.codigoMedico = codigoMedico;
        }

        





    }
}
