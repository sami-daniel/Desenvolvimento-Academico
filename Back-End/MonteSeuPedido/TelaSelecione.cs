using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonteSeuPedido
{
    public partial class TelaSelecione : Form
    {
        double total = 0;
        string obs;
        public TelaSelecione()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            this.Hide();
            MessageBox.Show($"Pedido enviado!\nObservação:{obs}\nPreço:{total.ToString("C")}");
            Form1 form = new Form1();
            form.Show();
        }

        private void chkAlface_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAlface.Checked)
            {
                lblTotal.Text = $"Total: {(total += 1.5).ToString("C")}";

            }
            else if (chkAlface.Checked == false)
            {
                lblTotal.Text = $"Total: {(total -= 1.5).ToString("C")}";
            }
        }

        private void chkCebola_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCebola.Checked)
            {
                lblTotal.Text = $"Total: {(total += 2.0).ToString("C")}";

            }
            else if (!chkCebola.Checked)
            {
                lblTotal.Text = $"Total: {(total -= 2.0).ToString("C")}";
            }
        }

        private void chkTomate_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTomate.Checked)
            {
                lblTotal.Text = $"Total: {(total += 3.5).ToString("C")}";
            }
            else if (!chkTomate.Checked)
            {
                lblTotal.Text = $"Total: {(total -= 3.5).ToString("C")}";
            }
        }

        private void chkPicles_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPicles.Checked)
            {
                lblTotal.Text = $"Total: {(total += 1.0).ToString("C")}";

            }
            else if (!chkPicles.Checked)
            {
                lblTotal.Text = $"Total: {(total -= 1.0).ToString("C")}";
            }
        }

        private void chkCebolaRoxa_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCebolaRoxa.Checked)
            {
                lblTotal.Text = $"Total: {(total += 2.5).ToString("C")}";

            }
            else if (!chkCebolaRoxa.Checked)
            {
                lblTotal.Text = $"Total: {(total -= 2.5).ToString("C")}";
            }
        }

        private void chkBarbecue_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBarbecue.Checked)
            {
                lblTotal.Text = $"Total: {(total += 4.25).ToString("C")}";

            }
            else if (!chkBarbecue.Checked)
            {
                lblTotal.Text = $"Total: {(total -= 4.25).ToString("C")}";
            }
        }

        private void chketchup_CheckedChanged(object sender, EventArgs e)
        {
            if (chketchup.Checked)
            {
                lblTotal.Text = $"Total: {(total += 3.25).ToString("C")}";

            }
            else if (!chketchup.Checked)
            {
                lblTotal.Text = $"Total: {(total -= 3.25).ToString("C")}";
            }
        }

        private void chkMostarda_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMostarda.Checked)
            {
                lblTotal.Text = $"Total: {(total += 6.55).ToString("C")}";

            }
            else if (!chkMostarda.Checked)
            {
                lblTotal.Text = $"Total: {(total -= 6.55).ToString("C")}";
            }
        }

        private void chkRose_CheckedChanged(object sender, EventArgs e)
        {
            if (chkRose.Checked)
            {
                lblTotal.Text = $"Total: {(total += 7.00).ToString("C")}";

            }
            else if (!chkRose.Checked)
            {
                lblTotal.Text = $"Total: {(total -= 7.00).ToString("C")}";
            }
        }

        private void rdbPaoComQueijo_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbPaoComQueijo.Checked)
            {
                lblTotal.Text = $"Total: {(total += 9.00).ToString("C")}";

            }
            else if (!rdbPaoComQueijo.Checked)
            {
                lblTotal.Text = $"Total: {(total -= 9.00).ToString("C")}";
            }
        }

        private void rdbPaoitaliano_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbPaoitaliano.Checked)
            {
                lblTotal.Text = $"Total: {(total += 12.00).ToString("C")}";

            }
            else if (!rdbPaoitaliano.Checked)
            {
                lblTotal.Text = $"Total: {(total -= 12.00).ToString("C")}";
            }
        }

        private void rdbBrioche_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbBrioche.Checked)
            {
                lblTotal.Text = $"Total: {(total += 17.26).ToString("C")}";

            }
            else if (!rdbBrioche.Checked)
            {
                lblTotal.Text = $"Total: {(total -= 17.26).ToString("C")}";
            }
        }

        private void rdbPaoAustraliano_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbPaoAustraliano.Checked)
            {
                lblTotal.Text = $"Total: {(total += 5.00).ToString("C")}";

            }
            else if (!rdbPaoAustraliano.Checked)
            {
                lblTotal.Text = $"Total: {(total -= 5.00).ToString("C")}";
            }
        }

        private void rdbPaodeAzeite_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbPaodeAzeite.Checked)
            {
                lblTotal.Text = $"Total: {(total += 21.00).ToString("C")}";

            }
            else if (!rdbPaodeAzeite.Checked)
            {
                lblTotal.Text = $"Total: {(total -= 21.00).ToString("C")}";
            }
        }

        private void rdbHambBoi_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbHambBoi.Checked)
            {
                lblTotal.Text = $"Total: {(total += 34.99).ToString("C")}";

            }
            else if (!rdbHambBoi.Checked)
            {
                lblTotal.Text = $"Total: {(total -= 34.99).ToString("C")}";
            }
        }

        private void rdbHamF_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbHamF.Checked)
            {
                lblTotal.Text = $"Total: {(total += 21.99).ToString("C")}";

            }
            else if (!rdbHamF.Checked)
            {
                lblTotal.Text = $"Total: {(total -= 21.99).ToString("C")}";
            }
        }

        private void TelaSelecione_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbSoja.Checked)
            {
                lblTotal.Text = $"Total: {(total += 32.00).ToString("C")}";

            }
            else if (!rdbSoja.Checked)
            {
                lblTotal.Text = $"Total: {(total -= 32.00).ToString("C")}";
            }
        }

        private void rdbPorco_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbPorco.Checked)
            {
                lblTotal.Text = $"Total: {(total += 11.99).ToString("C")}";

            }
            else if (!rdbPorco.Checked)
            {
                lblTotal.Text = $"Total: {(total -= 11.99).ToString("C")}";
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            obs = textBox1.Text;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
