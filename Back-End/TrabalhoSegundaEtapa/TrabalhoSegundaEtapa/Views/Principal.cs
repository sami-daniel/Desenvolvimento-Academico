using System;
using System.Windows.Forms;
using TrabalhoSegundaEtapa.Views;

namespace TrabalhoSegundaEtapa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ViewExerciseOne_Click(object sender, EventArgs e)
        {
            Exercicio1 formExercicio1 = new Exercicio1();
            this.Hide();
            formExercicio1.Show();
        }
    }
}
