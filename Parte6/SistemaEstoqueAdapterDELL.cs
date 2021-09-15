
using Roteiro8_SistemaEstoque;
using System;
using System.Collections.Generic;
using System.Text;

namespace Parte6
{
    public class SistemaEstoqueAdapterDELL : SistemaEstoqueAdapter
    {

        public SistemaEstoqueAdapterDELL()
        {
            this.sistemaestoque = new SistemaEstoque("DELL");
        }
    }
}
