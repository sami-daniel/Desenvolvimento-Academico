using System;
using System.Windows.Forms;

namespace Ex03_47
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int[,] mat = new int[6,6];
            Random r = new Random();

            for(int i = 0; i < mat.GetLength(0); i++)
            {
                for(int j = 0; j < mat.GetLength(1); j++)
                {
                    mat[i, j] = r.Next(2);
                    LblExibir.Text += mat[i, j] + " ";
                }
                LblExibir.Text += "\n";
            }
        }
    }
}
