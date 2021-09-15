using Roteiro8_SistemaContabil;
using System;
using System.Collections.Generic;
using System.Text;

namespace Parte4
{
    public class SistemaContabilAdapterSAP : ISistemaContabilAdapter
    {
        private SistemaContabil sistemacontabil;

        public SistemaContabilAdapterSAP()
        {
            this.sistemacontabil = new SistemaContabil("SAP");
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
