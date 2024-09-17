using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercio1
{
    internal class LanzadorDeDados
    {
        private int[] historialSumas;

        public LanzadorDeDados()
        {
            historialSumas = new int[11];  // Las posibles sumas son de 2 a 12, es decir, 11 valores
        }

        // Método para realizar el lanzamiento de los dados
        public TiradaResultado Lanzar()
        {
            Random rand = new Random();

            int dado1 = rand.Next(1, 7);  // Valor del dado 1 (1-6)
            int dado2 = rand.Next(1, 7);  // Valor del dado 2 (1-6)
            int sumaTotal = dado1 + dado2;

            // Actualizamos el historial de sumas
            historialSumas[sumaTotal - 2]++;

            // Devolvemos un objeto TiradaResultado con los valores obtenidos
            return new TiradaResultado(dado1, dado2, sumaTotal);
        }

        // Método para obtener el historial de sumas
        public int[] ObtenerHistorialDeSumas()
        {
            return historialSumas;
        }
    }

    // Clase para encapsular el resultado de una tirada
    public class TiradaResultado
    {
        public int Dado1 { get; }
        public int Dado2 { get; }
        public int SumaTotal { get; }

        public TiradaResultado(int dado1, int dado2, int sumaTotal)
        {
            Dado1 = dado1;
            Dado2 = dado2;
            SumaTotal = sumaTotal;
        }
    }
}

