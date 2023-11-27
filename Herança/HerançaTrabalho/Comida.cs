using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerançaTrabalho
{
    public class Comida : Produto
    {
        public string _fruta = "Banana";
        public string _pizza = "Pizza calabresa";

        public int GetPrecoPizza()
        {
            return _precoPizza;
        }
        public int GetPrecoFruta()
        {
            return _precoFruta;
        }
    }
}

