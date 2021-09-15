using Roteiro8_SistemaEstoque;

namespace Parte6
{
    public class SistemaEstoqueAdapterIBM : SistemaEstoqueAdapter
    {

        public SistemaEstoqueAdapterIBM()
        {
            this.sistemaestoque = new SistemaEstoque("IBM");
        }
    }
}
