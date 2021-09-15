using Roteiro8_SistemaEstoque;
using System;
using System.Collections.Generic;
using System.Text;

namespace Parte4
{
    public class SistemaEstoqueAdapterSAP : ISistemaEstoqueAdapter
    {
        private SistemaEstoque sistemaestoque;

        public SistemaEstoqueAdapterSAP()
        {
            this.sistemaestoque = new SistemaEstoque("SAP");
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
