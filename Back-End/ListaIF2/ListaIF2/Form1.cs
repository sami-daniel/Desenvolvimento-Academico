using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaIF2
{
    public partial class Form1 : Form
    {
        public static string[] produto = new string[100];
        public static double[] preco = new double[100];
        public static int[] quantidade = new int[100];
        public static double[] desconto = new double[100];
        public static double[] total = new double[100];
        public Form1()
        {
            InitializeComponent();
            for(int i = 0;i < quantidade.Length; i++) 
            {
                produto[i] = "vazio"; preco[i] = 0; quantidade[i] = 0; desconto[i] = 0; 
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Adicionar form = new Adicionar();
            form.Show();
            
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            lblDesconto.Text = lblProduto.Text = lblPreco.Text = lblquanti.Text = lblTotal.Text = String.Empty;
            for (int i = 0; i < produto.Length; i++)
            {
                lblProduto.Text += produto[i].ToString() + "\n";
                lblPreco.Text += "R$"+preco[i].ToString() + "\n";
                lblquanti.Text += quantidade[i].ToString() + "\n";
                lblTotal.Text += "R$"+total[i].ToString() + "\n";
                lblDesconto.Text += desconto[i].ToString() + "%" + "\n";
            }
        }
    }
}
