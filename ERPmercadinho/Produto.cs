using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERPmercadinho
{
    class Produto
    {
        public string Nome { get; set; }
        public Decimal Preco { get; set; }
        public int Quantidade { get; set; }
        public int EstoqueMinimo { get; set; }
        public string Codigo { get; set; }
    }
}
