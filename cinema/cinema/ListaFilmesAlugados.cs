using System;
using System.Collections.Generic;
using System.Text;

namespace cinema
{
    class ListaFilmesAlugados
    {
        public string Cliente { get; }
        public string Filme { get; }

        public ListaFilmesAlugados(string cliente, string filme)
        {
            this.Cliente = cliente;
            this.Filme = filme;
        }
    }
}
