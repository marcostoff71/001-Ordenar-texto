using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ordenar_texto
{
    class Class2
    {
        Random rdn = new Random();
        public string generadorPalabras()
        {
            
            string diccionario = "abcdefghijklmnjkaslksaureiuujbbjxzjhbz";
            string palabra = "";
            for (int i = 0; i < 10; i++)
            {
                palabra += diccionario[rdn.Next(diccionario.Length)];
            }
            return palabra;
        }
        public bool esNumInt(string texto)
        {
            int numFinal = 0;
            bool valor = false;
            valor = int.TryParse(texto, out numFinal);
            return valor;

        }
        public void ValidaIntText(ref TextBox textBox, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        public void GenreradorTexto(ref RichTextBox rixht, int cantidad)
        {
            for (int i = 0; i < cantidad; i++)
            {
                if (i != cantidad - 1)
                {
                    rixht.Text += generadorPalabras() + "\n";
                    
                }
                else
                {
                    rixht.Text += generadorPalabras();
                }
            }
        }
        public void GeneradorNumeor(ref RichTextBox ric, int cantidad,int min,int max)
        {
            Random rdn = new Random();
            for (int i = 0; i < cantidad; i++)
            {
                if (i != cantidad - 1)
                {
                    ric.Text += (rdn.Next(min,max)).ToString() + "\n";
                }
                else
                {
                    ric.Text += (rdn.Next(min,max)).ToString();
                }
            }
        }
    }
}
