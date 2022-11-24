using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace alta_doctor
{
    public partial class Form1 : Form
    {
        DataClasses1DataContext contexto = new DataClasses1DataContext();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Cargar datos del listado de  hospitales
            var datos = from h in contexto.HOSPITAL
                        select h.NOMBRE;
            this.cmbHospital.DataSource = datos;
            this.cmbHospital.DisplayMember= "NOMBRE";
        }

        private void cmbHospital_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            string datoHospital = this.cmbHospital.SelectedValue.ToString();
            // var datos = from d in contexto.DOCTOR;
            string datoDoctor = txtDoctorNumero.Text.ToString();
            string datoApellido = txtApellido.Text.ToString();
            string datoEspecialidad = txtEspecialidad.Text.ToString();
            int datoSalario = int.Parse(txtSalario.Text.ToString());

            this.contexto.ALTADOCTOR2(datoHospital, datoDoctor, datoApellido, datoEspecialidad, datoSalario);
            
            this.DialogResult = DialogResult.OK;

        }
    }
}
