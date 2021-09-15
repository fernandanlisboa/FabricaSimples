using Roteiro8_SistemaContabil;
using System;
using System.Collections.Generic;
using System.Text;

namespace Parte5
{
    public abstract class SistemaContabilAdapter
    {
        protected SistemaContabil sistemacontabil;

        public void finalizarVenda()
        {
            this.sistemacontabil.registrarVenda();
        }
        public void registrarImposto()
        {
            this.sistemacontabil.calcularImposto();
        }
    }
}
