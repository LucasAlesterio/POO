using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;


namespace POO_FINAL
{
    public partial class AddA : Form
    {

        public AddA()
        {
            
            
            InitializeComponent();
            db c = new db();
            String[] op = c.materia();
            for(int i = 0; i < op.Length; i++)
            {
                comboBox1.Items.Add(op[i]);
            }
            
            
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            db c = new db();


            //Console.WriteLine("antes comando sql");
            try
            {
                String str = "INSERT into avaliacoes (id_materia,valor,data_avaliacao,nome_avaliacao) VALUES ('" + c.id(comboBox1.Text) + "','" + Convert.ToInt32(textBox2.Text) + "','" + textBox3.Text + "','" + textBox1.Text + "'); ";
                c.insert(str);
            }
            catch(Exception x)
            {
                MessageBox.Show("ERRO!:"+x);
            }
            //Console.WriteLine(str);
            
            //MessageBox.Show("Item inserido!");


            Menu a = new Menu();
            a.Visible = true;
            Close();
        }

        private void AddA_Load(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Menu a = new Menu();
            a.Visible = true;
            Close();
        }
    }
}
