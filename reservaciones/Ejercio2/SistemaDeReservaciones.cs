using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercio2
{
    internal class SistemaDeReservaciones
    {
        private bool[] asientos = new bool[10]; // Array de 10 asientos (smoking: 1-5, nonsmoking: 6-10)

        // Verificar si una sección está llena
        public bool SeccionLlena(int seccion)
        {
            if (seccion == 1)
            {
                // Verificar la sección de fumar (asientos 0-4)
                for (int i = 0; i < 5; i++)
                {
                    if (!asientos[i]) return false; // hay asientos
                }
            }
            else
            {
                // Verificar la sección de no fumar (asientos 5-9)
                for (int i = 5; i < 10; i++)
                {
                    if (!asientos[i]) return false; // hay asisentos
                }
            }

            // Si todos los asientos están ocupados la sección está llena
            return true;
        }

        // Asignar asiento a la seccion que escogistes
        public int AsignarAsiento(int seccion)
        {
            if (seccion == 1)
            {
                // Asignar asiento en la sección de fumar (0-4)
                for (int i = 0; i < 5; i++)
                {
                    if (!asientos[i])
                    {
                        asientos[i] = true;
                        return i + 1; // Que los numeros de haciento se vayan sumando en base a 1
                    }
                }
            }
            else
            {
                // Asignar asiento en la sección de no fumar (5-9)
                for (int i = 5; i < 10; i++)
                {
                    if (!asientos[i])
                    {
                        asientos[i] = true;
                        return i + 1; // Que los numeros de haciento se vayan sumando en base a 5
                    }
                }
            }

            // Si no hay asientos disponibles, retornar -1
            return -1;
        }
    }
}
