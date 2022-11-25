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
    public partial class FormAlta : Form
    {
        doctorDataContext contexto = new doctorDataContext();
        public FormAlta()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void FormAlta_Load(object sender, EventArgs e)
        {

        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            string dato_hospital = this.txtHospital.Text;
            string dato_numero = this.txtNumero.Text;
            string dato_apellido = this.txtApellido.Text;
            string dato_especialidad = this.txtEspecialidad.Text;
            int dato_salario = int.Parse(this.txtSalario.Text);
            this.contexto.ALTADOCTOR(dato_hospital, dato_numero, dato_apellido, dato_especialidad, dato_salario);

            this.DialogResult= DialogResult.OK;

        }
    }
}
