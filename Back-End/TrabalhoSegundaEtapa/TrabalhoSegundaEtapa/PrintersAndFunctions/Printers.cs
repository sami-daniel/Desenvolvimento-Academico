using System.Windows.Forms;

namespace TrabalhoSegundaEtapa.Functions
{
    class PrinterExerciseOne
    {
        public static ListBox AddItemsOnListBox(ListBox listBox, byte startIndex, byte endIndex)
        {
            listBox.Items.Clear();
            if (startIndex > endIndex)
            {
                //Verifica se o index inicial é maior que o final, caso verdadeiro
                //A repetição escreverá os valores no sentido contrario
                for (int i = startIndex; i >= endIndex; i--)
                {
                    listBox.Items.Add(i);
                }
                return listBox;
            }
            else
            {
                for (int i = startIndex; i <= endIndex; i++)
                {
                    listBox.Items.Add(i);
                }
                return listBox;
            }
        }
    }
}
