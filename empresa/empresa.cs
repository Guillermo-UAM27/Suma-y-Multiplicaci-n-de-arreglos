using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercio3
{
    //Decidi cambiarle el nombre de from1 a FormularioDeVentas
    public partial class FormularioDeVenta : Form
    {
        private decimal[] ventasPorProducto;
        private decimal[] ventasPorVendedor;
        public FormularioDeVenta()
        {
            InitializeComponent();
            InicializarArreglos();

        }
        private void InicializarArreglos()
        {
            // Inicializa los arreglos para los productos y vendedores
            ventasPorProducto = new decimal[5];
            ventasPorVendedor = new decimal[4];
        }
        private void btAgregarVentas_Click(object sender, EventArgs e)
        {
            try
            {
                int idVendedor = Convert.ToInt32(tbIdVendedor.Text);
                int idProducto = Convert.ToInt32(tbIdProducto.Text);
                decimal montoVenta = Convert.ToDecimal(tbMontoVenta.Text);

                // Validamos parametros
                if (idVendedor >= 1 && idVendedor <= 4 && idProducto >= 1 && idProducto <= 5)
                {
                    // Actualizamos el arreglo de ventas
                    ActualizarVentas(idVendedor, idProducto, montoVenta);
                    MessageBox.Show("Venta registrada exitosamente.");
                }
                else
                {
                    MessageBox.Show("Error: El ID del vendedor o del producto está fuera del rango permitido.");
                }

                LimpiarCampos();
            }
            catch (FormatException)
            {
                MessageBox.Show("Error: Asegúrese de ingresar datos válidos.");
            }
        }
        private void ActualizarVentas(int vendedor, int producto, decimal monto)
        {
            ventasPorProducto[producto - 1] += monto;
            ventasPorVendedor[vendedor - 1] += monto;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            MostrarReporte();
        }
        private void MostrarReporte()
        {
            lbReporte.Items.Clear();
            lbReporte.Items.Add("Reporte de Ventas");

            // Mostramos ventas de productos
            lbReporte.Items.Add("Producto     Total");
            for (int i = 0; i < ventasPorProducto.Length; i++)
            {
                lbReporte.Items.Add($"Producto {i + 1}    {ventasPorProducto[i]:F2}");
            }

            lbReporte.Items.Add("--------------");

            // Mostramos las ventas por vendedor
            lbReporte.Items.Add("Vendedor     Total");
            for (int i = 0; i < ventasPorVendedor.Length; i++)
            {
                lbReporte.Items.Add($"Vendedor {i + 1}    {ventasPorVendedor[i]:F2}");
            }
        }

        private void LimpiarCampos()
        {
            tbIdVendedor.Clear();
            tbIdProducto.Clear();
            tbMontoVenta.Clear();
        }
    }
}

    

   