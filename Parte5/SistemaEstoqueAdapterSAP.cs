using Roteiro8_SistemaEstoque;
using System;
using System.Collections.Generic;
using System.Text;

namespace Parte5
{
    public class SistemaEstoqueAdapterSAP : SistemaEstoqueAdapter
    {

        public SistemaEstoqueAdapterSAP()
        {
            this.sistemaestoque = new SistemaEstoque("SAP");
        }
    }
}
