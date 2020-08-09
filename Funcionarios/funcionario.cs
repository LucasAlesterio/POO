using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio4
{
    class funcionario
    {
        protected String nome;
        protected String codigo;
        public double inicial = 1000;
        
        public funcionario()
        {
            nome = " ";
            codigo = " ";
        }
        public funcionario(String _nome, String _codigo)
        {
            nome = _nome;
            codigo = _codigo;
        }
        public virtual double salario()
        {
            return inicial;
        }
    }
}
