using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Ordenar_texto
{

    public partial class Form1 : Form
    {

        COrdenamineto orde1 = new COrdenamineto();
        //vaiables 
        private bool abierto=false;//ayudara  saber si el archivo esta abierto 
        private string ruta;//ayudara a saber la ruta
        List<string> contenido = new List<string>();
        string[] ordenar;
        int lineas=0, longitud=0;

        public Form1()
        {
            InitializeComponent();
        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                contenido.Clear();
                txtPantalla.Text = "";
                ruta = openFileDialog1.FileName;
                using(StreamReader sr = new StreamReader(ruta))
                {
                    while (!sr.EndOfStream)
                    {
                        contenido.Add(sr.ReadLine());
                    }
                }
                
                if (contenido.Count > 0) {
                    foreach (string letras in contenido)
                    {
                        txtPantalla.Text += letras+"\n";        
                    }
                    abierto = true;
                }
                else
                {
                    MessageBox.Show("El archivo no contiene ningun caracter");
                    abierto = false;
                }
                
            }

            
        }

        private void btnBubble_Click(object sender, EventArgs e)
        {
            if (txtPantalla.Text!="")
            {
                ordenar = new string[txtPantalla.Lines.Count()];
                ordenar = txtPantalla.Text.Split('\n');
                
                txtPantalla.Clear();
                orde1.BUbbleSort(ordenar);
                if (ordenar.Length > 0) {
                    
                    foreach (string letras in ordenar)
                    {
                    txtPantalla.Text += letras + "\n";
                    }
                }
            }
        }

        private void seleccionarFuenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                txtPantalla.Font = fontDialog1.Font;
            }
        }

        private void seleccionarColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                txtPantalla.ForeColor = colorDialog1.Color;
            }
        }

        private void btnInsertion_Click(object sender, EventArgs e)
        {
            if (txtPantalla.Text != "")
            {
                ordenar = new string[txtPantalla.Lines.Count()];
                ordenar = txtPantalla.Text.Split('\n');

                txtPantalla.Clear();
                if (ordenar.Length > 0)
                {

                    //metodo de ordenamineto
                    orde1.InsertionSort1(ordenar);
                    foreach (string letras in ordenar)
                    {
                        txtPantalla.Text += letras + "\n";
                    }
                }
            }
        }

        private void btnSeleccion_Click(object sender, EventArgs e)
        {
            if (txtPantalla.Text != "")
            {
                ordenar = new string[txtPantalla.Lines.Count()];
                ordenar = txtPantalla.Text.Split('\n');

                txtPantalla.Clear();
                if (ordenar.Length > 0)
                {

                    //metodo de ordenamineto
                    orde1.SelecctionSort(ordenar);
                    //Array.Sort(ordenar);
                    foreach (string letras in ordenar)
                    {
                        txtPantalla.Text += letras + "\n";
                    }
                }
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            txtPantalla.Redo();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            txtPantalla.Redo();
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (abierto == false && txtPantalla.Text != "") 
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    ruta = saveFileDialog1.FileName;
                    using(StreamWriter sw = new StreamWriter(ruta))
                    {
                        sw.Write(txtPantalla.Text);
                    }
                    abierto = true;
                }
                
            }else if (abierto == true)
            {
                using (StreamWriter sw = new StreamWriter(ruta))
                {
                    sw.Write(txtPantalla.Text);
                }
            }
        }

        private void guardarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txtPantalla.Text != "")
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    ruta = saveFileDialog1.FileName;
                    using(StreamWriter sw = new StreamWriter(ruta))
                    {
                        sw.Write(txtPantalla.Text);
                    }
                }
            }
        }

        private void Invertir_Click(object sender, EventArgs e)
        {
            if (txtPantalla.Text != "")
            {
                
                ordenar = new string[txtPantalla.Lines.Count()];
                ordenar = txtPantalla.Text.Split('\n');
                txtPantalla.Clear();

                //ponemos de reversa el array
                Array.Reverse(ordenar);

                //foreach(string letras in ordenar)
                //{
                //    txtPantalla.Text += letras + "\n";
                //}
                for(int i = 0; i < ordenar.Length; i++)
                {
                    if (i != ordenar.Length - 1)
                    {
                        txtPantalla.Text += ordenar[i] + "\n";
                    }
                    else
                    {
                        txtPantalla.Text += ordenar[i];
                    }
                }



            }
        }

        private void txtPantalla_TextChanged(object sender, EventArgs e)
        {
            lineas = txtPantalla.Lines.Count();
            longitud = txtPantalla.Text.Length;

            txtLineas.Text = lineas.ToString();
            txtLongitud.Text = longitud.ToString();
        }
    }
}
