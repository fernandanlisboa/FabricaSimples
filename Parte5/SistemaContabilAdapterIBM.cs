using Roteiro8_SistemaContabil;
using System;
using System.Collections.Generic;
using System.Text;

namespace Parte5
{
    public class SistemaContabilAdapterIBM : SistemaContabilAdapter
    {

        public SistemaContabilAdapterIBM()
        {
            this.sistemacontabil = new SistemaContabil("IBM");
        }
    }
}
