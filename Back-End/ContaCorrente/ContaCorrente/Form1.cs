﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContaCorrente
{
    public partial class Form1 : Form
    {
        public static string User;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnentrar_Click(object sender, EventArgs e)
        {
            User = txtUser.Text;
            Form2 form = new Form2();
            form.Show();
        }
    }
}