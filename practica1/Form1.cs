using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practica1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Crear objeto
            cloperaciones suma = new cloperaciones(float.Parse(txtNum1.Text), float.Parse(txtNum2.Text));
            textBox3.Text = suma.sumar().ToString();
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            cloperaciones rest = new cloperaciones(float.Parse(txtNum1.Text), float.Parse(txtNum2.Text));
            textBox3.Text = rest.resta().ToString();
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            cloperaciones multi = new cloperaciones(float.Parse(txtNum1.Text), float.Parse(txtNum2.Text));
            textBox3.Text = multi.multiplicacion().ToString();
        }

        private void btnDivi_Click(object sender, EventArgs e)
        {
            cloperaciones divi = new cloperaciones(float.Parse(txtNum1.Text), float.Parse(txtNum2.Text));
            textBox3.Text = divi.division().ToString();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            txtNum1.Clear();
            txtNum2.Clear();
            textBox3.Clear();
        }
    }
}

