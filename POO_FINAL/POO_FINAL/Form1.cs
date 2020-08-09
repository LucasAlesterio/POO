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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //db banco = new db();
            //banco.connectionTest()
            //Close();
            AddM add = new AddM();
            add.Show();
            Hide();

        }

        private void AddA_Click(object sender, EventArgs e)
        {
            AddA add = new AddA();
            add.Show();
            Hide();
        }

        private void AddN_Click(object sender, EventArgs e)
        {

            AddN add = new AddN();
            add.Show();
            Hide();
        }

        private void AddAula_Click(object sender, EventArgs e)
        {
            AddAulas add = new AddAulas();
            add.Show();
            Hide();
        }

        private void Agenda_Click(object sender, EventArgs e)
        {
            Agenda add = new Agenda();
            add.Show();
            Hide();
        }

        private void Grade_Click(object sender, EventArgs e)
        {
            Grade add = new Grade();
            add.Show();
            Hide();
        }

        private void Hist_Click(object sender, EventArgs e)
        {
            Historico add = new Historico();
            add.Show();
            Hide();
        }
    }
}
