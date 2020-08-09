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
    public partial class AddN : Form
    {
        public AddN()
        {
            InitializeComponent();
            db c = new db();
            String[] op = c.materia();
            for (int i = 0; i < op.Length; i++)
            {
                comboBox1.Items.Add(op[i]);
            }

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Menu a = new Menu();
            db c = new db();
            try
            {

                c.insert("INSERT INTO notas (id_materia,nota) values ('" + c.id(comboBox1.Text) + "','" + Convert.ToInt32(textBox1.Text) + "')");
            }
            catch(Exception x)
            {
                MessageBox.Show("ERRO!"+x);
            }
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
