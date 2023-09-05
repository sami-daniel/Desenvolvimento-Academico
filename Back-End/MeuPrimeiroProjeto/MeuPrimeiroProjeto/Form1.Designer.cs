namespace MeuPrimeiroProjeto
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
            this.btncaucular = new System.Windows.Forms.Button();
            this.lbl2 = new System.Windows.Forms.Label();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt3 = new System.Windows.Forms.TextBox();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lblmedia = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtsoma = new System.Windows.Forms.TextBox();
            this.txtmedia = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(102, 34);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(208, 21);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Digite um número inteiro:";
            this.lbl1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(51, 58);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(300, 20);
            this.txt1.TabIndex = 4;
            this.txt1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btncaucular
            // 
            this.btncaucular.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btncaucular.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btncaucular.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncaucular.Location = new System.Drawing.Point(12, 12);
            this.btncaucular.Name = "btncaucular";
            this.btncaucular.Size = new System.Drawing.Size(78, 39);
            this.btncaucular.TabIndex = 2;
            this.btncaucular.Text = "Caucular";
            this.btncaucular.UseVisualStyleBackColor = false;
            this.btncaucular.Click += new System.EventHandler(this.btncaucular_Click);
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.Location = new System.Drawing.Point(102, 81);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(225, 21);
            this.lbl2.TabIndex = 3;
            this.lbl2.Text = "Digite outro número inteiro:";
            this.lbl2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(51, 110);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(300, 20);
            this.txt2.TabIndex = 4;
            this.txt2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(191, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 20);
            this.label3.TabIndex = 5;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txt3
            // 
            this.txt3.Location = new System.Drawing.Point(51, 157);
            this.txt3.Name = "txt3";
            this.txt3.Size = new System.Drawing.Size(300, 20);
            this.txt3.TabIndex = 7;
            this.txt3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt3.TextChanged += new System.EventHandler(this.txt3_TextChanged);
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3.Location = new System.Drawing.Point(102, 133);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(225, 21);
            this.lbl3.TabIndex = 8;
            this.lbl3.Text = "Digite outro número inteiro:";
            this.lbl3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblmedia
            // 
            this.lblmedia.AutoSize = true;
            this.lblmedia.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmedia.Location = new System.Drawing.Point(119, 253);
            this.lblmedia.Name = "lblmedia";
            this.lblmedia.Size = new System.Drawing.Size(166, 21);
            this.lblmedia.TabIndex = 10;
            this.lblmedia.Text = "Média dos números:";
            this.lblmedia.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(150, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 21);
            this.label4.TabIndex = 11;
            this.label4.Text = "Soma total:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtsoma
            // 
            this.txtsoma.Location = new System.Drawing.Point(51, 236);
            this.txtsoma.Name = "txtsoma";
            this.txtsoma.Size = new System.Drawing.Size(300, 20);
            this.txtsoma.TabIndex = 12;
            this.txtsoma.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtmedia
            // 
            this.txtmedia.Location = new System.Drawing.Point(51, 277);
            this.txtmedia.Name = "txtmedia";
            this.txtmedia.Size = new System.Drawing.Size(300, 20);
            this.txtmedia.TabIndex = 13;
            this.txtmedia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(405, 330);
            this.Controls.Add(this.txtmedia);
            this.Controls.Add(this.txtsoma);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblmedia);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.txt3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.btncaucular);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.lbl1);
            this.Name = "Form1";
            this.Text = "Soma dois números";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.Button btncaucular;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt3;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lblmedia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtsoma;
        private System.Windows.Forms.TextBox txtmedia;
    }
}

