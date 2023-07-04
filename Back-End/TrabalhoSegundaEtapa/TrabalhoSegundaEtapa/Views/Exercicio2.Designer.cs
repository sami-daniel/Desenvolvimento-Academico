namespace TrabalhoSegundaEtapa.Views
{
    partial class Exercicio2
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
            this.TxtInput = new System.Windows.Forms.TextBox();
            this.LblOrder = new System.Windows.Forms.Label();
            this.LblOutPut = new System.Windows.Forms.Label();
            this.RdbNormal = new System.Windows.Forms.RadioButton();
            this.RdbHipperText = new System.Windows.Forms.RadioButton();
            this.RdbLowerText = new System.Windows.Forms.RadioButton();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.BtnBackAtPrincPage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtInput
            // 
            this.TxtInput.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtInput.Location = new System.Drawing.Point(15, 75);
            this.TxtInput.Multiline = true;
            this.TxtInput.Name = "TxtInput";
            this.TxtInput.Size = new System.Drawing.Size(649, 161);
            this.TxtInput.TabIndex = 0;
            this.TxtInput.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtInput_KeyUp_1);
            // 
            // LblOrder
            // 
            this.LblOrder.AutoSize = true;
            this.LblOrder.Font = new System.Drawing.Font("AntiHero", 15.79F, System.Drawing.FontStyle.Bold);
            this.LblOrder.Location = new System.Drawing.Point(11, 40);
            this.LblOrder.Name = "LblOrder";
            this.LblOrder.Size = new System.Drawing.Size(656, 19);
            this.LblOrder.TabIndex = 1;
            this.LblOrder.Text = "Digite algo para que seja exibido em maiusculo";
            // 
            // LblOutPut
            // 
            this.LblOutPut.AutoSize = true;
            this.LblOutPut.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblOutPut.Location = new System.Drawing.Point(11, 276);
            this.LblOutPut.Name = "LblOutPut";
            this.LblOutPut.Size = new System.Drawing.Size(0, 25);
            this.LblOutPut.TabIndex = 2;
            // 
            // RdbNormal
            // 
            this.RdbNormal.AutoSize = true;
            this.RdbNormal.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RdbNormal.Location = new System.Drawing.Point(547, 286);
            this.RdbNormal.Name = "RdbNormal";
            this.RdbNormal.Size = new System.Drawing.Size(73, 23);
            this.RdbNormal.TabIndex = 3;
            this.RdbNormal.TabStop = true;
            this.RdbNormal.Text = "Normal";
            this.RdbNormal.UseVisualStyleBackColor = true;
            this.RdbNormal.CheckedChanged += new System.EventHandler(this.ChekedChanged);
            // 
            // RdbHipperText
            // 
            this.RdbHipperText.AutoSize = true;
            this.RdbHipperText.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RdbHipperText.Location = new System.Drawing.Point(547, 315);
            this.RdbHipperText.Name = "RdbHipperText";
            this.RdbHipperText.Size = new System.Drawing.Size(90, 23);
            this.RdbHipperText.TabIndex = 4;
            this.RdbHipperText.TabStop = true;
            this.RdbHipperText.Text = "Maiúsculo";
            this.RdbHipperText.UseVisualStyleBackColor = true;
            this.RdbHipperText.CheckedChanged += new System.EventHandler(this.ChekedChanged);
            // 
            // RdbLowerText
            // 
            this.RdbLowerText.AutoSize = true;
            this.RdbLowerText.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RdbLowerText.Location = new System.Drawing.Point(547, 344);
            this.RdbLowerText.Name = "RdbLowerText";
            this.RdbLowerText.Size = new System.Drawing.Size(91, 23);
            this.RdbLowerText.TabIndex = 5;
            this.RdbLowerText.TabStop = true;
            this.RdbLowerText.Text = "Minúsculo";
            this.RdbLowerText.UseVisualStyleBackColor = true;
            this.RdbLowerText.CheckedChanged += new System.EventHandler(this.ChekedChanged);
            // 
            // BtnBackAtPrincPage
            // 
            this.BtnBackAtPrincPage.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBackAtPrincPage.Location = new System.Drawing.Point(16, 372);
            this.BtnBackAtPrincPage.Name = "BtnBackAtPrincPage";
            this.BtnBackAtPrincPage.Size = new System.Drawing.Size(75, 23);
            this.BtnBackAtPrincPage.TabIndex = 6;
            this.BtnBackAtPrincPage.Text = "Voltar";
            this.BtnBackAtPrincPage.UseVisualStyleBackColor = true;
            this.BtnBackAtPrincPage.Click += new System.EventHandler(this.BtnBackAtPrincPage_Click);
            // 
            // Exercicio2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(676, 417);
            this.Controls.Add(this.BtnBackAtPrincPage);
            this.Controls.Add(this.RdbLowerText);
            this.Controls.Add(this.RdbHipperText);
            this.Controls.Add(this.RdbNormal);
            this.Controls.Add(this.LblOutPut);
            this.Controls.Add(this.LblOrder);
            this.Controls.Add(this.TxtInput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Exercicio2";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Exercicio2";
            this.Load += new System.EventHandler(this.Exercicio2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtInput;
        private System.Windows.Forms.Label LblOrder;
        private System.Windows.Forms.Label LblOutPut;
        private System.Windows.Forms.RadioButton RdbNormal;
        private System.Windows.Forms.RadioButton RdbHipperText;
        private System.Windows.Forms.RadioButton RdbLowerText;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button BtnBackAtPrincPage;
    }
}