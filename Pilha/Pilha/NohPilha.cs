using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pilha
{
    class NohPilha
    {
        int data;
        public NohPilha(int valor, NohPilha)
        {
            data = valor;
            nextNoh = NohPilha;
        }
    }
}
