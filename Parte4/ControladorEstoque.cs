using System;
using System.Collections.Generic;
using System.Text;

namespace Parte4
{
    public class ControladorEstoque
    {
        private ISistemaEstoqueAdapter sistemaestoqueAdapter;

        public ControladorEstoque()
        {
            Console.WriteLine("Controlador de Sistema Contábil Criado!");
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

        public void aumentarQuantidadeItem()
        {
            this.sistemaestoqueAdapter.aumentarQuantidadeItem();
        }
    }


}
