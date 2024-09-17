using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercio2
{
    public partial class Form1 : Form
    {
        private SistemaDeReservaciones sistema;

        public Form1()
        {
            InitializeComponent();
            sistema = new SistemaDeReservaciones();
        }

        private void btnFumar_Click(object sender, EventArgs e)
        {
            ProcesarReserva(1); // 1 es la sección de fumar
        }

        private void btnNoFumar_Click(object sender, EventArgs e)
        {
            ProcesarReserva(2); // 2 es la sección de no fumar
        }
        private void ProcesarReserva(int seccion)
        {
            // Verificar si la sección está llena
            if (sistema.SeccionLlena(seccion))
            {
                // Preguntar al usuario si quiere cambiar de sección
                DialogResult respuesta = MessageBox.Show(
                    "La sección seleccionada esta llena. ¿Desea cambiar a la otra sección?",
                    "Sección Llena",
                    MessageBoxButtons.YesNo
                );

                if (respuesta == DialogResult.Yes)
                {
                    // si la respuesta es si cambia de sección si no...
                    seccion = seccion == 1 ? 2 : 1;
                }
                else
                {
                    // Informar que el próximo vuelo sale en 3 horas
                    MessageBox.Show("Next flight leaves in 3 hours.");
                    return;
                }
            }

            // Asignar el asiento
            int asientoAsignado = sistema.AsignarAsiento(seccion);

            if (asientoAsignado != -1)
            {
                // Mostrar el número de asiento y sección al usuario
                string seccionTexto = seccion == 1 ? "smoking" : "Nonsmoking";
                MessageBox.Show($"Su asiento es el {asientoAsignado} en la sección de {seccionTexto}. ¡Gracias por su reservación!");
            }
            else
            {
                // si no, informa que el avion esta llena
                MessageBox.Show("El avión está lleno. Next flight leaves in 3 hours.");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
