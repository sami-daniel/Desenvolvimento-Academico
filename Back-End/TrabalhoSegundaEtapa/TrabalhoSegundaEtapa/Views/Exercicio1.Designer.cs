namespace TrabalhoSegundaEtapa.Views
{
    partial class Exercicio1
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
            this.CbStartIndex = new System.Windows.Forms.ComboBox();
            this.CbEndIndex = new System.Windows.Forms.ComboBox();
            this.ListBoxEx1 = new System.Windows.Forms.ListBox();
            this.LblStartIndex = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnBackAtPrincPage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CbStartIndex
            // 
            this.CbStartIndex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbStartIndex.FormattingEnabled = true;
            this.CbStartIndex.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.CbStartIndex.Location = new System.Drawing.Point(12, 41);
            this.CbStartIndex.Name = "CbStartIndex";
            this.CbStartIndex.Size = new System.Drawing.Size(121, 21);
            this.CbStartIndex.TabIndex = 0;
            this.CbStartIndex.SelectedIndexChanged += new System.EventHandler(this.CbStartIndex_SelectedIndexChanged);
            // 
            // CbEndIndex
            // 
            this.CbEndIndex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbEndIndex.FormattingEnabled = true;
            this.CbEndIndex.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.CbEndIndex.Location = new System.Drawing.Point(647, 41);
            this.CbEndIndex.Name = "CbEndIndex";
            this.CbEndIndex.Size = new System.Drawing.Size(141, 21);
            this.CbEndIndex.TabIndex = 1;
            this.CbEndIndex.SelectedIndexChanged += new System.EventHandler(this.CbEndIndex_SelectedIndexChanged);
            // 
            // ListBoxEx1
            // 
            this.ListBoxEx1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListBoxEx1.FormattingEnabled = true;
            this.ListBoxEx1.ItemHeight = 19;
            this.ListBoxEx1.Location = new System.Drawing.Point(12, 120);
            this.ListBoxEx1.MultiColumn = true;
            this.ListBoxEx1.Name = "ListBoxEx1";
            this.ListBoxEx1.Size = new System.Drawing.Size(776, 308);
            this.ListBoxEx1.TabIndex = 2;
            // 
            // LblStartIndex
            // 
            this.LblStartIndex.AutoSize = true;
            this.LblStartIndex.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblStartIndex.Location = new System.Drawing.Point(12, 17);
            this.LblStartIndex.Name = "LblStartIndex";
            this.LblStartIndex.Size = new System.Drawing.Size(125, 21);
            this.LblStartIndex.TabIndex = 3;
            this.LblStartIndex.Text = "Indíce de ínicio";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(643, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "Indíce de terminó";
            // 
            // BtnBackAtPrincPage
            // 
            this.BtnBackAtPrincPage.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBackAtPrincPage.Location = new System.Drawing.Point(713, 434);
            this.BtnBackAtPrincPage.Name = "BtnBackAtPrincPage";
            this.BtnBackAtPrincPage.Size = new System.Drawing.Size(75, 23);
            this.BtnBackAtPrincPage.TabIndex = 5;
            this.BtnBackAtPrincPage.Text = "Voltar";
            this.BtnBackAtPrincPage.UseVisualStyleBackColor = true;
            this.BtnBackAtPrincPage.Click += new System.EventHandler(this.BtnBackAtPrincPage_Click);
            // 
            // Exercicio1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(800, 470);
            this.Controls.Add(this.BtnBackAtPrincPage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LblStartIndex);
            this.Controls.Add(this.ListBoxEx1);
            this.Controls.Add(this.CbEndIndex);
            this.Controls.Add(this.CbStartIndex);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Exercicio1";
            this.ShowIcon = false;
            this.Text = "Exercicio1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CbStartIndex;
        private System.Windows.Forms.ComboBox CbEndIndex;
        private System.Windows.Forms.ListBox ListBoxEx1;
        private System.Windows.Forms.Label LblStartIndex;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnBackAtPrincPage;
    }
}