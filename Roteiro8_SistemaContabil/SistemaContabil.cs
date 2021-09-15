using System;
using System.Collections.Generic;
using System.Text;

namespace Roteiro8_SistemaContabil
{
    public class SistemaContabil
    {
        private String nome;

        public SistemaContabil(String nome)
        {
            this.nome = nome;
        }

        public void registrarVenda()
        {
            Console.WriteLine("Venda Registrada no " + this.nome + " - Sistema Contabil \n");
        }

        public void calcularImposto()
        {
            Console.WriteLine("Imposto calculado no " + this.nome + " - Sistema Contabil \n");

        }
    }
}
