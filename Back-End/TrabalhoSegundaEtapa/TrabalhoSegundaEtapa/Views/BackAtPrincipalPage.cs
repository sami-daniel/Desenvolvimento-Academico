using System.Windows.Forms;

namespace TrabalhoSegundaEtapa.Views
{
    internal class BackAtPrincipalPage
    {
        public static void ButtonBackAtPrincipalPage(Form actualForm)
        {
            Principal formPrincipal = new Principal();
            formPrincipal.Show();
            actualForm.Hide();
        }
    }
}
