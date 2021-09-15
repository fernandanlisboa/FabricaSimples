using Roteiro8_SistemaEstoque;
using System;
using System.Collections.Generic;
using System.Text;

namespace Parte5
{
    public abstract class SistemaEstoqueAdapter
    {
        protected SistemaEstoque sistemaestoque;

        public void diminuirQuantidadeItem() 
        {
            this.sistemaestoque.removerItemEstoque();
        }
        public void aumentarQuantidadeItem()
        {
            this.sistemaestoque.adicionarItemEstoque();
        }
    }
}
