using System;
using System.Collections.Generic;
using System.Text;

namespace cinema
{
    public class ListaFilmesDisponiveis
    {
        public string NomeFilme { get; }
        public string Genero { get; }
        public int Ano { get; }
        public DateTime Data { get; }
        public string Sinopse { get; }

        public ListaFilmesDisponiveis(string nomeFilme, string genero, int ano, string sinopse, DateTime data)
        {
            this.NomeFilme = nomeFilme;
            this.Genero = genero;
            this.Ano = ano;
            this.Data = data;
            this.Sinopse = sinopse;
        }

        public ListaFilmesDisponiveis() { }

    }
}
