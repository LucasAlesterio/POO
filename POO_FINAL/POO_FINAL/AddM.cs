using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POO_FINAL
{
    public partial class AddM : Form
    {
        public AddM()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            db c = new db();
            //Console.WriteLine("antes comando sql");
            String str = "INSERT into materias (nome_professor,nome_materia) VALUES ('" + textBox2.Text + "','" + textBox1.Text + "');";
            //Console.WriteLine(str);
            c.insert(str);


            Menu a = new Menu();
            a.Visible=true;
            att();
            Close();
        }

        private void AddM_Load(object sender, EventArgs e)
        {
            att();
        }
        public void att()
        {
            dataGridView1.Rows.Clear();
            db c = new db();
            var a = c.select("Select * from materias ;");
            while (a.Read())
            {
                dataGridView1.Rows.Add(new object[] { a.GetValue(0), a.GetValue(2), a.GetValue(1)});
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            db c = new db();
            c.insert("UPDATE materias SET nome_professor='" + dataGridView1.CurrentRow.Cells[2].Value.ToString() +"',nome_materia='"+ dataGridView1.CurrentRow.Cells[1].Value.ToString() + "' where id_materia='" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "'");
            att();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            db c = new db();
            c.insert("DELETE FROM materias where id_materia ='" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "'");
            att();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Menu a = new Menu();
            a.Visible = true;
            Close();
        }
    }
}
