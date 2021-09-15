using System;
using System.Collections.Generic;
using System.Text;

namespace Parte6
{
    public class AdapterFactory
    {
        private SistemaEstoqueAdapter sistemaestoqueAdapter;
        private SistemaContabilAdapter sistemacontabilAdapter;
        private static AdapterFactory instance = new AdapterFactory();

        private AdapterFactory()
        {

        }

        public static AdapterFactory getInstance()
        {
            return instance;
        }

        public SistemaContabilAdapter criarSistemaContabilAdapter(string nome)
        {
            if (nome.Equals("IBM"))
                this.sistemacontabilAdapter = new SistemaContabilAdapterIBM();
            else if (nome.Equals("DELL"))
                this.sistemacontabilAdapter = new SistemaContabilAdapterDELL();
            else if (nome.Equals("SAP"))
                this.sistemacontabilAdapter = new SistemaContabilAdapterSAP();
            return this.sistemacontabilAdapter;
        }
        public SistemaEstoqueAdapter criarSistemaEstoqueAdapter(string nome)
        {
            if (nome.Equals("IBM"))
                this.sistemaestoqueAdapter = new SistemaEstoqueAdapterIBM();
            else if (nome.Equals("DELL"))
                this.sistemaestoqueAdapter = new SistemaEstoqueAdapterIBM();
            else if (nome.Equals("SAP"))
                this.sistemaestoqueAdapter = new SistemaEstoqueAdapterIBM();
            return this.sistemaestoqueAdapter;
        }
    }
}
