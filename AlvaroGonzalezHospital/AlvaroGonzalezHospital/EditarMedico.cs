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
    public partial class EditarMedico : Form
    {
        private Medico medicoSeleccionado;
        public Medico MedicoSeleccionado { get => medicoSeleccionado; set => medicoSeleccionado = value; }

        public EditarMedico(Medico medicoSeleccionado)
        {
            InitializeComponent();

            this.MedicoSeleccionado = medicoSeleccionado;
        }

        

        private void EditarMedico_Load(object sender, EventArgs e)
        {

            nombreMedicoEdit.Text = MedicoSeleccionado.Nombre;
            apellidoMedicoEdit.Text = MedicoSeleccionado.Apellido;
            codMedicoEdit.Text = MedicoSeleccionado.CodigoMedico.ToString();
            


        }

        private void submitAddMedico_Click(object sender, EventArgs e)
        {
            MuestraExistentes.personasHospital.Remove(MedicoSeleccionado);
            MuestraExistentes.personasHospital.Add(new Medico(nombreMedicoEdit.Text, apellidoMedicoEdit.Text, Int32.Parse(codMedicoEdit.Text)));
            MessageBox.Show("Medico editado correctamente");
            Close();
        }

        private void cancelAddMedico_Click(object sender, EventArgs e)
        {
            MuestraExistentes.personasHospital.Remove(MedicoSeleccionado);
            Close();
        }
    }
}
