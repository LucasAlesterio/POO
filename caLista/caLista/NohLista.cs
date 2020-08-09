using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caLista
{
    class NohLista
    {
        private NohLista previo;
        int     data;
        private NohLista next;

        public NohLista()
        {
            previo = null;
            // data = 0;
            next = null;
        }

        public NohLista(int n)
        {
            previo = null;
            data = n;
            next = null;
        }

        public NohLista getPrevio()
        {
            return previo;
        }

        public void setPrevio(NohLista _previo)
        {
            previo = _previo;
        }

        public int getData()
        {
            return data;
        }

        public void setData(int _data)
        {
            data = _data;
        }

        
        public NohLista getNext()
        {
            return next;
        }

        public void setNext(NohLista _next)
        {
            next = _next;
        }
    }
}
