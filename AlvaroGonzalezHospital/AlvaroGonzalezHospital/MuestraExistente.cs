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
    public partial class MuestraExistentes : Form
    {
        static public List<Medico> medicos = new List<Medico>();
        static public List<Paciente> pacientes = new List<Paciente>();
        static public List<Persona> personasHospital = new List<Persona>();

        public void CreadorListas()
        {
            medicos.AddRange(new List<Medico>
            {
                new Medico("Juan", "Garcia", 123),
                new Medico("Maria", "Fernandez", 124),
                new Medico("Alberto", "Gonzalez", 321),
            
            });

            pacientes.AddRange(new List<Paciente>
            {
                new Paciente("Guillermo", "Arias", "Cabeza", medicos[1]),
                new Paciente("Miguel", "Mayora", "Pie", medicos[0]),
                new Paciente("Valentina", "Perez", "Corazon", medicos[2]),
                new Paciente("Pedro", "Gutierrez", "Brazo", medicos[1]),
                new Paciente("Vanesa", "Suarez","Dolor de Alma", medicos[0]),

            });

            personasHospital.AddRange(pacientes);
            personasHospital.AddRange(medicos);
        }
        

        public MuestraExistentes()
        {
            InitializeComponent();
        }



        private void MuestraExistentes_Load(object sender, EventArgs e)
        {
            CreadorListas();
            UpdateLista();

        }

        private void agregarMedico_Click(object sender, EventArgs e)
        {
            Form f = new AnadirMedico();
            f.ShowDialog();
            
            UpdateLista();
        }

        private void addPaciente_Click(object sender, EventArgs e)
        {
            Form f = new AnadirPaciente();
            f.ShowDialog();
            UpdateLista();

        }

        private void deleteMedico_Click(object sender, EventArgs e)
        {
            if (ListaMedicos.SelectedItem == null)
            {
                MessageBox.Show("Seleccione el item que quiereeliminar");
                return;
            }

            personasHospital.Remove((Persona)ListaMedicos.SelectedItem);
            UpdateLista();

        }

        private void eliminarPaciente_Click(object sender, EventArgs e)
        {
            if (ListaPacientes.SelectedItem == null)
            {
                MessageBox.Show("Seleccione el item que quiereeliminar");
                return;
            }
            personasHospital.Remove((Persona)ListaPacientes.SelectedItem);
            UpdateLista();
        }

        private void modMedico_Click(object sender, EventArgs e)
        {
            if (ListaMedicos.SelectedItem == null)
            {
                MessageBox.Show("Seleccione el item que quiere editar");
                return;
            }
            Form f = new EditarMedico((Medico)ListaMedicos.SelectedItem);
            f.ShowDialog();
            UpdateLista();


        }

        private void UpdateLista()
        {
           
            ListaMedicos.Items.Clear();
            ListaPacientes.Items.Clear();
            foreach(Persona per in personasHospital)
            {
                if (per is Medico)
                    ListaMedicos.Items.Add(per);
                else if (per is Paciente)
                    ListaPacientes.Items.Add(per);
            }
        }

        private void editarPaciente_Click(object sender, EventArgs e)
        {
            if (ListaPacientes.SelectedItem == null)
            {
                MessageBox.Show("Seleccione el item que quiere editar");
                return;
            }
            Form f = new EditarPAciente((Paciente)ListaPacientes.SelectedItem);
            f.ShowDialog();
            UpdateLista();
        }
    }
}
