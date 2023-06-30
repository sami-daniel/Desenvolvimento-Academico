using System;
using System.Drawing;
using System.Windows.Forms;

namespace TrabalhoSegundaEtapa.Views
{
    public partial class Exercicio3 : Form
    {
        public Exercicio3()
        {
            InitializeComponent();
        }

        private void BtnChangeBackColor_Click(object sender, EventArgs e)
        {
            this.BackColor = RdbYellow.Checked ? BackColor = Color.Yellow : RdbBlue.Checked ? BackColor = Color.Blue : RdbRed.Checked ? BackColor = Color.Red : BackColor = this.BackColor;
        }

        private void BtnColorDialog_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (DialogResult.OK == colorDialog.ShowDialog()) BackColor = colorDialog.Color;
        }
    }
}
