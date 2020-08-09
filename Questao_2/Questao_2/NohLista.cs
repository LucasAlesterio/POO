using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Questao_2;

namespace Questao_2
{
    class NohLista<TAD> : Object
    {
        private TAD data;
        private NohLista<TAD> prev;
        private NohLista<TAD> next;

        public NohLista()
        {
            prev = null;
            next = null;
        }

        public NohLista(TAD _data)
        {
            data = _data;
            prev = null;
            next = null;
        }

        public NohLista(TAD _data, NohLista<TAD> _prev, NohLista<TAD> _next)
        {
            data = _data;
            prev = _prev;
            next = _next;
        }

        public TAD getData()
        {
            return data;
        }

        public void setData(TAD _data)
        {
            data = _data;
        }

        public NohLista<TAD> getPrev()
        {
            return prev;
        }

        public void setPrev(NohLista<TAD> _prev)
        {
            prev = _prev;
        }

        public NohLista<TAD> getNext()
        {
            return next;
        }

        public void setNext(NohLista<TAD> _next)
        {
            next = _next;
        }
    }
}
