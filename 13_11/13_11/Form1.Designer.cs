namespace _13_11
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
            this.labelfname = new System.Windows.Forms.Label();
            this.labellname = new System.Windows.Forms.Label();
            this.txtFname = new System.Windows.Forms.TextBox();
            this.txtLname = new System.Windows.Forms.TextBox();
            this.testConection = new System.Windows.Forms.Button();
            this.btninsert = new System.Windows.Forms.Button();
            this.btnselect = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.fnum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelfname
            // 
            this.labelfname.AutoSize = true;
            this.labelfname.Location = new System.Drawing.Point(12, 20);
            this.labelfname.Name = "labelfname";
            this.labelfname.Size = new System.Drawing.Size(42, 13);
            this.labelfname.TabIndex = 0;
            this.labelfname.Text = "Fname:";
            // 
            // labellname
            // 
            this.labellname.AutoSize = true;
            this.labellname.Location = new System.Drawing.Point(12, 51);
            this.labellname.Name = "labellname";
            this.labellname.Size = new System.Drawing.Size(39, 13);
            this.labellname.TabIndex = 1;
            this.labellname.Text = "Lname";
            this.labellname.Click += new System.EventHandler(this.Label2_Click);
            // 
            // txtFname
            // 
            this.txtFname.Location = new System.Drawing.Point(75, 17);
            this.txtFname.Name = "txtFname";
            this.txtFname.Size = new System.Drawing.Size(179, 20);
            this.txtFname.TabIndex = 2;
            // 
            // txtLname
            // 
            this.txtLname.Location = new System.Drawing.Point(75, 48);
            this.txtLname.Name = "txtLname";
            this.txtLname.Size = new System.Drawing.Size(179, 20);
            this.txtLname.TabIndex = 3;
            // 
            // testConection
            // 
            this.testConection.Location = new System.Drawing.Point(320, 17);
            this.testConection.Name = "testConection";
            this.testConection.Size = new System.Drawing.Size(107, 51);
            this.testConection.TabIndex = 4;
            this.testConection.Text = "TestConection";
            this.testConection.UseVisualStyleBackColor = true;
            this.testConection.Click += new System.EventHandler(this.TestConection_Click);
            // 
            // btninsert
            // 
            this.btninsert.Location = new System.Drawing.Point(42, 361);
            this.btninsert.Name = "btninsert";
            this.btninsert.Size = new System.Drawing.Size(75, 23);
            this.btninsert.TabIndex = 5;
            this.btninsert.Text = "Insert";
            this.btninsert.UseVisualStyleBackColor = true;
            this.btninsert.Click += new System.EventHandler(this.Btninsert_Click);
            // 
            // btnselect
            // 
            this.btnselect.Location = new System.Drawing.Point(142, 361);
            this.btnselect.Name = "btnselect";
            this.btnselect.Size = new System.Drawing.Size(75, 23);
            this.btnselect.TabIndex = 6;
            this.btnselect.Text = "Select";
            this.btnselect.UseVisualStyleBackColor = true;
            this.btnselect.Click += new System.EventHandler(this.Btnselect_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(239, 361);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 7;
            this.button4.Text = "Delete";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(331, 361);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(75, 23);
            this.btnupdate.TabIndex = 8;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.Btnupdate_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fnum,
            this.fname,
            this.lname});
            this.dataGridView1.Location = new System.Drawing.Point(15, 107);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(412, 220);
            this.dataGridView1.TabIndex = 9;
            // 
            // fnum
            // 
            this.fnum.HeaderText = "Fnum";
            this.fnum.Name = "fnum";
            // 
            // fname
            // 
            this.fname.HeaderText = "Fname";
            this.fname.Name = "fname";
            // 
            // lname
            // 
            this.lname.HeaderText = "Lname";
            this.lname.Name = "lname";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 403);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnselect);
            this.Controls.Add(this.btninsert);
            this.Controls.Add(this.testConection);
            this.Controls.Add(this.txtLname);
            this.Controls.Add(this.txtFname);
            this.Controls.Add(this.labellname);
            this.Controls.Add(this.labelfname);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelfname;
        private System.Windows.Forms.Label labellname;
        private System.Windows.Forms.TextBox txtFname;
        private System.Windows.Forms.TextBox txtLname;
        private System.Windows.Forms.Button testConection;
        private System.Windows.Forms.Button btninsert;
        private System.Windows.Forms.Button btnselect;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fnum;
        private System.Windows.Forms.DataGridViewTextBoxColumn fname;
        private System.Windows.Forms.DataGridViewTextBoxColumn lname;
    }
}

