namespace POO_FINAL
{
    partial class Menu
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
            this.AddM = new System.Windows.Forms.Button();
            this.AddA = new System.Windows.Forms.Button();
            this.AddN = new System.Windows.Forms.Button();
            this.AddAula = new System.Windows.Forms.Button();
            this.Agenda = new System.Windows.Forms.Button();
            this.Grade = new System.Windows.Forms.Button();
            this.Hist = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddM
            // 
            this.AddM.Location = new System.Drawing.Point(36, 12);
            this.AddM.Name = "AddM";
            this.AddM.Size = new System.Drawing.Size(111, 23);
            this.AddM.TabIndex = 0;
            this.AddM.Text = "Adicionar Matéria";
            this.AddM.UseVisualStyleBackColor = true;
            this.AddM.Click += new System.EventHandler(this.Button1_Click);
            // 
            // AddA
            // 
            this.AddA.Location = new System.Drawing.Point(36, 41);
            this.AddA.Name = "AddA";
            this.AddA.Size = new System.Drawing.Size(111, 23);
            this.AddA.TabIndex = 1;
            this.AddA.Text = "Adicionar Avaliação";
            this.AddA.UseVisualStyleBackColor = true;
            this.AddA.Click += new System.EventHandler(this.AddA_Click);
            // 
            // AddN
            // 
            this.AddN.Location = new System.Drawing.Point(36, 70);
            this.AddN.Name = "AddN";
            this.AddN.Size = new System.Drawing.Size(111, 23);
            this.AddN.TabIndex = 2;
            this.AddN.Text = "Adicionar Notas";
            this.AddN.UseVisualStyleBackColor = true;
            this.AddN.Click += new System.EventHandler(this.AddN_Click);
            // 
            // AddAula
            // 
            this.AddAula.Location = new System.Drawing.Point(36, 99);
            this.AddAula.Name = "AddAula";
            this.AddAula.Size = new System.Drawing.Size(111, 23);
            this.AddAula.TabIndex = 3;
            this.AddAula.Text = "Adicionar Aulas";
            this.AddAula.UseVisualStyleBackColor = true;
            this.AddAula.Click += new System.EventHandler(this.AddAula_Click);
            // 
            // Agenda
            // 
            this.Agenda.Location = new System.Drawing.Point(36, 153);
            this.Agenda.Name = "Agenda";
            this.Agenda.Size = new System.Drawing.Size(111, 23);
            this.Agenda.TabIndex = 4;
            this.Agenda.Text = "Agenda";
            this.Agenda.UseVisualStyleBackColor = true;
            this.Agenda.Click += new System.EventHandler(this.Agenda_Click);
            // 
            // Grade
            // 
            this.Grade.Location = new System.Drawing.Point(36, 183);
            this.Grade.Name = "Grade";
            this.Grade.Size = new System.Drawing.Size(111, 23);
            this.Grade.TabIndex = 5;
            this.Grade.Text = "Grade Horária";
            this.Grade.UseVisualStyleBackColor = true;
            this.Grade.Click += new System.EventHandler(this.Grade_Click);
            // 
            // Hist
            // 
            this.Hist.Location = new System.Drawing.Point(36, 213);
            this.Hist.Name = "Hist";
            this.Hist.Size = new System.Drawing.Size(111, 23);
            this.Hist.TabIndex = 6;
            this.Hist.Text = "Histórico";
            this.Hist.UseVisualStyleBackColor = true;
            this.Hist.Click += new System.EventHandler(this.Hist_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(181, 259);
            this.Controls.Add(this.Hist);
            this.Controls.Add(this.Grade);
            this.Controls.Add(this.Agenda);
            this.Controls.Add(this.AddAula);
            this.Controls.Add(this.AddN);
            this.Controls.Add(this.AddA);
            this.Controls.Add(this.AddM);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddM;
        private System.Windows.Forms.Button AddA;
        private System.Windows.Forms.Button AddN;
        private System.Windows.Forms.Button AddAula;
        private System.Windows.Forms.Button Agenda;
        private System.Windows.Forms.Button Grade;
        private System.Windows.Forms.Button Hist;
    }
}

