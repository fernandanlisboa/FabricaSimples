using Roteiro8_SistemaEstoque;

namespace Parte3
{
    public class SistemaEstoqueAdapterIBM : ISistemaEstoqueAdapter
    {
        private SistemaEstoque sistemaestoque;

        public SistemaEstoqueAdapterIBM()
        {
            this.sistemaestoque = new SistemaEstoque("IBM");
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
