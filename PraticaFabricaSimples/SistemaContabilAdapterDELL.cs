using Roteiro8_SistemaContabil;
using System;
using System.Collections.Generic;
using System.Text;

namespace Parte1
{
    public class SistemaContabilAdapterDELL : ISistemaContabilAdapter
    {
        private SistemaContabil sistemacontabil;

        public SistemaContabilAdapterDELL()
        {
            this.sistemacontabil = new SistemaContabil("DELL");
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
