using System;
using System.Collections.Generic;
using System.Text;

namespace Parte6
{
    public class ControladorRegistradora
    {
        private SistemaContabilAdapter sistemacontabilAdapter;
        private SistemaEstoqueAdapter sistemaestoqueAdapter;
        private AdapterFactory factory;

        public ControladorRegistradora()
        {
            this.factory = AdapterFactory.getInstance();
            Console.WriteLine("Controlador de Sistema Registradora Criado!");
        }

        public void criarSistemaContabilAdapter(string nome)
        {
            this.sistemacontabilAdapter = this.factory.criarSistemaContabilAdapter(nome);
        }

        public void criarSistemaEstoqueAdapter(string nome)
        {
            this.sistemaestoqueAdapter = this.factory.criarSistemaEstoqueAdapter(nome);
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
