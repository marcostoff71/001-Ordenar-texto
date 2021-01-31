using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordenar_texto
{
    class COrdenamineto
    {
        public static bool EsNum(string[] pLetras)
        {
            float num;

            int cont=0, longitud = pLetras.Length;
            foreach(string letra in pLetras)
            {
                if(float.TryParse(letra,out num))
                {
                    cont++;
                }
            }

            if (cont == longitud)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
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
    class CordenamientoNum
    {
        public static void BubbleSort(float[] numeros)
        {
            float aux;
            for(int i = 1; i < numeros.Length; i++)
            {
                for(int j = 0; j < numeros.Length - i; j++)
                {
                    if (numeros[j] > numeros[j + 1])
                    {
                        aux = numeros[j];
                        numeros[j] = numeros[j + 1];
                        numeros[j + 1] = aux;
                    }
                }
            }
        }
        public static void InsertionSort1(float[] numeros)
        {
            float dato;
            int postA;

            for(int i = 1; i < numeros.Length; i++)
            {
                dato = numeros[i];
                postA = i;
                while (postA > 0 && numeros[postA - 1] > dato)
                {
                    numeros[postA] = numeros[postA - 1];
                    postA--;
                }
                numeros[postA] = dato;
            }
        }
        public static void InsertionSort2(float[] numeros)
        {
            int postA;
            float aux;
            for (int i = 1; i < numeros.Length; i++)
            {
                postA = i;
                while (postA > 0 && numeros[postA - 1] > numeros[postA])
                {
                    aux = numeros[postA - 1];
                    numeros[postA - 1] = numeros[postA];
                    numeros[postA] = aux;
                    postA--;
                }
            }
        }
        public static void SelecctionSort(float[] numeros)
        {
            int iMin;
            float aux;

            for(int i = 0; i < numeros.Length; i++)
            {
                iMin = i;
                for(int j = i + 1; j < numeros.Length; j++)
                {
                    if (numeros[iMin] > numeros[j])
                    {
                        iMin = j;
                    }
                }
                aux = numeros[i];
                numeros[i] = numeros[iMin];
                numeros[iMin] = aux;

            }
        }
    }
}
