using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab6
{
    public partial class Form1 : Form
    {
        List<int> lista = new List<int>();
        string str;
        public Form1()
        {
            
            InitializeComponent();
          

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                lista.Add(Convert.ToInt32(TextInsere.Text));
            }
            catch(Exception )
            {
                MessageBox.Show("Certifique-se que seja um numero inteiro");
            }
            TextInsere.Text = "";

        }

        private void Button2_Click(object sender, EventArgs e)
        {

        }

        private void TextLista_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextInsere_TextChanged(object sender, EventArgs e)
        {

        }

        private void Imprime_Click(object sender, EventArgs e)
        {

           
            foreach (var elemento in lista)
            {
                str += (Convert.ToString(elemento) + ",");
            }
            TextLista.Text = str;
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            try
            {
                lista.Remove(Convert.ToInt32(TextRemove.Text));
            }
            catch (Exception)
            {
                MessageBox.Show("Certifique-se que seja um numero inteiro");
            }
            TextRemove.Text = "";
        }

        private void Maior_Click(object sender, EventArgs e)
        {
           
            TextMaior.Text = "";
            try
            {
                TextMaior.Text = Convert.ToString(lista.Max());
            }
            catch (Exception)
            {
                MessageBox.Show("Lista vazia!");
            }
        }

        private void Menor_Click(object sender, EventArgs e)
        {
            TextMenor.Text = "";
            try
            {
                TextMenor.Text = Convert.ToString(lista.Min());
            }
            catch (Exception)
            {
                MessageBox.Show("Lista vazia!");
            }
        }
    }
    
}
