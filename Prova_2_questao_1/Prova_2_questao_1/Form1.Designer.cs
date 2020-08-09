namespace Prova_2_questao_1
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
            this.label1 = new System.Windows.Forms.Label();
            this.textFila = new System.Windows.Forms.TextBox();
            this.Binsere = new System.Windows.Forms.Button();
            this.Bremove = new System.Windows.Forms.Button();
            this.Bimprime = new System.Windows.Forms.Button();
            this.Bmaior = new System.Windows.Forms.Button();
            this.Bmenor = new System.Windows.Forms.Button();
            this.Binverte = new System.Windows.Forms.Button();
            this.Btamanho = new System.Windows.Forms.Button();
            this.textInsere = new System.Windows.Forms.TextBox();
            this.textRemove = new System.Windows.Forms.TextBox();
            this.textTamanho = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fila:";
            // 
            // textFila
            // 
            this.textFila.Location = new System.Drawing.Point(63, 30);
            this.textFila.Name = "textFila";
            this.textFila.Size = new System.Drawing.Size(273, 20);
            this.textFila.TabIndex = 1;
            // 
            // Binsere
            // 
            this.Binsere.Location = new System.Drawing.Point(63, 67);
            this.Binsere.Name = "Binsere";
            this.Binsere.Size = new System.Drawing.Size(75, 23);
            this.Binsere.TabIndex = 2;
            this.Binsere.Text = "INSERE";
            this.Binsere.UseVisualStyleBackColor = true;
            this.Binsere.Click += new System.EventHandler(this.Binsere_Click);
            // 
            // Bremove
            // 
            this.Bremove.Location = new System.Drawing.Point(63, 96);
            this.Bremove.Name = "Bremove";
            this.Bremove.Size = new System.Drawing.Size(75, 23);
            this.Bremove.TabIndex = 3;
            this.Bremove.Text = "REMOVE";
            this.Bremove.UseVisualStyleBackColor = true;
            // 
            // Bimprime
            // 
            this.Bimprime.Location = new System.Drawing.Point(63, 125);
            this.Bimprime.Name = "Bimprime";
            this.Bimprime.Size = new System.Drawing.Size(75, 23);
            this.Bimprime.TabIndex = 4;
            this.Bimprime.Text = "IMPRIME";
            this.Bimprime.UseVisualStyleBackColor = true;
            this.Bimprime.Click += new System.EventHandler(this.Bimprime_Click);
            // 
            // Bmaior
            // 
            this.Bmaior.Location = new System.Drawing.Point(63, 154);
            this.Bmaior.Name = "Bmaior";
            this.Bmaior.Size = new System.Drawing.Size(75, 23);
            this.Bmaior.TabIndex = 5;
            this.Bmaior.Text = "MAIOR";
            this.Bmaior.UseVisualStyleBackColor = true;
            this.Bmaior.Click += new System.EventHandler(this.Bmaior_Click);
            // 
            // Bmenor
            // 
            this.Bmenor.Location = new System.Drawing.Point(63, 183);
            this.Bmenor.Name = "Bmenor";
            this.Bmenor.Size = new System.Drawing.Size(75, 23);
            this.Bmenor.TabIndex = 6;
            this.Bmenor.Text = "MENOR";
            this.Bmenor.UseVisualStyleBackColor = true;
            this.Bmenor.Click += new System.EventHandler(this.Bmenor_Click);
            // 
            // Binverte
            // 
            this.Binverte.Location = new System.Drawing.Point(63, 212);
            this.Binverte.Name = "Binverte";
            this.Binverte.Size = new System.Drawing.Size(75, 23);
            this.Binverte.TabIndex = 7;
            this.Binverte.Text = "INVERTE";
            this.Binverte.UseVisualStyleBackColor = true;
            this.Binverte.Click += new System.EventHandler(this.Binverte_Click);
            // 
            // Btamanho
            // 
            this.Btamanho.Location = new System.Drawing.Point(63, 241);
            this.Btamanho.Name = "Btamanho";
            this.Btamanho.Size = new System.Drawing.Size(75, 23);
            this.Btamanho.TabIndex = 8;
            this.Btamanho.Text = "TAMANHO";
            this.Btamanho.UseVisualStyleBackColor = true;
            this.Btamanho.Click += new System.EventHandler(this.Btamanho_Click);
            // 
            // textInsere
            // 
            this.textInsere.Location = new System.Drawing.Point(144, 69);
            this.textInsere.Name = "textInsere";
            this.textInsere.Size = new System.Drawing.Size(78, 20);
            this.textInsere.TabIndex = 9;
            this.textInsere.TextChanged += new System.EventHandler(this.TextInsere_TextChanged);
            // 
            // textRemove
            // 
            this.textRemove.Location = new System.Drawing.Point(144, 98);
            this.textRemove.Name = "textRemove";
            this.textRemove.Size = new System.Drawing.Size(78, 20);
            this.textRemove.TabIndex = 10;
            // 
            // textTamanho
            // 
            this.textTamanho.Location = new System.Drawing.Point(144, 241);
            this.textTamanho.Name = "textTamanho";
            this.textTamanho.Size = new System.Drawing.Size(78, 20);
            this.textTamanho.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 279);
            this.Controls.Add(this.textTamanho);
            this.Controls.Add(this.textRemove);
            this.Controls.Add(this.textInsere);
            this.Controls.Add(this.Btamanho);
            this.Controls.Add(this.Binverte);
            this.Controls.Add(this.Bmenor);
            this.Controls.Add(this.Bmaior);
            this.Controls.Add(this.Bimprime);
            this.Controls.Add(this.Bremove);
            this.Controls.Add(this.Binsere);
            this.Controls.Add(this.textFila);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textFila;
        private System.Windows.Forms.Button Binsere;
        private System.Windows.Forms.Button Bremove;
        private System.Windows.Forms.Button Bimprime;
        private System.Windows.Forms.Button Bmaior;
        private System.Windows.Forms.Button Bmenor;
        private System.Windows.Forms.Button Binverte;
        private System.Windows.Forms.Button Btamanho;
        private System.Windows.Forms.TextBox textInsere;
        private System.Windows.Forms.TextBox textRemove;
        private System.Windows.Forms.TextBox textTamanho;
    }
}

