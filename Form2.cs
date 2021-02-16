using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ordenar_texto
{
    public partial class Form2 : Form
    {

        Class2 vali1 = new Class2();
        public RichTextBox txb = new RichTextBox();
        public bool aceptado = false;
        public Form2()
        {
            InitializeComponent();
        }
        Point defe;
        private void Form2_Load(object sender, EventArgs e)
        {
            defe = new Point(button1.Location.X, button1.Location.Y);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            textBox1.Text = textBox1.Text.Trim();
            if (vali1.esNumInt(textBox1.Text) && textBox1.Text != "")
            {

                if (btnLetras.Checked == true)
                {
                    button1.DialogResult = DialogResult.OK;
                    aceptado = true;
                    vali1.GenreradorTexto(ref txb, int.Parse(textBox1.Text));
                    //this.Close();
                }
                else if (btnNumeros.Checked == true)
                {
                    if (vali1.esNumInt(btnMax.Text)==true && vali1.esNumInt(btnMin.Text)==true)
                    {
                        
                        int min, max;
                        min = int.Parse(btnMin.Text);
                        max = int.Parse(btnMax.Text);
                        if (min < max)
                        {
                            aceptado = true;
                            button1.DialogResult = DialogResult.OK;

                            vali1.GeneradorNumeor(ref txb, int.Parse(textBox1.Text), min, max);
                            
                        }else
                        {
                            MessageBox.Show("Debes ingresar un numero minimo y maximo correcto");
                        }
                        
                    }
                    
                    //this.Close();
                }
                else
                {

                    //button1.DialogResult = DialogResult.None;
                    MessageBox.Show("Selecciona una opcion");
                }

            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            vali1.ValidaIntText(ref textBox1, e);
        }

        private void btnNumeros_CheckedChanged(object sender, EventArgs e)
        {
            GrupoCantidad.Visible = true;
            GrupoCantidad.Location = new Point(textBox1.Location.X - 20, textBox1.Location.Y + 20);
            button1.Location = defe;
            button1.Location = new Point(button1.Location.X, button1.Location.Y + 40);

        }

        private void btnLetras_CheckedChanged(object sender, EventArgs e)
        {
            GrupoCantidad.Visible = false;
            button1.Location = defe;
        }
    }
}
