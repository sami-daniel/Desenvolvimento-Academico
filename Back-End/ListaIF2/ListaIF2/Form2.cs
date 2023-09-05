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
    public partial class Adicionar : Form
    {

        Form1 form = new Form1();
        public Adicionar()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        { 
            if (!string.IsNullOrEmpty(txtPreco.Text) && !string.IsNullOrEmpty(txtProduto.Text) && !string.IsNullOrEmpty(txtQntd.Text))
            {
                for (int i = 0; i < Form1.produto.Length; i++)
                {
                    if (Form1.produto[i] == "vazio")
                    {
                        double desconto;
                        if (int.Parse(txtQntd.Text) <= 5)
                        {
                            Form1.desconto[i] = 2;
                        }
                        else if (int.Parse(txtQntd.Text) >= 6 && int.Parse(txtQntd.Text) <= 10)
                        {
                            Form1.desconto[i] = 3;
                        }
                        else if (int.Parse(txtQntd.Text) > 10)
                        {
                            Form1.desconto[i] = 5;
                        }
                        Form1.produto[i] = txtProduto.Text;
                        Form1.preco[i] = Convert.ToDouble(txtPreco.Text);
                        Form1.quantidade[i] = int.Parse(txtQntd.Text);
                        desconto = (Form1.quantidade[i] * Form1.preco[i]) * (Form1.desconto[i] / 100);
                        Form1.total[i] = (Form1.quantidade[i] * Form1.preco[i]) - desconto;
                        break;
                    }
                }
            }
           
            
            txtPreco.Text = String.Empty;
            txtProduto.Text = String.Empty;
            txtQntd.Text = String.Empty;
        }
    }
}
