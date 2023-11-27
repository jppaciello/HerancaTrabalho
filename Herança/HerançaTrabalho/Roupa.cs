using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerançaTrabalho
{
    public class Roupa : Produto
    {
        public string _camisa = "camisa";
        public string _cor = "preto";

        public int GetPrecoCamisa() 
        {
            return _precoRoupa;
        }
    }
}
