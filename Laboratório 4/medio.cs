using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio4
{
    class medio : funcionario
    {
        private String escola;
        public medio(String _nome, String _codigo,String _escola) : base(_nome,_codigo)
        {
            escola = _escola;
        }
        public override double salario()
        {  base.salario();
            double totalSalario;
            totalSalario = inicial * 1.5;
            return totalSalario;
        }
    }
}
