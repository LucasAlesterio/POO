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
    public partial class AddAulas : Form
    {
        public AddAulas()
        {
            InitializeComponent();
            db c = new db();
            String[] op = c.materia();
            for (int i = 0; i < op.Length; i++)
            {
                comboBox1.Items.Add(op[i]);
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Menu a = new Menu();
            db c = new db();
            c.insert("INSERT INTO aulas (id_materia,dia_semana,intervalo) values ('" + c.id(comboBox1.Text) + "','" + comboBox2.Text + "','"+textBox1.Text+"')");
            a.Visible = true;
            Close();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Menu a = new Menu();
            a.Visible = true;
            Close();
        }
    }
}
