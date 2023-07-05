using System;
using System.Windows.Forms;
using TrabalhoSegundaEtapa.Functions;
using TrabalhoSegundaEtapa.Views.Functions;

namespace TrabalhoSegundaEtapa.Views
{
    public partial class Exercicio1 : Form
    {
        public Exercicio1()
        {
            InitializeComponent();
        }

        private void CbStartIndex_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CbStartIndex.SelectedIndex != -1 && CbEndIndex.SelectedIndex != -1)
            {
                PrinterExerciseOne.AddItemsOnListBox(ListBoxEx1, byte.Parse(CbStartIndex.GetItemText(CbStartIndex.SelectedItem)), byte.Parse(CbEndIndex.GetItemText(CbEndIndex.SelectedItem)));
            }
        }

        private void CbEndIndex_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CbStartIndex.SelectedIndex != -1 && CbEndIndex.SelectedIndex != -1)
            {
                PrinterExerciseOne.AddItemsOnListBox(ListBoxEx1, byte.Parse(CbStartIndex.GetItemText(CbStartIndex.SelectedItem)), byte.Parse(CbEndIndex.GetItemText(CbEndIndex.SelectedItem)));
            }
        }

        private void BtnBackAtPrincPage_Click(object sender, EventArgs e)
        {
            Configs.BackAtPrincipalPage(this);
        }

        private void ChangeBackColor_Click(object sender, EventArgs e)
        {
            Configs.ChangeBackColorWithColorDialog(this);
        }
    }
}
