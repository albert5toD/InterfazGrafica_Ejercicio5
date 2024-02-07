using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfazGrafica_Ejercicio5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtPresupuesto.Clear();
            txtAdministracion.Clear();
            txtCirugia.Clear();
            txtEmergencia.Clear();
            txtImagenes.Clear();
            txtLaboratorio.Clear();
            txtSuministros.Clear();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnDistribuir_Click(object sender, EventArgs e)
        {
            double presupuesto, emergencia, cirugia, suministros, administracion, laboratorio, imagenes;

            presupuesto = double.Parse(txtPresupuesto.Text);

            emergencia = (presupuesto * 30) / 100;
            cirugia = (presupuesto * 15) / 100;
            suministros = (presupuesto * 25) / 100;
            administracion = (presupuesto * 18) / 100;
            laboratorio = (presupuesto * 5) / 100;
            imagenes = (presupuesto * 7) / 100;

            txtEmergencia.Text = emergencia.ToString();
            txtCirugia.Text = cirugia.ToString();
            txtAdministracion.Text = administracion.ToString();
            txtLaboratorio.Text = laboratorio.ToString();
            txtSuministros.Text = suministros.ToString();
            txtImagenes.Text = imagenes.ToString();

           
        }
    }
}
