using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlvaroGonzalezHospital
{
    public class Paciente : Persona
    {
        //enefermedad que tienen
        private string enfermedad;
        public string Enfermedad { get => enfermedad; set => enfermedad = value; }
        
        private Medico medicoAsociado;
        public Medico MedicoAsociado
        {
            get{
                return medicoAsociado;
            }
            set
            {
                if (MuestraExistentes.medicos.Contains(value))
                    medicoAsociado = value;
            }
        }
           


        public Paciente(string nombre, string apellido, string enfermedad, Medico medicoAsociado) : base(nombre, apellido)
        {
            this.Enfermedad = enfermedad;
            this.medicoAsociado = medicoAsociado;
        }


    }
}
