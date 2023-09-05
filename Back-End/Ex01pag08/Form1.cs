using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex01pag08
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lbl1_Click(object sender, EventArgs e)
        {

        }

        private void Caucular_Click(object sender, EventArgs e)
        {
            double n1, n2, n3,total,por1,por2,por3;
            n1 = int.Parse(txt1.Text);
            n2 = int.Parse(txt2.Text);
            n3 = int.Parse(txt3.Text);
            total = (n1 + n2 + n3);
            por1 = (((100 *n1)/total));
            por2 = (((100 *n2)/total));
            por3 = (((100 *n3)/total));
            lblsomarrr.Text = "A soma do 1º número + o 3º é igual a: "+ (n1+n3);
            lblmediar.Text = "A média dos 3 números é igual a: " + (n1 + n2 + n3) / 3;
            lblpor1.Text = "Porcentagem  do primeiro número \nem relação ao total é de "+ (por1)+"%";
            lblpor2.Text = "\nPorcentagem  do segundo número \nem relação ao total é de " + (por2) + "%";
            lblpor3.Text = "\nPorcentagem  do terceiro número \nem relação ao total é de " + (por3) + "%";
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            txt1.Text = null;
            txt2.Text = null;
            txt3.Text = null;
        }

        private void txt2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
