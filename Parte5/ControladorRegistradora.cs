using System;
using System.Collections.Generic;
using System.Text;

namespace Parte5
{
    public class ControladorRegistradora
    {
        private SistemaContabilAdapter sistemacontabilAdapter;
        private SistemaEstoqueAdapter sistemaestoqueAdapter;

        public ControladorRegistradora()
        {
            Console.WriteLine("Controlador de Sistema Registradora Criado!");
        }

        public void criarSistemaContabilAdapter(string nome)
        {
            if (nome.Equals("IBM"))
                this.sistemacontabilAdapter = new SistemaContabilAdapterIBM();
            else if (nome.Equals("DELL"))
                this.sistemacontabilAdapter = new SistemaContabilAdapterDELL();
            else if (nome.Equals("SAP"))
                this.sistemacontabilAdapter = new SistemaContabilAdapterSAP();
        }

        public void criarSistemaEstoqueAdapter(string nome)
        {
            if (nome.Equals("IBM"))
                this.sistemaestoqueAdapter = new SistemaEstoqueAdapterIBM();
            else if (nome.Equals("DELL"))
                this.sistemaestoqueAdapter = new SistemaEstoqueAdapterIBM();
            else if (nome.Equals("SAP"))
                this.sistemaestoqueAdapter = new SistemaEstoqueAdapterIBM();
        }

        public void diminuirQuantidadeItem()
        {
            this.sistemaestoqueAdapter.diminuirQuantidadeItem();
        }

        public void registrarVendaSistemaContabil()
        {
            this.sistemacontabilAdapter.finalizarVenda();
        }
    }
}
