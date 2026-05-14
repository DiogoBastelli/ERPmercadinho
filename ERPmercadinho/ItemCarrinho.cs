using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERPmercadinho
{
    internal class ItemCarrinho
    {
        public Produto Produto { get; set; }

        public int Quantidade { get; set; }

        public decimal Subtotal
        {
            get
            {
                return Produto.Preco * Quantidade;
            }
        }
    }
}
