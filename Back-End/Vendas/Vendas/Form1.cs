using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vendas
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        
        private void btnAdd_Click(object sender, EventArgs e)
        {
            
        }

       
        private void btnAddi(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtProd.Text))
            {
                
                lblProd.Text += "\n" + txtProd.Text;
                
                
            }
            if (lbl1.Text != null &&!string.IsNullOrEmpty(txtPrecU.Text))
            {
                lblprecU.Text += "\n" + txtPrecU.Text;
               
            }
            if (lblqntd.Text != null && lblprecU.Text != null)
            {
                lblTotal.Text = "\n" + Convert.ToString(double.Parse(txtPrecU.Text) * double.Parse(txtqntd.Text));
            }
        }
    }
}
