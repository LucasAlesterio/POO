using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Questao3_2
{
    public partial class Form1 : Form
    {
        Stack<char> pilha = new Stack<char>();
        Stack<char> pilha1 = new Stack<char>();
        char[] arr;
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            String str = textBox1.Text;
            int a = str.Length;
            arr = str.ToCharArray(1, 20);
            for(int i = (a/2); i < a; i++)
            {
                pilha.Push(arr[i]);
            }
            for (int i = (a / 2); i > 0; i--)
            {
                pilha1.Push(arr[i]);
            }
            if (pilha.Equals(pilha1))
            {
                MessageBox.Show("SIM");
            }
            else
                MessageBox.Show("NAO");




        }
    }
}
