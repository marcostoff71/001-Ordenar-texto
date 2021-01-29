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


        //vaiables 
        private bool abierto;//ayudara  saber si el archivo esta abierto 
        private string ruta;//ayudara a saber la ruta
        List<string> contenido = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            contenido.Clear();
            txtPantalla.Text = "";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
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
            if (abierto == true && contenido.Count >0)
            {

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
    }
}
