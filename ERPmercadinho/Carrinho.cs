using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERPmercadinho
{
    internal class Carrinho
    {
        public List<ItemCarrinho> Itens { get; set; }

        public Carrinho()
        {
            Itens = new List<ItemCarrinho>();
        }

        public void AdicionarProduto(Produto produto)
        {
            ItemCarrinho itemExistente = Itens
                .FirstOrDefault(i => i.Produto.Codigo == produto.Codigo);

            if (itemExistente != null)
            {
                itemExistente.Quantidade++;
            }
            else
            {
                Itens.Add(new ItemCarrinho
                {
                    Produto = produto,
                    Quantidade = 1
                });
            }
        }

        public decimal Total()
        {
            return Itens.Sum(i => i.Subtotal);
        }
    }
}
