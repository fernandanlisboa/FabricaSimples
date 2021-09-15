using Parte1;
using System;

namespace Parte2
{
    public class TesteControlador
    {
        static void Main(string[] args)
        {
            testeControladorContabil();
            testeControladorEstoque();
        }

        public static void testeControladorContabil()
        {
            Console.WriteLine("Criador o Controlador Contábil!");
            ControladorContabil controladorcontabil = new ControladorContabil();

            Console.WriteLine("Teste de Integração do Controlador Contabil - Sistema Contabil DELL");
            controladorcontabil.criarSistemaContabilAdapter("DELL");
            controladorcontabil.calcularImposto();
            Console.WriteLine("Teste de Integração do Controlador Contabil - Sistema Contabil IBM");
            controladorcontabil.criarSistemaContabilAdapter("IBM");
            controladorcontabil.calcularImposto();
        }
        public static void testeControladorEstoque()
        {
            Console.WriteLine("Criando o Controlador de Estoque");
            ControladorEstoque controladorestoque = new ControladorEstoque();
            Console.WriteLine("Teste de Integração do Controlador de Estoque - Sistema de Estoque DELL");
            controladorestoque.criarSistemaEstoqueAdapter("DELL");
            controladorestoque.aumentarQuantidadeItem();
            Console.WriteLine("Teste de Integração do Controlador de Estoque - Sistema de Estoque IBM");
            controladorestoque.criarSistemaEstoqueAdapter("IBM");
            controladorestoque.aumentarQuantidadeItem();
        }
    }
}
