using Roteiro8_SistemaContabil;
using System;
using System.Collections.Generic;
using System.Text;

namespace Parte6
{
    public class SistemaContabilAdapterSAP : SistemaContabilAdapter
    {

        public SistemaContabilAdapterSAP()
        {
            this.sistemacontabil = new SistemaContabil("SAP");
        }
    }
}
