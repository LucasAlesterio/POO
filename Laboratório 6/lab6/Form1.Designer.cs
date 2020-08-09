namespace lab6
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
            this.TextLista = new System.Windows.Forms.TextBox();
            this.insere = new System.Windows.Forms.Button();
            this.remove = new System.Windows.Forms.Button();
            this.maior = new System.Windows.Forms.Button();
            this.menor = new System.Windows.Forms.Button();
            this.imprime = new System.Windows.Forms.Button();
            this.TextInsere = new System.Windows.Forms.TextBox();
            this.TextRemove = new System.Windows.Forms.TextBox();
            this.TextMaior = new System.Windows.Forms.TextBox();
            this.TextMenor = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lista: ";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // TextLista
            // 
            this.TextLista.BackColor = System.Drawing.SystemColors.HotTrack;
            this.TextLista.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextLista.ForeColor = System.Drawing.SystemColors.Window;
            this.TextLista.Location = new System.Drawing.Point(89, 17);
            this.TextLista.Name = "TextLista";
            this.TextLista.Size = new System.Drawing.Size(678, 31);
            this.TextLista.TabIndex = 1;
            this.TextLista.TextChanged += new System.EventHandler(this.TextLista_TextChanged);
            // 
            // insere
            // 
            this.insere.BackColor = System.Drawing.SystemColors.HotTrack;
            this.insere.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.insere.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insere.Location = new System.Drawing.Point(33, 101);
            this.insere.Name = "insere";
            this.insere.Size = new System.Drawing.Size(104, 30);
            this.insere.TabIndex = 2;
            this.insere.Text = "INSERE";
            this.insere.UseVisualStyleBackColor = false;
            this.insere.Click += new System.EventHandler(this.Button1_Click);
            // 
            // remove
            // 
            this.remove.BackColor = System.Drawing.SystemColors.HotTrack;
            this.remove.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.remove.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remove.Location = new System.Drawing.Point(33, 152);
            this.remove.Name = "remove";
            this.remove.Size = new System.Drawing.Size(104, 30);
            this.remove.TabIndex = 7;
            this.remove.Text = "REMOVE";
            this.remove.UseVisualStyleBackColor = false;
            this.remove.Click += new System.EventHandler(this.Remove_Click);
            // 
            // maior
            // 
            this.maior.BackColor = System.Drawing.SystemColors.HotTrack;
            this.maior.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.maior.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maior.Location = new System.Drawing.Point(33, 210);
            this.maior.Name = "maior";
            this.maior.Size = new System.Drawing.Size(104, 30);
            this.maior.TabIndex = 8;
            this.maior.Text = "MAIOR";
            this.maior.UseVisualStyleBackColor = false;
            this.maior.Click += new System.EventHandler(this.Maior_Click);
            // 
            // menor
            // 
            this.menor.BackColor = System.Drawing.SystemColors.HotTrack;
            this.menor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.menor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menor.Location = new System.Drawing.Point(33, 271);
            this.menor.Name = "menor";
            this.menor.Size = new System.Drawing.Size(104, 30);
            this.menor.TabIndex = 9;
            this.menor.Text = "MENOR";
            this.menor.UseVisualStyleBackColor = false;
            this.menor.Click += new System.EventHandler(this.Menor_Click);
            // 
            // imprime
            // 
            this.imprime.BackColor = System.Drawing.SystemColors.HotTrack;
            this.imprime.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.imprime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imprime.Location = new System.Drawing.Point(33, 334);
            this.imprime.Name = "imprime";
            this.imprime.Size = new System.Drawing.Size(104, 30);
            this.imprime.TabIndex = 10;
            this.imprime.Text = "IMPRIME";
            this.imprime.UseVisualStyleBackColor = false;
            this.imprime.Click += new System.EventHandler(this.Imprime_Click);
            // 
            // TextInsere
            // 
            this.TextInsere.BackColor = System.Drawing.SystemColors.HotTrack;
            this.TextInsere.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextInsere.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextInsere.ForeColor = System.Drawing.SystemColors.Window;
            this.TextInsere.Location = new System.Drawing.Point(143, 101);
            this.TextInsere.Name = "TextInsere";
            this.TextInsere.Size = new System.Drawing.Size(624, 31);
            this.TextInsere.TabIndex = 11;
            this.TextInsere.TextChanged += new System.EventHandler(this.TextInsere_TextChanged);
            // 
            // TextRemove
            // 
            this.TextRemove.BackColor = System.Drawing.SystemColors.HotTrack;
            this.TextRemove.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextRemove.ForeColor = System.Drawing.SystemColors.Window;
            this.TextRemove.Location = new System.Drawing.Point(143, 152);
            this.TextRemove.Name = "TextRemove";
            this.TextRemove.Size = new System.Drawing.Size(624, 31);
            this.TextRemove.TabIndex = 12;
            // 
            // TextMaior
            // 
            this.TextMaior.BackColor = System.Drawing.SystemColors.HotTrack;
            this.TextMaior.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextMaior.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextMaior.ForeColor = System.Drawing.SystemColors.Window;
            this.TextMaior.Location = new System.Drawing.Point(143, 210);
            this.TextMaior.Name = "TextMaior";
            this.TextMaior.Size = new System.Drawing.Size(624, 31);
            this.TextMaior.TabIndex = 13;
            // 
            // TextMenor
            // 
            this.TextMenor.BackColor = System.Drawing.SystemColors.HotTrack;
            this.TextMenor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextMenor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextMenor.ForeColor = System.Drawing.SystemColors.Window;
            this.TextMenor.Location = new System.Drawing.Point(143, 271);
            this.TextMenor.Name = "TextMenor";
            this.TextMenor.Size = new System.Drawing.Size(624, 31);
            this.TextMenor.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TextMenor);
            this.Controls.Add(this.TextMaior);
            this.Controls.Add(this.TextRemove);
            this.Controls.Add(this.TextInsere);
            this.Controls.Add(this.imprime);
            this.Controls.Add(this.menor);
            this.Controls.Add(this.maior);
            this.Controls.Add(this.remove);
            this.Controls.Add(this.insere);
            this.Controls.Add(this.TextLista);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextLista;
        private System.Windows.Forms.Button insere;
        private System.Windows.Forms.Button remove;
        private System.Windows.Forms.Button maior;
        private System.Windows.Forms.Button menor;
        private System.Windows.Forms.Button imprime;
        private System.Windows.Forms.TextBox TextInsere;
        private System.Windows.Forms.TextBox TextRemove;
        private System.Windows.Forms.TextBox TextMaior;
        private System.Windows.Forms.TextBox TextMenor;
    }
}

