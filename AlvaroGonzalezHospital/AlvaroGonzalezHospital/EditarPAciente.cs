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
    public partial class EditarPAciente : Form
    {
        private Paciente pacienteSeleccionado;
        public Paciente PacienteSeleccionado { get => pacienteSeleccionado; set => pacienteSeleccionado = value; }
        public EditarPAciente(Paciente paciente)
        {

            
            InitializeComponent();
            this.PacienteSeleccionado = paciente;

        }

        private void cancelEditPAciente_Click(object sender, EventArgs e)
        {
            MuestraExistentes.personasHospital.Remove(pacienteSeleccionado);
            Close();
        }

        private void submitEditPaciente_Click(object sender, EventArgs e)
        {
            MuestraExistentes.personasHospital.Remove(pacienteSeleccionado);
            MuestraExistentes.personasHospital.Add(new Paciente(nombrePacienteEdit.Text, apellidoPAcienteEdit.Text, dolorPacienteEdit.Text, (Medico)MedicoAsociadoEdit.SelectedItem));
            
            MessageBox.Show("PAciente editado correctamente");
            Close();
        }

        private void EditarPAciente_Load(object sender, EventArgs e)
        {
            foreach (Persona per in MuestraExistentes.personasHospital)
            {
                if (per is Medico)
                    MedicoAsociadoEdit.Items.Add(per);
            }





            nombrePacienteEdit.Text = PacienteSeleccionado.Nombre;
            apellidoPAcienteEdit.Text = PacienteSeleccionado.Apellido;
            dolorPacienteEdit.Text = PacienteSeleccionado.Enfermedad;
            MedicoAsociadoEdit.SelectedItem = PacienteSeleccionado.MedicoAsociado;

            //MuestraExistentes.personasHospital.Remove(MedicoSeleccionado);
        }
    }
}
