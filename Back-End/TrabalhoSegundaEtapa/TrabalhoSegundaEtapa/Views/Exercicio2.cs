using System.Windows.Forms;

namespace TrabalhoSegundaEtapa.Views
{
    public partial class Exercicio2 : Form
    {
        private bool rdbNormal;
        private bool rdbUpper;
        private bool rdbLower;
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
            BackAtPrincipalPage.ButtonBackAtPrincipalPage(this);
        }
    }
}
