using System.Windows.Forms;

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
            LblOutPut.Text = RdbNormal.Checked ? TxtInput.Text : RdbHipperText.Checked ? TxtInput.Text.ToUpper() : RdbLowerText.Checked ? TxtInput.Text.ToLower() : TxtInput.Text;
        }

        private void Exercicio2_Load(object sender, System.EventArgs e)
        {
            RdbNormal.Checked = true;
        }
    }
}
