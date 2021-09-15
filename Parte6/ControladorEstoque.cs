using System;
using System.Collections.Generic;
using System.Text;

namespace Parte6
{
    public class ControladorEstoque
    {
        private SistemaEstoqueAdapter sistemaestoqueAdapter;
        private AdapterFactory factory;

        public ControladorEstoque()
        {
            Console.WriteLine("Controlador de Sistema Contábil Criado!");
            this.factory = AdapterFactory.getInstance();
        }

        public void criarSistemaEstoqueAdapter(string nome)
        {
            this.sistemaestoqueAdapter = this.factory.criarSistemaEstoqueAdapter(nome);

        }

        public void aumentarQuantidadeItem()
        {
            this.sistemaestoqueAdapter.aumentarQuantidadeItem();
        }
    }


}
