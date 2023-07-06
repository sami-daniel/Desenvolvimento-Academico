using System;
using System.Windows.Forms;
using TrabalhoSegundaEtapa.Views;
using TrabalhoSegundaEtapa.Views.Functions;

namespace TrabalhoSegundaEtapa
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void ViewExerciseOne_Click(object sender, EventArgs e)
        {
            Exercicio1 formExercicio1 = new Exercicio1();
            this.Hide();
            formExercicio1.Show();
        }

        private void ViewExerciseTwo_Click(object sender, EventArgs e)
        {
            Exercicio2 formExercicio2 = new Exercicio2();
            this.Hide();
            formExercicio2.Show();
        }

        private void ViewExercise3_Click(object sender, EventArgs e)
        {
            Exercicio3 formExercicio3 = new Exercicio3();
            this.Hide();
            formExercicio3.Show();
        }

        private void ViewExercise4_Click(object sender, EventArgs e)
        {
            Exercicio4 formExercicio4 = new Exercicio4();
            this.Hide();
            formExercicio4.Show();
        }

        private void ChangeBackColor_Click(object sender, EventArgs e)
        {
            Configs.ChangeBackColorWithColorDialog(this);
        }

        private void desafio4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Desafio4 desafio4 = new Desafio4();
            this.Hide();
            desafio4.Show();
        }
    }
}
