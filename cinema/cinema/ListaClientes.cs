using System;
using System.Collections.Generic;
using System.Text;

namespace cinema
{
    class ListaClientes
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

        public ListaClientes(string nome, int idade)
        {
            this.Nome = nome;
            this.Idade = idade;
        }
    }
}
