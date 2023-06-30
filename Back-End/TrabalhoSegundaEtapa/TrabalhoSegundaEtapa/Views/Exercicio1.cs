﻿using System;
using System.Windows.Forms;
using TrabalhoSegundaEtapa.Functions;

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
                Code.AddItemsOnListBox(ListBoxEx1, byte.Parse(CbStartIndex.GetItemText(CbStartIndex.SelectedItem)), byte.Parse(CbEndIndex.GetItemText(CbEndIndex.SelectedItem)));
            }
        }

        private void CbEndIndex_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CbStartIndex.SelectedIndex != -1 && CbEndIndex.SelectedIndex != -1)
            {
                Code.AddItemsOnListBox(ListBoxEx1, byte.Parse(CbStartIndex.GetItemText(CbStartIndex.SelectedItem)), byte.Parse(CbEndIndex.GetItemText(CbEndIndex.SelectedItem)));
            }
        }
    }
}