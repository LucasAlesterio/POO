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
    public partial class Grade : Form
    {
        public Grade()
        {
            InitializeComponent();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Menu a = new Menu();
            a.Visible = true;
            Close();
        }

        private void Grade_Load(object sender, EventArgs e)
        {
            att(); 
        }
        public void att()
        {
            dataGridView1.Rows.Clear();
            db c = new db();
            var a = c.select("Select * from aulas natural join materias ;");
            while (a.Read())
            {
                dataGridView1.Rows.Add(new object[] { a.GetValue(1), a.GetValue(5), a.GetValue(4), a.GetValue(2), a.GetValue(3) });
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            db c = new db();
            c.insert("DELETE FROM aulas where id_aula ='" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "'");
            att();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            db c = new db();
            c.insert("UPDATE aulas SET dia_semana='" + dataGridView1.CurrentRow.Cells[3].Value.ToString() + "', intervalo='" + dataGridView1.CurrentRow.Cells[4].Value.ToString() +  "' where id_aula='" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "'");
            att();
        }
    }
}
