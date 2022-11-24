using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace procedimientos_almacenados
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
            this.CargarDatosPlantilla();
        }

        private void CargarDatosPlantilla()
        {
            var datosplantilla = from plan in contexto.PLANTILLA
                                 select new
                                 {
                                     Codigo = plan.EMPLEADO_NO
                                     ,
                                     Apellido = plan.APELLIDO
                                 ,
                                     Funcion = plan.FUNCION
                                 };
            this.gridplantilla.DataSource = datosplantilla;
            this.gridplantilla.AllowUserToAddRows = false;
            this.gridplantilla.ReadOnly = true;
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            string ape, fun, codigo;
            int indice = this.gridplantilla.CurrentCell.RowIndex;
            ape = this.txtapellido.Text;
            fun = this.txtfuncion.Text;
            codigo = this.gridplantilla[0, indice].Value.ToString();

            this.contexto.MODIFICARPLANTILLA(int.Parse(codigo), ape, fun);

            var resultado = (from plan in contexto.PLANTILLA
                             where plan.EMPLEADO_NO == codigo
                             select new
                             {
                                 Apellido = plan.APELLIDO
                                 ,
                                 Funcion = plan.FUNCION
                             }).First();

            MessageBox.Show("Registro Modificado:\n" + resultado.Apellido + "\n" + resultado.Funcion);

            this.CargarDatosPlantilla();
        }

        private void gridplantilla_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                this.txtapellido.Text = this.gridplantilla[1, e.RowIndex].Value.ToString();
                this.txtfuncion.Text = this.gridplantilla[2, e.RowIndex].Value.ToString();
            }
        }
    }
    
}
