using System;
using System.Text;
using System.Windows.Forms;

namespace TrabalhoSegundaEtapa.Views
{
    public partial class Desafio14 : Form
    {
        ulong contadorEleitoreRestantes, numVotantesNaoAleatorio = 0;
        string votoNulo = "Voto Nulo", votoEmBranco = "Voto em Branco";
        int countVotoNuloBranco = 0, candidatoSelecionado = 1;
        int[] candidatoCodTotalVotos = new int[6];
        //Declaração de variaveis
        public Desafio14()
        {
            InitializeComponent();
        }

        private void Desafio14_Load(object sender, EventArgs e)
        {
            LblCandidato.Text += " " + candidatoSelecionado;
            foreach (Control ctrl in this.Controls)
            {
                ctrl.Visible = false;
            }
            LblNumEleitores.Visible = true;
            TxtNumEleitores.Visible = true;
            LblAviso.Visible = true;
            LblAviso.Text = "Números muito grande podem gerar \n inconsistencia e lentidão no sistema";
            BtnPronto.Visible = true;
            /*Quando o formulario é carregado deixa somente a tela de 
            seleção de número de eleitores a mostra*/
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
            //Codígo para o valor do botão ser destinado ao campo requerido
        }
        private void BtnEncerrar_Click(object sender, EventArgs e)
        {
            StringBuilder stringBuilder = new StringBuilder();
            int candidatoMaisQtdVotos = int.MinValue;
            int numCandidatoMaisQtdVotos = 0;
            int candidatoMenosQtdVotos = int.MaxValue;
            int numCandidatoMenosQtdVotos = 0;
            int sum = 0;
            for (int i = 0; i < candidatoCodTotalVotos.Length; i++)
            {
                stringBuilder.Append($"Candidato {i + 1} tem um total de votos de ");
                stringBuilder.AppendLine(candidatoCodTotalVotos[i].ToString() + " votos");
                if (candidatoCodTotalVotos[i] > candidatoMaisQtdVotos)
                {
                    candidatoMaisQtdVotos = candidatoCodTotalVotos[i];
                    numCandidatoMaisQtdVotos = i + 1;
                }
                if (candidatoCodTotalVotos[i] < candidatoMenosQtdVotos)
                {
                    candidatoMenosQtdVotos = candidatoCodTotalVotos[i];
                    numCandidatoMenosQtdVotos = i + 1;
                }
                sum += candidatoCodTotalVotos[i];
            }
            stringBuilder.AppendLine();
            stringBuilder.Append($"Candidato com mais votos: Candidato {numCandidatoMaisQtdVotos}");
            stringBuilder.AppendLine($". Número de votos {candidatoMaisQtdVotos}");
            stringBuilder.Append($"Candidato com menos votos: Candidato {numCandidatoMenosQtdVotos}");
            stringBuilder.AppendLine($". Númeor de votos {candidatoMenosQtdVotos}");
            stringBuilder.AppendLine();
            stringBuilder.AppendLine($"Total de eleitores: {numVotantesNaoAleatorio}");
            //Monta uma StringBuilder construido aquilo que será mostrado no MessageBox após o encerramento
            if (countVotoNuloBranco > sum)
            {
                MessageBox.Show("Votação cancelada. Quantidade de votos de votos nulos e brancos excedida");
                this.Hide();
                Principal principal = new Principal();
                principal.Show();
                //Verificação para ver se o número de votos em branco ou nulo foram excedidos para cancelar a eleição caso.
            }
            else
            {
                MessageBox.Show(stringBuilder.ToString());
                this.Hide();
                Principal principal = new Principal();
                principal.Show();
                //Se tiver um número de concretos exibe as informações sobre a eleição.
            }
        }

        private void BtnVote_Click(object sender, EventArgs e)
        {
            if (!CkbAleatorio.Checked)
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
                numVotantesNaoAleatorio++;
                CkbAleatorio.Visible = false;
                candidatoSelecionado = 1;
                LblCandidato.Text = "Candidato: " + 1;
                //Caso o seletor de aléatoriedade for falso ele executa o código acima para realizar a votação automaticamente.
            }
            else
            {
                numVotantesNaoAleatorio = contadorEleitoreRestantes;
                Random random = new Random();
                while (true)
                {
                    int voto = random.Next(7);
                    if (contadorEleitoreRestantes == 0)
                    {
                        BtnEncerrar_Click(sender, e);
                        break;
                    }
                    if (voto == 0 || voto > 6)
                    {
                        countVotoNuloBranco++;
                    }
                    else if (voto <= 6)
                    {
                        candidatoCodTotalVotos[voto - 1]++;
                    }
                    contadorEleitoreRestantes--;
                }
                //Caso o seletor de aléatoriedade for verdadeiro ele executa o código acima para realizar a votação automaticamente.
            }
            CkbAleatorio.Visible = false;
            LblInstrucao.Visible = false;
        }

        private void BtnPronto_Click(object sender, EventArgs e)
        {
            if (TxtNumEleitores.Text == string.Empty)
            {
                MessageBox.Show("Insira um valor para o número de eleitores");
            }
            else
            {
                ulong.TryParse(TxtNumEleitores.Text, out contadorEleitoreRestantes);
                if (contadorEleitoreRestantes <= 0 )
                    MessageBox.Show("Insira um número correto ou menor/maior para o valor");
                else
                {
                    foreach (Control ctrl in this.Controls)
                    {
                        ctrl.Visible = true;
                    }
                    LblNumEleitores.Visible = false;
                    BtnPronto.Visible = false;
                    TxtNumEleitores.Visible = false;
                    LblAviso.Visible = false;
                    LblEleitoresRestantes.Text = "Eleitores restantes: " + contadorEleitoreRestantes;
                    /*Torna os campos de seleção de eleitores visivel, após validação etc.*/
                }
            }
        }
    }
}
