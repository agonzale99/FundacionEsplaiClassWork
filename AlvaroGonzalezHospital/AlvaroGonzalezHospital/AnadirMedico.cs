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
    public partial class AnadirMedico : Form
    {
        public AnadirMedico()
        {
            InitializeComponent();
        }

        private void cancelAddMedico_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void submitAddMedico_Click(object sender, EventArgs e)
        {
            MuestraExistentes.personasHospital.Add(new Medico(nombreMedicoAdd.Text, apellidoMedicoAdd.Text, Int32.Parse(codMedicoAdd.Text)));
            MessageBox.Show("Medico añadido correctamente");
            Close();
        }
    }
}
