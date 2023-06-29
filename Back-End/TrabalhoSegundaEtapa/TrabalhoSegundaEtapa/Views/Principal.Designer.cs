namespace TrabalhoSegundaEtapa
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.atividadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ViewExerciseOne = new System.Windows.Forms.ToolStripMenuItem();
            this.eXERCICIO2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eXERCICIO3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eXERCICIO4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuStrip
            // 
            this.MenuStrip.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.atividadesToolStripMenuItem});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(800, 28);
            this.MenuStrip.TabIndex = 0;
            this.MenuStrip.Text = "menuStrip1";
            // 
            // atividadesToolStripMenuItem
            // 
            this.atividadesToolStripMenuItem.BackColor = System.Drawing.Color.Khaki;
            this.atividadesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ViewExerciseOne,
            this.eXERCICIO2ToolStripMenuItem,
            this.eXERCICIO3ToolStripMenuItem,
            this.eXERCICIO4ToolStripMenuItem});
            this.atividadesToolStripMenuItem.Name = "atividadesToolStripMenuItem";
            this.atividadesToolStripMenuItem.Size = new System.Drawing.Size(116, 24);
            this.atividadesToolStripMenuItem.Text = "Atividades";
            // 
            // ViewExerciseOne
            // 
            this.ViewExerciseOne.Name = "ViewExerciseOne";
            this.ViewExerciseOne.Size = new System.Drawing.Size(180, 24);
            this.ViewExerciseOne.Text = "EXERCICIO 1";
            this.ViewExerciseOne.Click += new System.EventHandler(this.ViewExerciseOne_Click);
            // 
            // eXERCICIO2ToolStripMenuItem
            // 
            this.eXERCICIO2ToolStripMenuItem.Name = "eXERCICIO2ToolStripMenuItem";
            this.eXERCICIO2ToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.eXERCICIO2ToolStripMenuItem.Text = "EXERCICIO 2";
            // 
            // eXERCICIO3ToolStripMenuItem
            // 
            this.eXERCICIO3ToolStripMenuItem.Name = "eXERCICIO3ToolStripMenuItem";
            this.eXERCICIO3ToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.eXERCICIO3ToolStripMenuItem.Text = "EXERCICIO 3";
            // 
            // eXERCICIO4ToolStripMenuItem
            // 
            this.eXERCICIO4ToolStripMenuItem.Name = "eXERCICIO4ToolStripMenuItem";
            this.eXERCICIO4ToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.eXERCICIO4ToolStripMenuItem.Text = "EXERCICIO 4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MenuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.MenuStrip;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem atividadesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ViewExerciseOne;
        private System.Windows.Forms.ToolStripMenuItem eXERCICIO2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eXERCICIO3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eXERCICIO4ToolStripMenuItem;
    }
}

