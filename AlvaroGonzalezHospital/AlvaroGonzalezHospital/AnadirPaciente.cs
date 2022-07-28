using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlvaroGonzalezHospital
{
    public partial class AnadirPaciente : Form
    {
        public AnadirPaciente()
        {
            InitializeComponent();
        }

        private void submitAddPaciente_Click(object sender, EventArgs e)
        {
            if (MedicoAsociado.SelectedItem == null)
            {
                MessageBox.Show("Incluya un Codigo de médico existente");
                return;
            }
            MuestraExistentes.personasHospital.Add(new Paciente(nombrePacienteAdd.Text, apellidoPAcienteAdd.Text, dolorPacienteAdd.Text, (Medico)MedicoAsociado.SelectedItem));
            MessageBox.Show("PAciente añadido");
            Close();
            



            
        }

        private void cancelAddPAciente_Click(object sender, EventArgs e)
        {
            Close();
        }

        

        private void AnadirPaciente_Load(object sender, EventArgs e)
        {
            foreach (Persona per in MuestraExistentes.personasHospital)
            {
                if (per is Medico)
                    MedicoAsociado.Items.Add(per);
            }
        }

        
    }
}
