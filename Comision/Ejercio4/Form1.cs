using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercio3
{
    public partial class Form1 : Form
    {
        private GestionSalarios gestionSalarios;


        public Form1()
        {
            InitializeComponent();
            gestionSalarios = new GestionSalarios();  // Inicializamos la clase
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int ventasBrutas;
            if (int.TryParse(txtVentas.Text, out ventasBrutas))
            {
                gestionSalarios.ProcesarVenta(ventasBrutas);
                MessageBox.Show("Venta registrada correctamente.");
            }
            else
            {
                MessageBox.Show("Ingrese un valor numérico válido para las ventas.");
            }

            txtVentas.Clear();

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Reporte.Items.Clear();
            Reporte.Items.Add("Rangos de salarios:");

            // Obtenemos el reporte y lo mandamos al ListBox
            string[] reporte = gestionSalarios.ObtenerReporte();
            foreach (var linea in reporte)
            {
                Reporte.Items.Add(linea);
            }
        }

        private void lbResultados_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            gestionSalarios.Reiniciar();
            MessageBox.Show("Se han reiniciado los datos.");
            Reporte.Items.Clear();

        }
    }
}
