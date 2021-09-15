using System;
using System.Collections.Generic;
using System.Text;

namespace Parte6
{
    public class ControladorContabil
    {
        private SistemaContabilAdapter sistemacontabilAdapter;
        private AdapterFactory factory;

        public ControladorContabil()
        {
            Console.WriteLine("Controlador de Sistema Contábil Criado!");
            this.factory = AdapterFactory.getInstance();
        }

        public void criarSistemaContabilAdapter(string nome)
        {
            this.sistemacontabilAdapter = this.factory.criarSistemaContabilAdapter(nome);
        }

        public void calcularImposto()
        {
            this.sistemacontabilAdapter.registrarImposto();
        }
    }


}
