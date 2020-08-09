using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prova_2_questao_1;

namespace Prova_2_questao_1
{
    class Lista<TAD> : Object
    {
        protected NohLista<TAD> inicio;
        protected NohLista<TAD> fim;

        public Lista()
        {
            inicio = null;
            fim = null;
        }

        public Lista(NohLista<TAD> _inicio, NohLista<TAD> _fim)
        {
            inicio = _inicio;
            fim = _fim;
        }

        public NohLista<TAD> getInicio => inicio;
        public NohLista<TAD> getFim => fim;
        public void setInicio(NohLista<TAD> _inicio)
        {
            inicio = _inicio;
        }

        public void setFim(NohLista<TAD> _fim)
        {
            fim = _fim;
        }

        public bool isEmpty()
        {
            if (inicio == null && fim == null)
                return true;
            else
                return false;
        }
        public int listSize()
        {
            NohLista<TAD> temp = inicio;
            int lenght = 0;
            if (isEmpty())
                return 0;
            else
            {
                while (temp != null)
                {
                    temp = temp.getNext();
                    lenght++;
                }
            }
            return lenght;
        }
        public void insereNoFim(TAD data)
        {
            NohLista<TAD> novoNoh = new NohLista<TAD>(data);

            if (isEmpty())
            {
                inicio = novoNoh;
                fim = inicio;
            }

            else
            {
                fim.setNext(novoNoh);
                novoNoh.setPrev(fim);
                fim = novoNoh;
            }
        }

        public void insereNoInicio(TAD data)
        {
            NohLista<TAD> novoNoh = new NohLista<TAD>(data);

            if (isEmpty())
            {
                inicio = novoNoh;
                fim = inicio;
            }

            else
            {
                inicio.setPrev(novoNoh);
                novoNoh.setNext(inicio);
                inicio = novoNoh;
            }
        }

        public NohLista<TAD> achaNoh(TAD data)
        {
            NohLista<TAD> temp = inicio;

            while (temp != fim)
            {
                if (temp.getData().Equals(data))
                    break;
                else
                    temp = temp.getNext();
            }
            if (temp == null)
                return null;
            else if ((temp == fim && !(temp.getData().Equals(data))))
                return null;
            else
                return temp;
        }

        public TAD achaMaior()
        {
            TAD aux = default;
            NohLista<TAD> temp = inicio;

            if (temp == fim)
                aux = temp.getData();
            else
            {
                while (temp != fim)
                {
                    if (aux is int)
                    {
                        if (Convert.ToInt32(aux) < Convert.ToInt32(temp.getData()))
                            aux = temp.getData();

                        temp = temp.getNext();
                    }
                }
            }
            return aux;
        }

        public TAD achaMenor()
        {
            TAD aux = achaMaior();
            NohLista<TAD> temp = inicio;

            if (temp == fim)
                aux = temp.getData();
            else
            {
                while (temp != fim)
                {
                    if (aux is int)
                    {
                        if (Convert.ToInt32(aux) > Convert.ToInt32(temp.getData()))
                            aux = temp.getData();

                        temp = temp.getNext();
                    }
                }
            }
            return aux;
        }

        public void remove(TAD data)
        {
            NohLista<TAD> temp = achaNoh(data);

            if (isEmpty())
            {
                return;
            }

            else if (temp == null)
            {
                return;
            }
            else if (temp == inicio && temp == fim)
            {
                inicio = null;
                fim = inicio;
            }

            else if (temp == inicio)
            {
                temp.getNext().setPrev(null);
                inicio = temp.getNext();
            }

            else if (temp == fim)
            {
                temp.getPrev().setNext(null);
                fim = temp.getPrev();
            }

        }


        public TAD retornaIten(int j)
        {
            NohLista<TAD> temp = inicio;
            TAD itens = temp.getData();

            for (int i = 0; i < j; i++)
            {
                itens = temp.getData();
                temp = temp.getNext();
            }
            return itens;
        }
        public String print()
        {
            NohLista<TAD> temp = inicio;
            int t = this.listSize();
            String a = "";
            

            while (temp != fim)
            {
                a = a + Convert.ToString(temp.getData()) + ",";

               
                    temp = temp.getNext();
            }
            a = a + Convert.ToString(temp.getData()) + ",";
            if (temp == null)
                return null;
           
            else
                return a;
        }
        public Lista<TAD>   Inverte( Lista<TAD> b)
        {
            NohLista<TAD> temp = inicio;
            int t = this.listSize();
            String a = "";
            int[] v = new int[50];
            int i = 0;

            while (temp != fim)
            {
                v[i]=temp.getData();

                a = a + Convert.ToString(temp.getData()) + ",";


                temp = temp.getNext();
            }
            b.insereNoFim(temp.getData());
            a = a + Convert.ToString(temp.getData()) + ",";
            if (temp == null)
                return null;

            else
                return b;
        }
    }
}
