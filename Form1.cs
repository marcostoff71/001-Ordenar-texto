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
        private bool abierto = false;//ayudara  saber si el archivo esta abierto 
        private string ruta;//ayudara a saber la ruta

        List<string> contenido = new List<string>();//para abrir el archivo 
        string[] ordenar;
        float[] ordenar2;


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
                using (StreamReader sr = new StreamReader(ruta))
                {
                    while (!sr.EndOfStream)
                    {
                        contenido.Add(sr.ReadLine());
                    }
                }

                if (contenido.Count > 0)
                {
                    foreach (string letras in contenido)
                    {
                        txtPantalla.Text += letras + "\n";
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
            if (txtPantalla.Text != "")
            {
                ordenar = new string[txtPantalla.Lines.Count()];
                ordenar = txtPantalla.Text.Split('\n');

                txtPantalla.Clear();
                if (COrdenamineto.EsNum(ordenar))
                {
                    OrdenandoLetrasNumeros.Text = "Estas ordenando numeros";
                    ordenar2 = new float[ordenar.Length];
                    for (int i = 0; i < ordenar2.Length; i++) { ordenar2[i] = float.Parse(ordenar[i]); }

                    CordenamientoNum.SelecctionSort(ordenar2);

                    for (int i = 0; i < ordenar2.Length; i++)
                    {
                        if (i != ordenar2.Length - 1)
                        {
                            txtPantalla.Text += ordenar2[i] + "\n";
                        }
                        else
                        {
                            txtPantalla.Text += ordenar2[i];
                        }
                    }

                }
                else
                {
                    OrdenandoLetrasNumeros.Text = "Estas ordenando letras";
                    orde1.BUbbleSort(ordenar);

                    for (int i = 0; i < ordenar.Length; i++)
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
                if (COrdenamineto.EsNum(ordenar))
                {
                    OrdenandoLetrasNumeros.Text = "Estas ordenando numeros";
                    ordenar2 = new float[ordenar.Length];
                    for (int i = 0; i < ordenar2.Length; i++) { ordenar2[i] = float.Parse(ordenar[i]); }

                    CordenamientoNum.InsertionSort2(ordenar2);

                    for (int i = 0; i < ordenar2.Length; i++)
                    {
                        if (i != ordenar2.Length - 1)
                        {
                            txtPantalla.Text += ordenar2[i] + "\n";
                        }
                        else
                        {
                            txtPantalla.Text += ordenar2[i];
                        }
                    }

                }
                else
                {
                    OrdenandoLetrasNumeros.Text = "Estas ordenando letras";
                    //metodo de ordenamineto
                    orde1.InsertionSort1(ordenar);
                    for (int i = 0; i < ordenar.Length; i++)
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
        }

        private void btnSeleccion_Click(object sender, EventArgs e)
        {
            if (txtPantalla.Text != "")
            {
                ordenar = new string[txtPantalla.Lines.Count()];
                ordenar = txtPantalla.Text.Split('\n');

                txtPantalla.Clear();
                if (COrdenamineto.EsNum(ordenar))
                {
                    OrdenandoLetrasNumeros.Text = "Estas ordenando numeros";
                    ordenar2 = new float[ordenar.Length];
                    for (int i = 0; i < ordenar2.Length; i++) { ordenar2[i] = float.Parse(ordenar[i]); }

                    Array.Sort(ordenar2);
                    //CordenamientoNum.SelecctionSort(ordenar2);

                    for (int i = 0; i < ordenar2.Length; i++)
                    {
                        if (i != ordenar2.Length - 1)
                        {
                            txtPantalla.Text += ordenar2[i] + "\n";
                        }
                        else
                        {
                            txtPantalla.Text += ordenar2[i];
                        }
                    }

                }
                else
                {
                    OrdenandoLetrasNumeros.Text = "Estas ordenando letras";

                    //metodo de ordenamineto
                    orde1.SelecctionSort(ordenar);
                    //Array.Sort(ordenar);
                    for (int i = 0; i < ordenar.Length; i++)
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
                    
                    using (StreamWriter sw = new StreamWriter(ruta))
                    {
                        sw.Write(txtPantalla.Text);
                    }
                    abierto = true;
                }

            }
            else if (abierto == true)
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
                    using (StreamWriter sw = new StreamWriter(ruta))
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
                if (COrdenamineto.EsNum(ordenar))
                {
                    OrdenandoLetrasNumeros.Text = "Estas ordenando numeros";
                    ordenar2 = new float[ordenar.Length];
                    for (int i = 0; i < ordenar2.Length; i++) { ordenar2[i] = float.Parse(ordenar[i]); }

                    Array.Reverse(ordenar2);

                    for (int i = 0; i < ordenar2.Length; i++)
                    {
                        if (i != ordenar2.Length - 1)
                        {
                            txtPantalla.Text += ordenar2[i] + "\n";
                        }
                        else
                        {
                            txtPantalla.Text += ordenar2[i];
                        }
                    }

                }
                else
                {
                    OrdenandoLetrasNumeros.Text = "Estas ordenando letras";
                    //ponemos de reversa el array
                    Array.Reverse(ordenar);

                    //foreach(string letras in ordenar)
                    //{
                    //    txtPantalla.Text += letras + "\n";
                    //}
                    for (int i = 0; i < ordenar.Length; i++)
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
        }

        private void Generador_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
            if (form2.button1.DialogResult==DialogResult.OK)
            {
                
                txtPantalla.Text = form2.txb.Text;
            }
            
            
            

        }

        private void txtPantalla_TextChanged(object sender, EventArgs e)
        {
            //lineas = txtPantalla.Lines.Count();
            //longitud = txtPantalla.Text.Length;

            txtLineas.Text = txtPantalla.Text.Length.ToString();
            txtLongitud.Text = txtPantalla.Lines.Count().ToString();
        }

        private void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtPantalla.Font = new Font(txtPantalla.Font.FontFamily, float.Parse(toolStripComboBox1.Text));
        }

        private void Pegar_Click(object sender, EventArgs e)
        {
            txtPantalla.Paste();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnDesordenar_Click(object sender, EventArgs e)
        {
            if (txtPantalla.Text != "")
            {
                ordenar = new string[txtPantalla.Lines.Count()];
                ordenar = txtPantalla.Text.Split('\n');
                txtPantalla.Clear();
                if (COrdenamineto.EsNum(ordenar)) {
                    OrdenandoLetrasNumeros.Text = "Estas ordenando numeros";
                    ordenar2 = new float[ordenar.Length];
                    for (int i =0; i < ordenar.Length; i++) ordenar2[i] = float.Parse(ordenar[i]);
                    CordenamientoNum.DesordenarNumeros(ordenar2);

                    for(int i = 0; i < ordenar2.Length; i++)
                    {
                        if (i != ordenar2.Length - 1)
                        {
                            txtPantalla.Text += ordenar2[i].ToString() + "\n";
                        }
                        else
                        {
                            txtPantalla.Text += ordenar2[i].ToString();
                        }
                    }

                }
                else
                {
                    OrdenandoLetrasNumeros.Text = "Estas ordenando letras";
                    orde1.DesordenarLetras(ordenar);
                    for (int i = 0; i < ordenar.Length; i++)
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
        }
    }
}
