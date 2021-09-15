using Roteiro8_SistemaEstoque;
using System;
using System.Collections.Generic;
using System.Text;

namespace Parte6
{
    public class SistemaEstoqueAdapterSAP : SistemaEstoqueAdapter
    {

        public SistemaEstoqueAdapterSAP()
        {
            this.sistemaestoque = new SistemaEstoque("SAP");
        }
    }
}
