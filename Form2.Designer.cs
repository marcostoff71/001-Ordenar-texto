
namespace Ordenar_texto
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnNumeros = new System.Windows.Forms.RadioButton();
            this.Grupo = new System.Windows.Forms.GroupBox();
            this.btnLetras = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMin = new System.Windows.Forms.TextBox();
            this.txtMin = new System.Windows.Forms.Label();
            this.txtMax = new System.Windows.Forms.Label();
            this.btnMax = new System.Windows.Forms.TextBox();
            this.GrupoCantidad = new System.Windows.Forms.GroupBox();
            this.Grupo.SuspendLayout();
            this.GrupoCantidad.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(195, 123);
            this.textBox1.MaxLength = 4;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(145, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.button1.Location = new System.Drawing.Point(211, 149);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnNumeros
            // 
            this.btnNumeros.AutoSize = true;
            this.btnNumeros.Location = new System.Drawing.Point(11, 39);
            this.btnNumeros.Name = "btnNumeros";
            this.btnNumeros.Size = new System.Drawing.Size(67, 17);
            this.btnNumeros.TabIndex = 4;
            this.btnNumeros.TabStop = true;
            this.btnNumeros.Text = "Numeros";
            this.btnNumeros.UseVisualStyleBackColor = true;
            this.btnNumeros.CheckedChanged += new System.EventHandler(this.btnNumeros_CheckedChanged);
            // 
            // Grupo
            // 
            this.Grupo.Controls.Add(this.btnLetras);
            this.Grupo.Controls.Add(this.btnNumeros);
            this.Grupo.Location = new System.Drawing.Point(140, 17);
            this.Grupo.Name = "Grupo";
            this.Grupo.Size = new System.Drawing.Size(200, 100);
            this.Grupo.TabIndex = 5;
            this.Grupo.TabStop = false;
            // 
            // btnLetras
            // 
            this.btnLetras.AutoSize = true;
            this.btnLetras.Location = new System.Drawing.Point(111, 39);
            this.btnLetras.Name = "btnLetras";
            this.btnLetras.Size = new System.Drawing.Size(54, 17);
            this.btnLetras.TabIndex = 5;
            this.btnLetras.TabStop = true;
            this.btnLetras.Text = "Letras";
            this.btnLetras.UseVisualStyleBackColor = true;
            this.btnLetras.CheckedChanged += new System.EventHandler(this.btnLetras_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(137, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Cantidad:";
            // 
            // btnMin
            // 
            this.btnMin.Location = new System.Drawing.Point(47, 19);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(41, 20);
            this.btnMin.TabIndex = 7;
            this.btnMin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // txtMin
            // 
            this.txtMin.AutoSize = true;
            this.txtMin.Location = new System.Drawing.Point(18, 22);
            this.txtMin.Name = "txtMin";
            this.txtMin.Size = new System.Drawing.Size(27, 13);
            this.txtMin.TabIndex = 8;
            this.txtMin.Text = "Min:";
            // 
            // txtMax
            // 
            this.txtMax.AutoSize = true;
            this.txtMax.Location = new System.Drawing.Point(94, 22);
            this.txtMax.Name = "txtMax";
            this.txtMax.Size = new System.Drawing.Size(30, 13);
            this.txtMax.TabIndex = 10;
            this.txtMax.Text = "Max:";
            // 
            // btnMax
            // 
            this.btnMax.Location = new System.Drawing.Point(130, 19);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(40, 20);
            this.btnMax.TabIndex = 9;
            this.btnMax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // GrupoCantidad
            // 
            this.GrupoCantidad.Controls.Add(this.btnMax);
            this.GrupoCantidad.Controls.Add(this.txtMax);
            this.GrupoCantidad.Controls.Add(this.txtMin);
            this.GrupoCantidad.Controls.Add(this.btnMin);
            this.GrupoCantidad.Location = new System.Drawing.Point(164, 191);
            this.GrupoCantidad.Name = "GrupoCantidad";
            this.GrupoCantidad.Size = new System.Drawing.Size(176, 45);
            this.GrupoCantidad.TabIndex = 11;
            this.GrupoCantidad.TabStop = false;
            this.GrupoCantidad.Text = "Cantidad:";
            this.GrupoCantidad.Visible = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 311);
            this.Controls.Add(this.GrupoCantidad);
            this.Controls.Add(this.Grupo);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form2";
            this.Text = "Generador";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.Grupo.ResumeLayout(false);
            this.Grupo.PerformLayout();
            this.GrupoCantidad.ResumeLayout(false);
            this.GrupoCantidad.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton btnNumeros;
        private System.Windows.Forms.GroupBox Grupo;
        private System.Windows.Forms.RadioButton btnLetras;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox btnMin;
        private System.Windows.Forms.Label txtMin;
        private System.Windows.Forms.Label txtMax;
        private System.Windows.Forms.TextBox btnMax;
        private System.Windows.Forms.GroupBox GrupoCantidad;
    }
}