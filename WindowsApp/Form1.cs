﻿using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string password = txtPassword.Text;

            if (nombre.ToUpper() == "GABY" && password == "123456")
            {
                MessageBox.Show("Bienvenida al sistema.");
            } else
            {
                MessageBox.Show("No está registrado.");
            }
        }
    }
}
