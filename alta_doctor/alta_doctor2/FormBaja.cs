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
    public partial class FormBaja : Form
    {
        doctorDataContext contexto = new doctorDataContext();
        public FormBaja()
        {
            InitializeComponent();
        }

        private void FormBaja_Load(object sender, EventArgs e)
        {
            var datosApe = from d in contexto.DOCTOR
                        select new { d.APELLIDO, d.DOCTOR_NO };

            this.cmbApellidos.DataSource= datosApe;
            this.cmbApellidos.DisplayMember= "APELLIDO";
            this.cmbApellidos.ValueMember= "DOCTOR_NO";                  
            

        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            string docEle = this.cmbApellidos.SelectedValue.ToString();
            this.contexto.BAJADOCTOR(docEle);
            this.DialogResult= DialogResult.OK;
            
        }
    }
}
