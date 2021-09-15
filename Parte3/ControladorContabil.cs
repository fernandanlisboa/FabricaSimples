using System;
using System.Collections.Generic;
using System.Text;

namespace Parte3
{
    public class ControladorContabil
    {
        private ISistemaContabilAdapter sistemacontabilAdapter;

        public ControladorContabil()
        {
            Console.WriteLine("Controlador de Sistema Contábil Criado!");
        }

        public void criarSistemaContabilAdapter(string nome)
        {
            if (nome.Equals("IBM"))
                this.sistemacontabilAdapter = new SistemaContabilAdapterIBM();
            else if (nome.Equals("DELL"))
                this.sistemacontabilAdapter = new SistemaContabilAdapterDELL();
        }

        public void calcularImposto()
        {
            this.sistemacontabilAdapter.registrarImposto();
        }
    }


}
