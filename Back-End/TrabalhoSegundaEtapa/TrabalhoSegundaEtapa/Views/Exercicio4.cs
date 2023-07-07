using System.Drawing;
using System;
using System.Windows.Forms;
using TrabalhoSegundaEtapa.Views.Functions;
using TrabalhoSegundaEtapa.Entities;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace TrabalhoSegundaEtapa.Views
{
    public partial class Exercicio4 : Form
    {
        List<Produto> produtosComprados = new List<Produto>();
        Produto[] produtos = new Produto[]
{
            new Produto("Laranja", 1.29),
            new Produto("Maçã", 1.49),
            new Produto("Banana", 0.99),
            new Produto("Cenoura", 1.99),
            new Produto("Batata", 2.99),
            new Produto("Cebola", 1.99),
            new Produto("Tomate", 2.49),
            new Produto("Ovos", 3.99),
            new Produto("Presunto", 9.99),
            new Produto("Queijo", 7.99),
            new Produto("Manteiga", 6.99),
            new Produto("Pão", 2.99),
            new Produto("Leite", 4.49),
            new Produto("Café", 8.99),
            new Produto("Açúcar", 2.99),
            new Produto("Sal", 1.49),
            new Produto("Azeite", 12.99),
            new Produto("Macarrão", 3.49),
            new Produto("Feijão", 5.99),
            new Produto("Arroz", 10.99),
            new Produto("Abacaxi", 2.99),
            new Produto("Morango", 3.99),
            new Produto("Melancia", 8.49),
            new Produto("Coco", 4.99),
            new Produto("Abóbora", 2.49),
            new Produto("Alface", 1.99),
            new Produto("Beterraba", 1.79),
            new Produto("Pêssego", 2.99),
            new Produto("Limão", 1.29),
            new Produto("Mamão", 3.49),
            new Produto("Uva", 4.99),
            new Produto("Melão", 5.99),
            new Produto("Cereja", 6.99),
            new Produto("Kiwi", 2.99),
            new Produto("Manga", 3.49),
            new Produto("Mel", 7.99),
            new Produto("Amendoim", 2.99),
            new Produto("Castanha", 9.99),
            new Produto("Amêndoa", 6.49),
            new Produto("Noz", 8.99),
            new Produto("Avelã", 5.99),
            new Produto("Pistache", 12.99),
            new Produto("Ervilha", 1.99),
            new Produto("Milho", 1.49),
            new Produto("Feijão Branco", 3.99),
            new Produto("Feijão Preto", 4.99),
            new Produto("Lentilha", 2.49),
            new Produto("Grão-de-bico", 3.49),
            new Produto("Amendoim Torrado", 4.99),
            new Produto("Amendoim Salgado", 3.99),
            new Produto("Caju", 5.99),
            new Produto("Castanha de Caju", 9.99),
            new Produto("Açaí", 6.99),
            new Produto("Mandioca", 2.99),
            new Produto("Farinha de Mandioca", 3.49),
            new Produto("Fubá", 1.99),
            new Produto("Farinha de Milho", 2.49),
            new Produto("Chocolate", 4.99),
            new Produto("Chocolate Branco", 5.99),
            new Produto("Chocolate ao Leite", 4.49),
            new Produto("Chocolate Amargo", 5.49),
            new Produto("Chocolate Meio Amargo", 4.99),
            new Produto("Chocolate Diet", 6.99),
            new Produto("Creme de Leite", 2.99),
            new Produto("Leite Condensado", 3.99),
            new Produto("Leite em Pó", 4.49),
            new Produto("Iogurte", 2.49),
            new Produto("Iogurte Grego", 3.49),
            new Produto("Iogurte Natural", 2.99),
            new Produto("Suco de Laranja", 5.99),
            new Produto("Suco de Uva", 4.99),
            new Produto("Suco de Maçã", 4.99),
            new Produto("Suco de Morango", 4.99),
            new Produto("Refrigerante", 3.49),
            new Produto("Refrigerante de Cola", 2.99),
            new Produto("Refrigerante de Limão", 2.99),
            new Produto("Refrigerante de Guaraná", 2.99),
            new Produto("Refrigerante de Laranja", 2.99)
};
        public double soma;

        public Exercicio4()
        {
            InitializeComponent();
        }

        private void ChangeBackColor_Click(object sender, EventArgs e)
        {
            Configs.ChangeBackColorWithColorDialog(this);
        }

        private void Exercicio4_Load(object sender, EventArgs e)
        {
            int count = 0;
            foreach (CheckBox ckb in PnlCheckBox.Controls)
            {
                ckb.CheckedChanged += new EventHandler(this.CheckedCkbProd);
            }

            foreach (CheckBox ckb in PnlCheckBox.Controls)
            {
                ckb.Name = $"CheckBox{produtos[count].Name}";
                ckb.Text = $"{produtos[count].Name}";
                count++;
            }
        }

        private void CheckedCkbProd(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            Produto produto = produtos.FirstOrDefault(p => p.Name == checkBox.Text);
            if (checkBox.Checked)
            {
                produtosComprados.Add(produto);
                soma += produto.Price;
            }
            else if (!(checkBox.Checked))
            {
                produtosComprados.Remove(produto);
                soma -= produto.Price;
            }
            LblOutPut.Text = "Preço total: " + soma.ToString("C");
        }
        private void BtnBuy_Click(object sender, EventArgs e)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("NÃO É VALÍDO COMO NOTA FISCAL");
            stringBuilder.AppendLine();
            stringBuilder.AppendLine("Items Comprados: ");
            stringBuilder.AppendLine();
            foreach (Produto produto in produtosComprados)
            {
                stringBuilder.AppendLine(produto.Name);
            }
            stringBuilder.AppendLine();
            stringBuilder.AppendLine("Valor final: " + soma.ToString("C"));
            MessageBox.Show(stringBuilder.ToString());
            Configs.BackAtPrincipalPage(this);
        }
    }
}
