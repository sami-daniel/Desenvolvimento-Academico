using System;
using System.Text;
using TrabalhoSegundaEtapa.Entities;
using System.Windows.Forms;
using System.Collections.Generic;
using TrabalhoSegundaEtapa.Views.Functions;
using System.Threading;

namespace TrabalhoSegundaEtapa.Views
{
    public partial class Desafio4 : Form
    {
        int candidatoSelecionado = 1;
        int contadorEleitoreRestantes = 20, numEleitor = 20;
        string votoNulo = "Voto Nulo";
        string votoEmBranco = "Voto em Branco";
        int countVotoNuloBranco = 0;
        int[] candidatoCodTotalVotos = new int[6];
        public Desafio4()
        {
            InitializeComponent();
        }

        private void Desafio14_Load(object sender, EventArgs e)
        {
            Random rnd = new Random();
            LblCandidato.Text += " " + candidatoSelecionado;
            LblEleitoresRestantes.Text = "Eleitores restantes: " + contadorEleitoreRestantes;
        }

        private void BtnNumCandiCLick(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (int.Parse(button.Text) > 6 || int.Parse(button.Text) < 0)
                LblCandidato.Text = votoNulo;
            else if (int.Parse(button.Text) == 0)
                LblCandidato.Text = votoEmBranco;
            else
            {
                LblCandidato.Text = "Candidato: " + " " + button.Text;
                candidatoSelecionado = int.Parse(button.Text);
            }
        }

        private void BtnEncerrar_Click(object sender, EventArgs e)
        {
            StringBuilder stringBuilder = new StringBuilder();
            int canditoMaisVotado = int.MinValue;
            int candidatoMenosVotado = int.MaxValue;
            stringBuilder.AppendLine("Votação encerrada com sucesso.");
            stringBuilder.AppendLine();
            stringBuilder.AppendLine("Total de eleitores: " + numEleitor);
            stringBuilder.AppendLine();
            stringBuilder.AppendLine("Total de votos em cada candidanto: ");
            int sum = 0;
            for (int i = 0; i < candidatoCodTotalVotos.Length; i++)
            {
                stringBuilder.AppendLine($"Candidato {i + 1}, total de votos igual a: {candidatoCodTotalVotos[i]}");
                sum += candidatoCodTotalVotos[i];
            }
            for (int i = 0; i < candidatoCodTotalVotos.Length; i++)
            {
                if (candidatoCodTotalVotos[i] > canditoMaisVotado)
                    canditoMaisVotado = i;
                else if (candidatoCodTotalVotos[i] < candidatoMenosVotado)
                    candidatoMenosVotado = i;
            }

            stringBuilder.AppendLine();
            canditoMaisVotado += 1;
            candidatoMenosVotado += 1;
            stringBuilder.AppendLine("Candidato mais votado: Candidato número " + canditoMaisVotado);
            stringBuilder.AppendLine("Candidato menos votado: Candidato número " + candidatoMenosVotado);
            if (countVotoNuloBranco > sum)
            {
                MessageBox.Show("Eleição cancelada por muitos votos em branco/nulo");
            }
            else
            {
                MessageBox.Show(stringBuilder.ToString());
            }
            this.Hide();
            Configs.BackAtPrincipalPage(this);
        }

        private void BtnVote_Click(object sender, EventArgs e)
        {
            if (LblCandidato.Text != votoEmBranco && LblCandidato.Text != votoNulo)
            {
                candidatoCodTotalVotos[candidatoSelecionado - 1]++;
            }
            else
            {
                countVotoNuloBranco++;
            }
            LblCandidato.Text = "Candidato: ";
            MessageBox.Show("Voto computado com sucesso;");
            LblEleitoresRestantes.Text = "Eleitores restantes: " + --contadorEleitoreRestantes;
            if (contadorEleitoreRestantes == 0)
            {
                BtnEncerrar_Click(sender, e);
            }
        }
    }
}
