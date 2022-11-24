using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace alta_doctor
{
    public partial class FormBaja : Form
    {
        DataClasses1DataContext contexto = new DataClasses1DataContext();
        public FormBaja()
        {
            InitializeComponent();
        }

        private void txtNumeroDoctor_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormBaja_Load(object sender, EventArgs e)
        {
            var datos = from d in contexto.DOCTOR
                        select new { d.APELLIDO, d.DOCTOR_NO } ;
            this.cmbDoctor.DataSource = datos;
            this.cmbDoctor.DisplayMember = "APELLIDO";
            this.cmbDoctor.ValueMember = "DOCTOR_NO";           
        }

        private void cmbDoctor_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            string datoDoctor = cmbDoctor.SelectedValue.ToString(); // Número del doctor seleccionado
            this.contexto.BAJADOCTOR(datoDoctor);
            this.DialogResult = DialogResult.OK;

        }
    }
}
