using Parte1;
using System;

namespace PraticaFabricaSimples
{
    public class TesteControlador
    {
        static void Main(string[] args)
        {
            testeControladorContabil();
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

        
    }
}
