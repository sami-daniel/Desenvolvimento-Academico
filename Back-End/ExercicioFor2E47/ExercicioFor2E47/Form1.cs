using System;
using System.Windows.Forms;

namespace ExercicioFor2E47
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Btn100_200_Click(object sender, EventArgs e)
        {
            lstDados.Items.Clear();
            for (int i = 100; i <= 200; i++)
                lstDados.Items.Add(i.ToString());

        }

        private void Btn200_100_Click(object sender, EventArgs e)
        {
            lstDados.Items.Clear();
            for (int i = 200; i >= 100; i--)
                lstDados.Items.Add(i.ToString());

        }

        private void M5_1a500_Click(object sender, EventArgs e)
        {
            lstDados.Items.Clear();
            for (int i = 5; i < 501; i += 5)
                lstDados.Items.Add(i.ToString());

        }

        private void Btn_Pares_1_100_Click(object sender, EventArgs e)
        {
            lstDados.Items.Clear();
            for (int i = 1; i <= 100; i++)
                lstDados.Items.Add(i.ToString());

        }

        private void Btn_100_primeiros_num_impares_Click(object sender, EventArgs e)
        {
            lstDados.Items.Clear();
            int counter = 1;
            for (int i = 1; i < 200; i += 2)
            {
                lstDados.Items.Add($"{counter}º: {i}");
                counter++;
            }
        }

        private void btn_quadrado_de_1_a_20_Click(object sender, EventArgs e)
        {
            lstDados.Items.Clear();
            for (int i = 1; i <= 20; i++)
                lstDados.Items.Add($"{i}º: {Math.Pow(i, 2)}");
        }

        private void btn_impares_1_a_100_Click(object sender, EventArgs e)
        {
            lstDados.Items.Clear();
            for (int i = 1; i <= 100; i+=2)
                lstDados.Items.Add($"{i}");
        }
    }
}
