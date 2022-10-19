using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsApp
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int nota1 = Convert.ToInt32(txtNota1.Text);
            int nota2 = Convert.ToInt32(txtNota2.Text);
            int nota3 = Convert.ToInt32(txtNota3.Text);
            int nota4 = Convert.ToInt32(txtNota4.Text);
            int[] notas = { nota1, nota2, nota3, nota4 };

            MessageBox.Show("La nota mayor es " + notas.Max());

            int sumas = (nota1 + nota2 + nota3 + nota4) / 4;


        }
    }
}
