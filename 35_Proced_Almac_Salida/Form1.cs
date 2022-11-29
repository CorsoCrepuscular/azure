using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ej35_procedimientos_salida_2
{
    public partial class Form1 : Form
    {
        DataClasses1DataContext contexto = new DataClasses1DataContext();
        public Form1()
        {
            InitializeComponent();
        }
        // Mostrar listado con código de hospitales
        private void Form1_Load(object sender, EventArgs e)
        {
           
            var datosHospitales = from h in contexto.HOSPITAL
                                  select new { h.HOSPITAL_COD, h.NOMBRE };

            this.cmbHospitales.DataSource = datosHospitales; 
            this.cmbHospitales.DisplayMember = "NOMBRE";
            this.cmbHospitales.ValueMember = "HOSPITAL_COD";
           
        }

        // Visualizar datos
        private void cmbHospitales_SelectedIndexChanged(object sender, EventArgs e)
        {
          
            string datosHosSel = cmbHospitales.SelectedValue.ToString();

            int? media, suma, personas;
            media = 0;
            suma = 0;
            personas = 0;
            this.contexto.DATOSHOSPITAL(datosHosSel, ref personas, ref suma, ref media );    
            this.textBox1.Text = personas.ToString();
            this.textBox2.Text = suma.ToString();
            this.textBox3.Text = media.ToString();
        }
    }
}
