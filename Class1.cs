using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordenar_texto
{
    class COrdenamineto
    {
        public void BUbbleSort(string [] ordenar)
        {
            string aux;
            for (int i = 1; i < ordenar.Length; i++)
            {
                for (int j = 0; j < ordenar.Length - i; j++)
                {
                    if (ordenar[j].CompareTo(ordenar[j + 1]) == 1)
                    {
                        aux = ordenar[j];
                        ordenar[j] = ordenar[j + 1];
                        ordenar[j + 1] = aux;
                    }
                }
            }
        }
        public void InsertionSort1(string[] ordenar)
        {
            int postA;
            string dato;
            for (int i = 1; i < ordenar.Length; i++)
            {
                postA = i;
                dato = ordenar[i];
                while (postA > 0 && ordenar[postA - 1].CompareTo(dato) == 1)
                {
                    ordenar[postA] = ordenar[postA - 1];
                    postA--;
                }
                ordenar[postA] = dato;
            }
        }
        public void SelecctionSort(string[] ordenar)
        {
            string aux;
            int imin;
            for (int i = 0; i < ordenar.Length; i++)
            {
                imin = i;
                for (int j = i + 1; j < ordenar.Length; j++)
                {
                    if (ordenar[j].CompareTo(ordenar[imin]) == -1)
                    {
                        imin = j;
                    }
                }
                aux = ordenar[i];
                ordenar[i] = ordenar[imin];
                ordenar[imin] = aux;
            }
            
        }
    }
}
