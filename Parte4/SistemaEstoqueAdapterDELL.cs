using Roteiro8_SistemaEstoque;
using System;
using System.Collections.Generic;
using System.Text;

namespace Parte4
{
    public class SistemaEstoqueAdapterDELL : ISistemaEstoqueAdapter
    {
        private SistemaEstoque sistemaestoque;

        public SistemaEstoqueAdapterDELL()
        {
            this.sistemaestoque = new SistemaEstoque("DELL");
        }

        public void aumentarQuantidadeItem()
        {
            this.sistemaestoque.adicionarItemEstoque();
        }

        public void diminuirQuantidadeItem()
        {
            this.sistemaestoque.removerItemEstoque();
        }
    }
}
