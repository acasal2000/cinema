using System;
using System.Collections.Generic;
using System.Text;

namespace cinema
{
    public class Clientes
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        static List<ListaClientes> listagemClientes = new List<ListaClientes>();
        static List<ListaFilmesAlugados> listagemFilmesAlugados = new List<ListaFilmesAlugados>();
        List<ListaFilmesDisponiveis> listagemFilmesDisponiveis = new List<ListaFilmesDisponiveis>();

        public Clientes(string nome, int idade)
        {
            this.Nome = nome;
            this.Idade = idade;

            var inserirCliente = new ListaClientes(nome, idade);
            listagemClientes.Add(inserirCliente);
        }

        public static void alugarFilme(string cliente, string filme)
        {
            var listar = new ListaFilmesAlugados(cliente, filme);
            listagemFilmesAlugados.Add(listar);
            Filmes.removerFilmeDisponivel(filme);
        }

        public static void listarFilmesAlugados(string cliente)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\n***********************");
            Console.WriteLine("*** FILMES ALUGADOS ***");
            Console.WriteLine("***********************\n");
            Console.ResetColor();

            if (listagemFilmesAlugados.Count != 0)
            {
                for (int i = 0; i < listagemFilmesAlugados.Count; i++)
                {
                    if (listagemFilmesAlugados[i].Cliente == cliente)
                    {
                        Console.WriteLine($"- {listagemFilmesAlugados[i].Filme}");
                    }
                }
            }
            else
            {
                Console.WriteLine("Não tens nenhum filme alugado!");
                Console.ReadLine();
                Console.Clear();
            }

        }

        public static void listarTodosFilmesAlugados()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\n***********************");
            Console.WriteLine("*** FILMES ALUGADOS ***");
            Console.WriteLine("***********************\n");
            Console.ResetColor();

            Console.WriteLine($"CLIENTE\t\tFILME\n");

            foreach (var item in listagemFilmesAlugados)
            {
                Console.WriteLine($"{item.Cliente}\t\t{item.Filme}");
            }
        }

        public static void removerFilmeDaLista(string nomeCliente, string nomeFilme)
        {
            for (int i = 0; i < listagemFilmesAlugados.Count; i++)
            {
                if (listagemFilmesAlugados[i].Filme == nomeFilme && listagemFilmesAlugados[i].Cliente == nomeCliente)
                {
                    Filmes.adicionarFilmeDisponivel(nomeCliente, nomeFilme);
                    listagemFilmesAlugados.RemoveAt(i);
                    
                    return;
                }
            }
        }

        public static bool verificarFilmeExisteAlugado(string nomeFilme)
        {
            for (int i = 0; i < listagemFilmesAlugados.Count; i++)
            {
                if (listagemFilmesAlugados[i].Filme == nomeFilme)
                {
                    // Filme Existe
                    return true;
                }
            }
            Console.WriteLine("\n O filme introduzido não existe!");
            return false;
        }

        public static bool confirmarClienteExiste(string nome)
        {
            foreach (var item in listagemClientes)
            {
                if (nome == item.Nome)
                {
                    return true;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nERRO: O utilizador introduzido não existe.\n");
                    Console.ResetColor();
                }
            }
            return false;
        }
    }
}
