using System;
using System.Collections.Generic;
using System.Text;

namespace Roteiro8_SistemaEstoque
{
    public class SistemaEstoque
    {
        private string nome;

        public SistemaEstoque(string nome)
        {
            this.nome = nome;
        }

        public void removerItemEstoque()
        {
            Console.WriteLine("Item removido do estoque no " + this.nome + " - Sistema Estoque \n");
        }

        public void adicionarItemEstoque()
        {
            Console.WriteLine("Item adicionado no estoque no " + this.nome + " - Sistema Estoque \n");
        }
    }
}
