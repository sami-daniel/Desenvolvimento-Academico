namespace Vendas
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtProd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrecU = new System.Windows.Forms.TextBox();
            this.lbl4 = new System.Windows.Forms.Label();
            this.bl3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtqntd = new System.Windows.Forms.TextBox();
            this.btnQntd = new System.Windows.Forms.Button();
            this.btnAddPrec = new System.Windows.Forms.Button();
            this.lblProd = new System.Windows.Forms.Label();
            this.lblprecU = new System.Windows.Forms.Label();
            this.lblqntd = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(12, 9);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(61, 16);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Produtos";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(521, 34);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "adicionar";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // txtProd
            // 
            this.txtProd.Location = new System.Drawing.Point(415, 36);
            this.txtProd.Name = "txtProd";
            this.txtProd.Size = new System.Drawing.Size(100, 20);
            this.txtProd.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(412, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Adicione os produtos:";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.Location = new System.Drawing.Point(104, 9);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(92, 16);
            this.lbl2.TabIndex = 4;
            this.lbl2.Text = "Preço Unitario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(412, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Adicione o preço unitario: ";
            // 
            // txtPrecU
            // 
            this.txtPrecU.Location = new System.Drawing.Point(415, 104);
            this.txtPrecU.Name = "txtPrecU";
            this.txtPrecU.Size = new System.Drawing.Size(100, 20);
            this.txtPrecU.TabIndex = 6;
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl4.Location = new System.Drawing.Point(300, 9);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(38, 16);
            this.lbl4.TabIndex = 8;
            this.lbl4.Text = "Total";
            // 
            // bl3
            // 
            this.bl3.AutoSize = true;
            this.bl3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bl3.Location = new System.Drawing.Point(202, 9);
            this.bl3.Name = "bl3";
            this.bl3.Size = new System.Drawing.Size(77, 16);
            this.bl3.TabIndex = 9;
            this.bl3.Text = "Quantidade";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(412, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(220, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Adicione a quantidade de produtos:";
            // 
            // txtqntd
            // 
            this.txtqntd.Location = new System.Drawing.Point(415, 180);
            this.txtqntd.Name = "txtqntd";
            this.txtqntd.Size = new System.Drawing.Size(100, 20);
            this.txtqntd.TabIndex = 11;
            // 
            // btnQntd
            // 
            this.btnQntd.Location = new System.Drawing.Point(521, 180);
            this.btnQntd.Name = "btnQntd";
            this.btnQntd.Size = new System.Drawing.Size(75, 23);
            this.btnQntd.TabIndex = 12;
            this.btnQntd.Text = "adicionar";
            this.btnQntd.UseVisualStyleBackColor = true;
            // 
            // btnAddPrec
            // 
            this.btnAddPrec.Location = new System.Drawing.Point(521, 101);
            this.btnAddPrec.Name = "btnAddPrec";
            this.btnAddPrec.Size = new System.Drawing.Size(75, 23);
            this.btnAddPrec.TabIndex = 7;
            this.btnAddPrec.Text = "adicionar";
            this.btnAddPrec.UseVisualStyleBackColor = true;
            // 
            // lblProd
            // 
            this.lblProd.AutoSize = true;
            this.lblProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProd.Location = new System.Drawing.Point(12, 34);
            this.lblProd.Name = "lblProd";
            this.lblProd.Size = new System.Drawing.Size(0, 16);
            this.lblProd.TabIndex = 13;
            // 
            // lblprecU
            // 
            this.lblprecU.AutoSize = true;
            this.lblprecU.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprecU.Location = new System.Drawing.Point(104, 34);
            this.lblprecU.Name = "lblprecU";
            this.lblprecU.Size = new System.Drawing.Size(0, 16);
            this.lblprecU.TabIndex = 14;
            // 
            // lblqntd
            // 
            this.lblqntd.AutoSize = true;
            this.lblqntd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblqntd.Location = new System.Drawing.Point(202, 34);
            this.lblqntd.Name = "lblqntd";
            this.lblqntd.Size = new System.Drawing.Size(0, 16);
            this.lblqntd.TabIndex = 15;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(300, 37);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(0, 16);
            this.lblTotal.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 481);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblqntd);
            this.Controls.Add(this.lblprecU);
            this.Controls.Add(this.lblProd);
            this.Controls.Add(this.btnQntd);
            this.Controls.Add(this.txtqntd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bl3);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.btnAddPrec);
            this.Controls.Add(this.txtPrecU);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtProd);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lbl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtProd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPrecU;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.Label bl3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtqntd;
        private System.Windows.Forms.Button btnQntd;
        private System.Windows.Forms.Button btnAddPrec;
        private System.Windows.Forms.Label lblProd;
        private System.Windows.Forms.Label lblprecU;
        private System.Windows.Forms.Label lblqntd;
        private System.Windows.Forms.Label lblTotal;
    }
}

