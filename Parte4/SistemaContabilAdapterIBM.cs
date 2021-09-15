using Roteiro8_SistemaContabil;
using System;
using System.Collections.Generic;
using System.Text;

namespace Parte4
{
    public class SistemaContabilAdapterIBM : ISistemaContabilAdapter
    {
        private SistemaContabil sistemacontabil;

        public SistemaContabilAdapterIBM()
        {
            this.sistemacontabil = new SistemaContabil("IBM");
        }

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
