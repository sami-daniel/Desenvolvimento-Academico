using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex07Pag08
{
    public partial class Form1 : Form
    {
        int p, m, g, i;

        private void lblIindicacao_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public Form1()
        {
            InitializeComponent();
            lblIindicacao.Text = "Digite o número de camisetas pequenas";
            i = 1;
        }

        private void btnCal_Click(object sender, EventArgs e)
        {
            if(i == 1)
            {
                i++;
                p = 12 * Convert.ToInt32(txtCamisas.Text);
                lblIindicacao.Text = "Digite o número de camisetas médias";
            }
            else 
            {
                if (i == 2)
                {
                    i++;
                    m = 16 * Convert.ToInt32(txtCamisas.Text);
                    lblIindicacao.Text = "Digite o número de camisetas grandes";
                }
                else {
                    if (i == 3)
                    {
                        g = 22 * Convert.ToInt32(txtCamisas.Text);
                        btnCal.Text = "Reiniciar";
                        lblResult.Text = Convert.ToString(p + m + g);
                        i = 0;
                    }
                }
            }
            
            
        }
    }
}
