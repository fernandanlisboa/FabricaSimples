
using Roteiro8_SistemaContabil;
using System;
using System.Collections.Generic;
using System.Text;

namespace Parte6
{
    public class SistemaContabilAdapterDELL : SistemaContabilAdapter
    {

        public SistemaContabilAdapterDELL()
        {
            this.sistemacontabil = new SistemaContabil("DELL");
        }
    }
}
