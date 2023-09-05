namespace Ex01pag08
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
            this.lbl1 = new System.Windows.Forms.Label();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt3 = new System.Windows.Forms.TextBox();
            this.btnClean = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.lblsomarrr = new System.Windows.Forms.Label();
            this.lblmediar = new System.Windows.Forms.Label();
            this.Caucular = new System.Windows.Forms.Button();
            this.lblmedia = new System.Windows.Forms.Label();
            this.lblsoma = new System.Windows.Forms.Label();
            this.lblpor1 = new System.Windows.Forms.Label();
            this.lblpor2 = new System.Windows.Forms.Label();
            this.lblpor3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft YaHei Light", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(12, 9);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(153, 21);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Digite o 1º número:";
            this.lbl1.Click += new System.EventHandler(this.lbl1_Click);
            // 
            // txt1
            // 
            this.txt1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txt1.Location = new System.Drawing.Point(16, 33);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(145, 20);
            this.txt1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei Light", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Digite o 2º número:";
            // 
            // txt2
            // 
            this.txt2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txt2.Location = new System.Drawing.Point(16, 80);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(145, 20);
            this.txt2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei Light", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Digite o 3º número:";
            // 
            // txt3
            // 
            this.txt3.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txt3.Location = new System.Drawing.Point(16, 127);
            this.txt3.Name = "txt3";
            this.txt3.Size = new System.Drawing.Size(145, 20);
            this.txt3.TabIndex = 5;
            // 
            // btnClean
            // 
            this.btnClean.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClean.Location = new System.Drawing.Point(183, 309);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(81, 24);
            this.btnClean.TabIndex = 6;
            this.btnClean.Text = "Limpar";
            this.btnClean.UseVisualStyleBackColor = true;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(270, 309);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(81, 24);
            this.btnSair.TabIndex = 7;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            // 
            // lblsomarrr
            // 
            this.lblsomarrr.AutoSize = true;
            this.lblsomarrr.Font = new System.Drawing.Font("Microsoft YaHei Light", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsomarrr.Location = new System.Drawing.Point(12, 282);
            this.lblsomarrr.Name = "lblsomarrr";
            this.lblsomarrr.Size = new System.Drawing.Size(0, 21);
            this.lblsomarrr.TabIndex = 13;
            // 
            // lblmediar
            // 
            this.lblmediar.AutoSize = true;
            this.lblmediar.Font = new System.Drawing.Font("Microsoft YaHei Light", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmediar.Location = new System.Drawing.Point(12, 319);
            this.lblmediar.Name = "lblmediar";
            this.lblmediar.Size = new System.Drawing.Size(0, 21);
            this.lblmediar.TabIndex = 14;
            // 
            // Caucular
            // 
            this.Caucular.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Caucular.Location = new System.Drawing.Point(226, 279);
            this.Caucular.Name = "Caucular";
            this.Caucular.Size = new System.Drawing.Size(81, 24);
            this.Caucular.TabIndex = 15;
            this.Caucular.Text = "Calcular";
            this.Caucular.UseVisualStyleBackColor = true;
            this.Caucular.Click += new System.EventHandler(this.Caucular_Click);
            // 
            // lblmedia
            // 
            this.lblmedia.AutoSize = true;
            this.lblmedia.Font = new System.Drawing.Font("Microsoft YaHei Light", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmedia.Location = new System.Drawing.Point(206, 33);
            this.lblmedia.Name = "lblmedia";
            this.lblmedia.Size = new System.Drawing.Size(65, 21);
            this.lblmedia.TabIndex = 16;
            this.lblmedia.Text = "Média: ";
            this.lblmedia.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblsoma
            // 
            this.lblsoma.AutoSize = true;
            this.lblsoma.Font = new System.Drawing.Font("Microsoft YaHei Light", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsoma.Location = new System.Drawing.Point(203, 77);
            this.lblsoma.Name = "lblsoma";
            this.lblsoma.Size = new System.Drawing.Size(61, 21);
            this.lblsoma.TabIndex = 17;
            this.lblsoma.Text = "Soma: ";
            this.lblsoma.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // lblpor1
            // 
            this.lblpor1.AutoSize = true;
            this.lblpor1.Font = new System.Drawing.Font("Microsoft YaHei Light", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpor1.Location = new System.Drawing.Point(203, 113);
            this.lblpor1.Name = "lblpor1";
            this.lblpor1.Size = new System.Drawing.Size(128, 21);
            this.lblpor1.TabIndex = 18;
            this.lblpor1.Text = "Porcentagem 1: ";
            this.lblpor1.Click += new System.EventHandler(this.label3_Click_2);
            // 
            // lblpor2
            // 
            this.lblpor2.AutoSize = true;
            this.lblpor2.Font = new System.Drawing.Font("Microsoft YaHei Light", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpor2.Location = new System.Drawing.Point(203, 157);
            this.lblpor2.Name = "lblpor2";
            this.lblpor2.Size = new System.Drawing.Size(131, 21);
            this.lblpor2.TabIndex = 19;
            this.lblpor2.Text = "Porcentagem 2: ";
            // 
            // lblpor3
            // 
            this.lblpor3.AutoSize = true;
            this.lblpor3.Font = new System.Drawing.Font("Microsoft YaHei Light", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpor3.Location = new System.Drawing.Point(203, 204);
            this.lblpor3.Name = "lblpor3";
            this.lblpor3.Size = new System.Drawing.Size(131, 21);
            this.lblpor3.TabIndex = 20;
            this.lblpor3.Text = "Porcentagem 3: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.lblpor3);
            this.Controls.Add(this.lblpor2);
            this.Controls.Add(this.lblpor1);
            this.Controls.Add(this.lblsoma);
            this.Controls.Add(this.lblmedia);
            this.Controls.Add(this.Caucular);
            this.Controls.Add(this.lblmediar);
            this.Controls.Add(this.lblsomarrr);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.txt3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.lbl1);
            this.Name = "Form1";
            this.Text = "Rotina";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt3;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label lblsomarrr;
        private System.Windows.Forms.Label lblmediar;
        private System.Windows.Forms.Button Caucular;
        private System.Windows.Forms.Label lblmedia;
        private System.Windows.Forms.Label lblsoma;
        private System.Windows.Forms.Label lblpor1;
        private System.Windows.Forms.Label lblpor2;
        private System.Windows.Forms.Label lblpor3;
    }
}

