using System.Windows.Forms;
using System;


namespace TrabalhoSegundaEtapa.Views.Functions
{
    internal class Configs : Form
    {
        internal static void BackAtPrincipalPage(Form actualForm)
        {
            Principal formPrincipal = new Principal();
            formPrincipal.Show();
            actualForm.Hide();
        }
        internal static void ChangeBackColorWithColorDialog(Form actualForm)
        {
            if(actualForm != null) 
            {
                ColorDialog colorDialog = new ColorDialog();
                if (DialogResult.OK == colorDialog.ShowDialog()) actualForm.BackColor = colorDialog.Color;
            }
            else
            {
                throw new ArgumentNullException(nameof(actualForm) + "Is null or Doesn'nt Exists");
            }
        }
    }
}
