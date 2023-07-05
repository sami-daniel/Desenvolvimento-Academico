namespace TrabalhoSegundaEtapa.Views
{
    partial class Exercicio3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LblOrder = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.RdbYellow = new System.Windows.Forms.RadioButton();
            this.RdbBlue = new System.Windows.Forms.RadioButton();
            this.RdbRed = new System.Windows.Forms.RadioButton();
            this.BtnColorDialog = new System.Windows.Forms.Button();
            this.BtnBackAtPrincPage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblOrder
            // 
            this.LblOrder.AutoSize = true;
            this.LblOrder.Font = new System.Drawing.Font("AntiHero", 15.79F, System.Drawing.FontStyle.Bold);
            this.LblOrder.Location = new System.Drawing.Point(78, 35);
            this.LblOrder.Name = "LblOrder";
            this.LblOrder.Size = new System.Drawing.Size(803, 19);
            this.LblOrder.TabIndex = 2;
            this.LblOrder.Text = "Selecione uma opcao para trocar o background da janela";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(443, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Cores padrão:";
            // 
            // RdbYellow
            // 
            this.RdbYellow.AutoSize = true;
            this.RdbYellow.Location = new System.Drawing.Point(333, 168);
            this.RdbYellow.Name = "RdbYellow";
            this.RdbYellow.Size = new System.Drawing.Size(63, 17);
            this.RdbYellow.TabIndex = 4;
            this.RdbYellow.TabStop = true;
            this.RdbYellow.Text = "Amarelo";
            this.RdbYellow.UseVisualStyleBackColor = true;
            this.RdbYellow.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // RdbBlue
            // 
            this.RdbBlue.AutoSize = true;
            this.RdbBlue.Location = new System.Drawing.Point(470, 168);
            this.RdbBlue.Name = "RdbBlue";
            this.RdbBlue.Size = new System.Drawing.Size(45, 17);
            this.RdbBlue.TabIndex = 5;
            this.RdbBlue.TabStop = true;
            this.RdbBlue.Text = "Azul";
            this.RdbBlue.UseVisualStyleBackColor = true;
            this.RdbBlue.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // RdbRed
            // 
            this.RdbRed.AutoSize = true;
            this.RdbRed.Location = new System.Drawing.Point(620, 168);
            this.RdbRed.Name = "RdbRed";
            this.RdbRed.Size = new System.Drawing.Size(69, 17);
            this.RdbRed.TabIndex = 6;
            this.RdbRed.TabStop = true;
            this.RdbRed.Text = "Vermelho";
            this.RdbRed.UseVisualStyleBackColor = true;
            this.RdbRed.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // BtnColorDialog
            // 
            this.BtnColorDialog.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnColorDialog.Location = new System.Drawing.Point(376, 354);
            this.BtnColorDialog.Name = "BtnColorDialog";
            this.BtnColorDialog.Size = new System.Drawing.Size(271, 41);
            this.BtnColorDialog.TabIndex = 8;
            this.BtnColorDialog.Text = "Mudar cor de fundo";
            this.BtnColorDialog.UseVisualStyleBackColor = true;
            this.BtnColorDialog.Click += new System.EventHandler(this.BtnColorDialog_Click);
            // 
            // BtnBackAtPrincPage
            // 
            this.BtnBackAtPrincPage.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBackAtPrincPage.Location = new System.Drawing.Point(470, 412);
            this.BtnBackAtPrincPage.Name = "BtnBackAtPrincPage";
            this.BtnBackAtPrincPage.Size = new System.Drawing.Size(75, 23);
            this.BtnBackAtPrincPage.TabIndex = 9;
            this.BtnBackAtPrincPage.Text = "Voltar";
            this.BtnBackAtPrincPage.UseVisualStyleBackColor = true;
            this.BtnBackAtPrincPage.Click += new System.EventHandler(this.BtnBackAtPrincPage_Click);
            // 
            // Exercicio3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(967, 538);
            this.Controls.Add(this.BtnBackAtPrincPage);
            this.Controls.Add(this.BtnColorDialog);
            this.Controls.Add(this.RdbRed);
            this.Controls.Add(this.RdbBlue);
            this.Controls.Add(this.RdbYellow);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LblOrder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Exercicio3";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Exercicio3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblOrder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton RdbYellow;
        private System.Windows.Forms.RadioButton RdbBlue;
        private System.Windows.Forms.RadioButton RdbRed;
        private System.Windows.Forms.Button BtnColorDialog;
        private System.Windows.Forms.Button BtnBackAtPrincPage;
    }
}