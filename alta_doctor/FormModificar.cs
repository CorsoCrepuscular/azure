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
    public partial class FormModificar : Form
    {
        DataClasses1DataContext contexto = new DataClasses1DataContext();
        public FormModificar()
        {
            InitializeComponent();
        }

        private void FormModificar_Load(object sender, EventArgs e)
        {
            var datos = from d in contexto.DOCTOR
                        select new { d.APELLIDO, d.DOCTOR_NO };
            this.cmbDoctor.DataSource = datos;
            this.cmbDoctor.DisplayMember = "APELLIDO"; // Se podrían añadir más valores con ITEM.ADD
            this.cmbDoctor.ValueMember = "DOCTOR_NO";
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

        }
    }

       
}
