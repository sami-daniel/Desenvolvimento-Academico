using System.Windows.Forms;
using System.Drawing;
using TrabalhoSegundaEtapa.Views.Functions;

namespace TrabalhoSegundaEtapa.Views
{
    public partial class Exercicio2 : Form
    {
        public Exercicio2()
        {
            InitializeComponent();
        }

        private void TxtInput_KeyUp_1(object sender, KeyEventArgs e)
        {
            RefreshLabel();
        }

        private void ChekedChanged(object sender, System.EventArgs e)
        {
            RefreshLabel();
        }

        private void Exercicio2_Load(object sender, System.EventArgs e)
        {
            RdbNormal.Checked = true;
        }

        private void RefreshLabel()
        {
            LblOutPut.Text = RdbHipperText.Checked ? TxtInput.Text.ToUpper()
                : RdbLowerText.Checked ? TxtInput.Text.ToLower()
                : TxtInput.Text;
        }

        private void BtnBackAtPrincPage_Click(object sender, System.EventArgs e)
        {
            Configs.BackAtPrincipalPage(this);
        }

        private void ChangeBackColor_Click(object sender, System.EventArgs e)
        {
            Configs.ChangeBackColorWithColorDialog(this);
        }
    }
}
