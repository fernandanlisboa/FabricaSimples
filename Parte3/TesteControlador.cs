using System;

namespace Parte3
{
    public class TesteControlador
    {
        public static void Main(string[] args)
        {
            testeControladoraRegistradora();
        }
        public static void testeControladoraRegistradora()
        {
            Console.WriteLine("Criando o Controlador da Registradora");
            ControladorRegistradora controladorregistradora = new ControladorRegistradora();
            Console.WriteLine("Teste de Integração do Controlador da Registradora - Sistema de Estoque DELL");
            controladorregistradora.criarSistemaEstoqueAdapter("DELL");
            controladorregistradora.diminuirQuantidadeItem();
            Console.WriteLine("Teste de Integração do Controlador da Registradora - Sistema de Estoque IBM");
            controladorregistradora.criarSistemaEstoqueAdapter("IBM");
            controladorregistradora.diminuirQuantidadeItem();
            Console.WriteLine("Teste de Integração do Controlador da Registradora - Sistema Contabil DELL");
            controladorregistradora.criarSistemaContabilAdapter("DELL");
            controladorregistradora.registrarVendaSistemaContabil();
            Console.WriteLine("Teste de Integração do Controlador da Registradora - Sistema Contabil IBM");
            controladorregistradora.criarSistemaContabilAdapter("IBM");
            controladorregistradora.registrarVendaSistemaContabil();
        }
    }
}
