using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formulario_crud
{
    public partial class FormModificar : Form
    {
        doctorDataContext contexto = new doctorDataContext();
        public FormModificar()
        {
            InitializeComponent();
        }

        private void FormModificar_Load(object sender, EventArgs e)
        {
            var datosApe = from d in contexto.DOCTOR
                           select new { d.APELLIDO, d.DOCTOR_NO };

            this.comboBox1.DataSource = datosApe;
            this.comboBox1.DisplayMember = "APELLIDO";
            this.comboBox1.ValueMember = "DOCTOR_NO";
        }

        
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string d_hospital = this.txtHospital.Text;
            string d_numero = this.comboBox1.SelectedValue.ToString();
            string d_apellido = this.txtApellido.Text;
            string d_especialidad = this.txtEspecialidad.Text;
            int d_salario = int.Parse(this.txtSalario.Text);
            this.contexto.MODIFICARDOCTOR(d_hospital, d_numero, d_apellido, d_especialidad, d_salario);

            this.DialogResult= DialogResult.OK;
        }

    }
}
