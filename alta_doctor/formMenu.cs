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
    public partial class formMenu : Form
    {
        public formMenu()
        {
            InitializeComponent();
        }

        private void formMenu_Load(object sender, EventArgs e)
        {

        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            Form1 fAlta = new Form1();
            if(fAlta.ShowDialog() == DialogResult.OK){
                MessageBox.Show("Alta efectuada con éxito");
            } 

        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            FormBaja fBaja = new FormBaja();
            if (fBaja.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Baja efectuada con éxito");
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            FormModificar fModificar = new FormModificar();
            if (fModificar.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Modificación efectuada con éxito");
            }
        }
        
    }
}
