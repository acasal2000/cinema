using System;
using System.Collections.Generic;
using System.Text;

namespace cinema
{
    public class Filmes
    {
        public static string NomeFilme { get; set; }
        public static string Genero { get; set; }
        public static int Ano { get; set; }
        public static string Sinopse { get; set; }

        static List<ListaFilmesDisponiveis> listagemFilmes = new List<ListaFilmesDisponiveis>();
        static List<ListaFilmesDisponiveis> filmesRemovidos = new List<ListaFilmesDisponiveis>();
                
        public Filmes(string nome, string genero, int ano, string sinopse)
        {
            NomeFilme = nome;
            Genero = genero;
            Ano = ano;
            Sinopse = sinopse;

            var adicionarFilme = new ListaFilmesDisponiveis(nome, genero, ano, sinopse, DateTime.Now);
            listagemFilmes.Add(adicionarFilme);
        }

        public Filmes() { }

        public static void listarFilmesDisponiveis()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\n**************************");
            Console.WriteLine("*** FILMES DISPONÍVEIS ***");
            Console.WriteLine("**************************\n");
            Console.ResetColor();

            foreach (var item in listagemFilmes)
            {
                Console.WriteLine("- " + item.NomeFilme);
            }
        }

        public static void removerFilmeDisponivel(string nomeFilme)
        {
            for (int i = 0; i < listagemFilmes.Count; i++)
            {
                if (listagemFilmes[i].NomeFilme == nomeFilme)
                {
                    var filmeRemovido = new ListaFilmesDisponiveis(listagemFilmes[i].NomeFilme, listagemFilmes[i].Genero, listagemFilmes[i].Ano, listagemFilmes[i].Sinopse, DateTime.Now);
                    filmesRemovidos.Add(filmeRemovido);
                    listagemFilmes.RemoveAt(i);
                }
            }
        }

        public static void adicionarFilmeDisponivel(string cliente, string nomeFilme)
        {
            foreach (var item in filmesRemovidos)
            {
                if (item.NomeFilme == nomeFilme)
                {
                    var adicionarFilme = new ListaFilmesDisponiveis(item.NomeFilme, item.Genero, item.Ano, item.Sinopse, DateTime.Now);
                    listagemFilmes.Add(adicionarFilme);
                }
            }
        }

        public static bool verificarFilmeExiste(string nomeFilme)
        {
            for (int i = 0; i < listagemFilmes.Count; i++)
            {
                if (listagemFilmes[i].NomeFilme == nomeFilme)
                {
                    // Filme Existe
                    return true;
                }
            }
            Console.WriteLine("\n O filme introduzido não existe!");
            return false;
        }

        public static void informacoesFilme(string nomeFilme)
        {

            for (int i = 0; i < listagemFilmes.Count; i++)
            {
                if (listagemFilmes[i].NomeFilme == nomeFilme)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("\n***");
                    for (int c = 0; c < 1; c++)
                    {
                        for (int b = 0; b < listagemFilmes[i].NomeFilme.Length + 2; b++)
                        {
                            Console.Write("*");
                        }
                    }
                    Console.Write("***");
                    Console.WriteLine($"\n*** {nomeFilme} ***");

                    for (int c = 0; c < 1; c++)
                    {
                        for (int b = 0; b < listagemFilmes[i].NomeFilme.Length + 2; b++)
                        {
                            Console.Write("*");
                        }
                    }
                    Console.Write("******\n");

                    Console.ResetColor();
                    Console.WriteLine("\nAno: " + listagemFilmes[i].Ano + "\n");
                    Console.WriteLine("Categoria: " + listagemFilmes[i].Genero + "\n");
                    Console.WriteLine("Sinópse: \n\n" + listagemFilmes[i].Sinopse);
                }

            }
        }

    }
}
