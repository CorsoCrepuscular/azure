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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            FormAlta fa = new FormAlta();
            if(fa.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Alta efectuada con éxito");
            }
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            FormBaja fa = new FormBaja();
            if (fa.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Baja efectuada con éxito");
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            FormModificar fa = new FormModificar();
            if (fa.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Modificación efectuada con éxito");
            }
        }
    }
}
