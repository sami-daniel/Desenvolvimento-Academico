using System;
using System.Windows.Forms;

namespace Ex02_47
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int[,] mat = {
                {0,0,0,0,0},
                {1,1,1,1,1},
                {2,2,2,2,2}
            };
            listBox1.MultiColumn = true;
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    LblExibir.Text += mat[i, j] + " ";
                    listBox1.Items.Add(mat[i, j]);
                }
                LblExibir.Text += "\n";
                listBox1.Items.Add("\t");
            }


        }
    }
}
