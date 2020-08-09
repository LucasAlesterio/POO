using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laboratorio_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            String a = caixa.Text;
            Char[] b = a.ToCharArray();
            //Console.WriteLine(b[0]);
            //Pilha<char> PilhaChar = new Pilha<char>();
            Stack Stack = new Stack();
            Stack abertura = new Stack();
            Stack fechamento = new Stack();
            abertura.Push('{');
            abertura.Push('(');
            abertura.Push('[');
            fechamento.Push('}');
            fechamento.Push(')');
            fechamento.Push(']');

            /*Stack.Push(b[0]);
            Stack.Push(b[1]);
            Console.WriteLine(Stack.Peek());*/

            /*label.Text = "asd";
            label.ForeColor = Color.Green;
            */

            bool flag = false;
            for (int i = 0; i < b.Length; i++)
            {
                if (abertura.Contains(b[i]) == true)
                {
                    Stack.Push(b[i]);
                }
            }
            for (int i = 0; i < b.Length; i++)
            {
                if (Stack.Count == 0 && fechamento.Contains(b[i]))
                {
                    flag = true;
                }
                /* if (fechamento.Contains(b[i]) == true)
                 {
                     Console.WriteLine("IF");*/
                char c = ' ';
                if (Stack.Count > 0)
                {
                    c = Convert.ToChar(Stack.Peek());
                }
                   /* if(c == '(')
                    {
                        Console.WriteLine("achou parenteses");
                    }*/
                    if (c == '(' && b[i] == ')')
                    {
                       // Console.WriteLine("parenteses");
                        if (Stack.Count == 0)
                        {
                            flag = true;
                        }
                        else
                        {
                            Stack.Pop();
                        }
                    }
                    if (c == '[' && b[i] == ']')
                    {
                        if (Stack.Count == 0)
                        {
                            flag = true;
                        }
                        else
                        {
                            Stack.Pop();
                        }
                    }
                    if (c == '{' && b[i] == '}')
                    {
                        if (Stack.Count == 0)
                        {
                            flag = true;
                        }
                        else
                        {
                            Stack.Pop();
                        }
                    }

                
            }
            //True == Erro;
            if(Stack.Count > 0)
            {
               // Console.WriteLine("Pilha não vazia");
                flag = true;
                /*Console.WriteLine(Stack.Pop());
                Console.WriteLine(Stack.Pop());*/
               // Console.WriteLine(Stack.Count);
            }
            //Console.WriteLine(flag);
            if(flag == false)
            {
                label.Text = "Expressões matemáticas bem formadas!";
                label.ForeColor = Color.Green;
            }
            else
            {
                label.Text = "Expressões matemáticas não foram bem formadas!";
                label.ForeColor = Color.Red;
            }
            
           



        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
