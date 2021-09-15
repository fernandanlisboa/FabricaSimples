using System;
using System.Collections.Generic;
using System.Text;

namespace Parte4
{
    public class ControladorRegistradora
    {
        private ISistemaContabilAdapter sistemacontabilAdapter;
        private ISistemaEstoqueAdapter sistemaestoqueAdapter;

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
        }

        public void criarSistemaEstoqueAdapter(string nome)
        {
            if (nome.Equals("IBM"))
                this.sistemaestoqueAdapter = new SistemaEstoqueAdapterIBM();
            else if (nome.Equals("DELL"))
                this.sistemaestoqueAdapter = new SistemaEstoqueAdapterDELL();
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
