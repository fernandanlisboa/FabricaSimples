using System;
using System.Collections.Generic;
using System.Text;

namespace Parte5
{
    public class ControladorContabil
    {
        private SistemaContabilAdapter sistemacontabilAdapter;

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
            else if (nome.Equals("SAP"))
                this.sistemacontabilAdapter = new SistemaContabilAdapterSAP();
        }

        public void calcularImposto()
        {
            this.sistemacontabilAdapter.registrarImposto();
        }
    }


}
