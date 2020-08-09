using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _13_11
{
    public partial class Form1 : Form
    {
        private NpgsqlConnection conn; //Variavel para conectar com o banco de dados
        private NpgsqlCommand command; //Variavel para manipular comandos
        private NpgsqlDataReader result;//


        public Form1()
        {
            InitializeComponent();
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void TestConection_Click(object sender, EventArgs e)
        {
            connectionTest();
            MessageBox.Show("Conexão realizada com sucesso");

        }


        private void connectionTest()
        {
            //throw new NotImplementedException();
           
            try
            {
                conn = new NpgsqlConnection("Server=127.0.0.1 ;User Id=postgres; Password=220199; Database=postgres;");
                conn.Open();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro Encontrado:" + ex);
            }
            
        }

        private void Btninsert_Click(object sender, EventArgs e)
        {
            connectionTest();
            try
            {
                command = new NpgsqlCommand("INSERT into teste (FName,Lname) VALUES ('"
                    + txtFname.Text + "','" + txtLname.Text + "')", conn);
                command.ExecuteReader();
                MessageBox.Show("Registro Inserido!");

            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro Encontrado:" + ex);

            }
            //Limpando os campos de inclusão
            selectRecords();
            txtFname.Text = "";
            txtLname.Text = "";
        }

        private void selectRecords()
        {
            connectionTest();
            dataGridView1.Rows.Clear();
            try
            {
                command = new NpgsqlCommand("SELECT * FROM teste order by fnum", conn);
                result = command.ExecuteReader();
                while (result.Read())
                {
                    dataGridView1.Rows.Add(new object[] { result.GetValue(0), result.GetValue(1), result.GetValue(2) });
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro encontrado: " + ex);
            }

        }

        private void Btnselect_Click(object sender, EventArgs e)
        {
            selectRecords();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            connectionTest();
            try
            {
                command = new NpgsqlCommand("DELETE from teste where fnum = " + dataGridView1.CurrentRow.Cells[0].Value.ToString(), conn);
                command.ExecuteReader();
                MessageBox.Show("Registro excluido com sucesso!");
                selectRecords();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro encontrado: " + ex);
            }
        }

        private void Btnupdate_Click(object sender, EventArgs e)
        {

        }
    }
}
