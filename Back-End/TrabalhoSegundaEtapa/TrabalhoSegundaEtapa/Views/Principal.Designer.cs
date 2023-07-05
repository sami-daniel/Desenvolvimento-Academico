namespace TrabalhoSegundaEtapa
{
    partial class Principal
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
            this.ViewExerciseTwo = new System.Windows.Forms.ToolStripMenuItem();
            this.ViewExercise3 = new System.Windows.Forms.ToolStripMenuItem();
            this.ViewExercise4 = new System.Windows.Forms.ToolStripMenuItem();
            this.ChangeBackColor = new System.Windows.Forms.Button();
            this.MenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuStrip
            // 
            this.MenuStrip.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.atividadesToolStripMenuItem});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(1430, 33);
            this.MenuStrip.TabIndex = 0;
            this.MenuStrip.Text = "menuStrip1";
            // 
            // atividadesToolStripMenuItem
            // 
            this.atividadesToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.atividadesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ViewExerciseOne,
            this.ViewExerciseTwo,
            this.ViewExercise3,
            this.ViewExercise4});
            this.atividadesToolStripMenuItem.Name = "atividadesToolStripMenuItem";
            this.atividadesToolStripMenuItem.Size = new System.Drawing.Size(124, 29);
            this.atividadesToolStripMenuItem.Text = "Atividades";
            // 
            // ViewExerciseOne
            // 
            this.ViewExerciseOne.Name = "ViewExerciseOne";
            this.ViewExerciseOne.Size = new System.Drawing.Size(215, 30);
            this.ViewExerciseOne.Text = "EXERCICIO 1";
            this.ViewExerciseOne.Click += new System.EventHandler(this.ViewExerciseOne_Click);
            // 
            // ViewExerciseTwo
            // 
            this.ViewExerciseTwo.Name = "ViewExerciseTwo";
            this.ViewExerciseTwo.Size = new System.Drawing.Size(215, 30);
            this.ViewExerciseTwo.Text = "EXERCICIO 2";
            this.ViewExerciseTwo.Click += new System.EventHandler(this.ViewExerciseTwo_Click);
            // 
            // ViewExercise3
            // 
            this.ViewExercise3.Name = "ViewExercise3";
            this.ViewExercise3.Size = new System.Drawing.Size(215, 30);
            this.ViewExercise3.Text = "EXERCICIO 3";
            this.ViewExercise3.Click += new System.EventHandler(this.ViewExercise3_Click);
            // 
            // ViewExercise4
            // 
            this.ViewExercise4.Name = "ViewExercise4";
            this.ViewExercise4.Size = new System.Drawing.Size(215, 30);
            this.ViewExercise4.Text = "EXERCICIO 4";
            this.ViewExercise4.Click += new System.EventHandler(this.ViewExercise4_Click);
            // 
            // ChangeBackColor
            // 
            this.ChangeBackColor.Dock = System.Windows.Forms.DockStyle.Right;
            this.ChangeBackColor.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangeBackColor.Location = new System.Drawing.Point(1239, 33);
            this.ChangeBackColor.Name = "ChangeBackColor";
            this.ChangeBackColor.Size = new System.Drawing.Size(191, 597);
            this.ChangeBackColor.TabIndex = 8;
            this.ChangeBackColor.Text = "Mudar cor de fundo";
            this.ChangeBackColor.UseVisualStyleBackColor = true;
            this.ChangeBackColor.Click += new System.EventHandler(this.ChangeBackColor_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(1430, 630);
            this.Controls.Add(this.ChangeBackColor);
            this.Controls.Add(this.MenuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.MenuStrip;
            this.MaximizeBox = false;
            this.Name = "Principal";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
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
        private System.Windows.Forms.ToolStripMenuItem ViewExerciseTwo;
        private System.Windows.Forms.ToolStripMenuItem ViewExercise3;
        private System.Windows.Forms.ToolStripMenuItem ViewExercise4;
        private System.Windows.Forms.Button ChangeBackColor;
    }
}

