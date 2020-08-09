using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prova_2_questao_1
{
    public partial class Form1 : Form
    {
        Lista<int> fila = new Lista<int>();
        Lista<int> fila1 = new Lista<int>();
        public Form1()
        {
            InitializeComponent();
        }

        private void TextInsere_TextChanged(object sender, EventArgs e)
        {
            //
           
        }

        private void Bimprime_Click(object sender, EventArgs e)
        {String str = "";
            for (int i = 0;i< fila.listSize(); i++)
            {
                
                str = str + Convert.ToString(fila.retornaIten(i)) + ",";
             }
            textFila.Text = fila.print();
        }

        private void Binsere_Click(object sender, EventArgs e)
        {
            try
            {
                if (fila.achaNoh((Convert.ToInt32(textInsere.Text))) != null)
                {
                    MessageBox.Show("Ja existe esse numero na fila", "Item inválido");
                }
                else
                {
                    fila.insereNoInicio(Convert.ToInt32(textInsere.Text));
                    textInsere.Text = "";
                    Console.WriteLine(textInsere.Text);
                    //listaInt.
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("O item deve ser um inteiro!", "Item inválido");
            }


        }

        private void Btamanho_Click(object sender, EventArgs e)
        {
            textTamanho.Text = Convert.ToString(fila.listSize());
        }

        private void Bmaior_Click(object sender, EventArgs e)
        {
            textFila.Text = (Convert.ToString(fila.achaMaior()));
        }

        private void Bmenor_Click(object sender, EventArgs e)
        {
            textFila.Text = (Convert.ToString(fila.achaMenor()));

        }

        private void Binverte_Click(object sender, EventArgs e)
        {
            


            textFila.Text = Convert.ToString(fila.Inverte(fila1));
        }
    }
    }
