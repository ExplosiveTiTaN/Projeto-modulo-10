namespace Trabalho_Projeto
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.anoText = new System.Windows.Forms.TextBox();
            this.marcaText = new System.Windows.Forms.TextBox();
            this.modeloText = new System.Windows.Forms.TextBox();
            this.preçoText = new System.Windows.Forms.TextBox();
            this.velocidadeText = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(392, 78);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 47);
            this.button1.TabIndex = 0;
            this.button1.Text = "Criar Carro";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Criar carro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ano";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Marca";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Modelo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Preço";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(46, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Velocidade";
            // 
            // anoText
            // 
            this.anoText.Location = new System.Drawing.Point(175, 56);
            this.anoText.Name = "anoText";
            this.anoText.Size = new System.Drawing.Size(100, 20);
            this.anoText.TabIndex = 7;
            // 
            // marcaText
            // 
            this.marcaText.Location = new System.Drawing.Point(175, 88);
            this.marcaText.Name = "marcaText";
            this.marcaText.Size = new System.Drawing.Size(100, 20);
            this.marcaText.TabIndex = 8;
            // 
            // modeloText
            // 
            this.modeloText.Location = new System.Drawing.Point(175, 126);
            this.modeloText.Name = "modeloText";
            this.modeloText.Size = new System.Drawing.Size(100, 20);
            this.modeloText.TabIndex = 9;
            // 
            // preçoText
            // 
            this.preçoText.Location = new System.Drawing.Point(175, 161);
            this.preçoText.Name = "preçoText";
            this.preçoText.Size = new System.Drawing.Size(100, 20);
            this.preçoText.TabIndex = 10;
            // 
            // velocidadeText
            // 
            this.velocidadeText.Location = new System.Drawing.Point(175, 201);
            this.velocidadeText.Name = "velocidadeText";
            this.velocidadeText.Size = new System.Drawing.Size(100, 20);
            this.velocidadeText.TabIndex = 11;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(1, 265);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(558, 20);
            this.textBox6.TabIndex = 12;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(392, 184);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 47);
            this.button2.TabIndex = 13;
            this.button2.Text = "Criar outro Carro";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 517);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.velocidadeText);
            this.Controls.Add(this.preçoText);
            this.Controls.Add(this.modeloText);
            this.Controls.Add(this.marcaText);
            this.Controls.Add(this.anoText);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox anoText;
        private System.Windows.Forms.TextBox marcaText;
        private System.Windows.Forms.TextBox modeloText;
        private System.Windows.Forms.TextBox preçoText;
        private System.Windows.Forms.TextBox velocidadeText;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Button button2;
    }
}

