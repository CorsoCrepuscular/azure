using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace procedimientos_salida
{
    public partial class Form1 : Form
    {
        enfermosDataContext contexto = new enfermosDataContext();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            string dato_enfermo = textBox1.Text.ToString();
            string dato_apellido = null;
            string dato_sexo = null;

            this.contexto.CONSULTANOMBRE2(dato_enfermo, ref dato_apellido, ref dato_sexo);
            this.txtNombre.Text = dato_apellido;
            if (dato_sexo == "M") {
                this.txtSexo.Text = "HOMBRE";
            }
            else
            {
                this.txtSexo.Text = "MUJER";
            }
            
        }
    }
}
