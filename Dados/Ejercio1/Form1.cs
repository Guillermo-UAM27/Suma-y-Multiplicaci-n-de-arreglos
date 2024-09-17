using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Ejercio1.LanzadorDeDados;

namespace Ejercio1
{
    public partial class Form1 : Form
    {
        private LanzadorDeDados lanzadorDeDados;
        public Form1()
        {
            InitializeComponent();
            lanzadorDeDados = new LanzadorDeDados();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Realiza la tirada y obtiene los resultados
            var resultado = lanzadorDeDados.Lanzar();

            // Actualiza las etiquetas del formulario con los resultados
            ActualizarResultados(resultado);
            // Actualiza el historial de sumas en el ListBox
            ActualizarHistorialSumas();
        }

        //Método que actualiza los resultados de la tirada de los dados en las etiquetas
        private void ActualizarResultados(TiradaResultado resultado)
        {
            lbDado1.Text = $"Dado 1: {resultado.Dado1}";
            lbDado2.Text = $"Dado 2: {resultado.Dado2}";
            lbSuma.Text = $"Suma: {resultado.SumaTotal}";
        }

        // Método que actualiza el historial de sumas en el ListBox
        private void ActualizarHistorialSumas()
        {
            int[] sumas = lanzadorDeDados.ObtenerHistorialDeSumas();

            // Limpiamos la lista antes de mostrar el nuevo historial
            lbHistorial.Items.Clear();
            lbHistorial.Items.Add("Suma\tCantidad");

            // Mostramos el historial actualizado de sumas
            for (int i = 0; i < sumas.Length; i++)
            {
                int suma = i + 2;  // Las sumas posibles van desde 2 a 12
                lbHistorial.Items.Add($"{suma}\t{sumas[i]}");
            }
        }

        private void tbResultados_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btHistorial_Click(object sender, EventArgs e)
        {

        }
    }
}

    