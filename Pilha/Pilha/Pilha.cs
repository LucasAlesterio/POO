using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pilha
{
    class Pilha
    {
        private NohPilha topo;

        public Pilha()
        {
            topo = null;
        }
        public bool isEmpty()
        {
            if (topo == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    public void push(int insertItem)
        {
            if (isEmpty())
            {
                topo = new NohPilha(insertItem);
            }
            else
            {
                NohPilha novoNoh = new NohPilha(insertItem, topo);
                topo = novoNoh;
            }
        }
    }
}
