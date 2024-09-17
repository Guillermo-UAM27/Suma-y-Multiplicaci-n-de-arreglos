using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercio3
{
    internal class GestionSalarios
    {// Arreglo para contar los vendedores en cada rango de salario
        private int[] contadoresRangos = new int[9];

        // Método para determinar el rango salarial
        public void ProcesarVenta(int ventasBrutas)
        {
            int salario = (int)(200 + 0.09 * ventasBrutas);

            if (salario >= 1000)
                contadoresRangos[8]++;
            else if (salario >= 900)
                contadoresRangos[7]++;
            else if (salario >= 800)
                contadoresRangos[6]++;
            else if (salario >= 700)
                contadoresRangos[5]++;
            else if (salario >= 600)
                contadoresRangos[4]++;
            else if (salario >= 500)
                contadoresRangos[3]++;
            else if (salario >= 400)
                contadoresRangos[2]++;
            else if (salario >= 300)
                contadoresRangos[1]++;
            else
                contadoresRangos[0]++;
        }

        // Método para obtener los resultados en formato de cadena
        public string[] ObtenerReporte()
        {
            return new string[]
            {
                $"$200-$299:   {contadoresRangos[0]} vendedores",
                $"$300-$399:   {contadoresRangos[1]} vendedores",
                $"$400-$499:   {contadoresRangos[2]} vendedores",
                $"$500-$599:   {contadoresRangos[3]} vendedores",
                $"$600-$699:   {contadoresRangos[4]} vendedores",
                $"$700-$799:   {contadoresRangos[5]} vendedores",
                $"$800-$899:   {contadoresRangos[6]} vendedores",
                $"$900-$999:   {contadoresRangos[7]} vendedores",
                $"$1000 o más: {contadoresRangos[8]} vendedores"
            };
        }

        //  Esto para reiniciar los contadores
        public void Reiniciar()
        {
            for (int i = 0; i < contadoresRangos.Length; i++)
            {
                contadoresRangos[i] = 0;
            }
        }
    }
}
