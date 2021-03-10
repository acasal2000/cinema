using System;

namespace cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome = "";
            int opcao = 0;

            // Criaçao dos Objetos [ FILMES ]
            Filmes filme1 = new Filmes("Homem-Aranha 3", "Ação", 2007, " O relacionamento entre Peter Parker e Mary Jane parece estar dando certo, \n" +
                " mas outros problemas começam a surgir. A roupa de Homem-Aranha torna-se \n" +
                " preta e acaba controlando Peter - apesar de aumentar seus poderes, ela revela e \n" +
                " amplia o lado obscuro de sua personalidade. Com isso, os vilões Venom e Homem-Areia tentam destruir o herói.");

            Filmes filme2 = new Filmes("Capitão América: Guerra Civil", "Ação", 2016, " Depois do ataque de Ultron, os políticos decidem controlar os Vingadores, já que suas ações \n" +
                " afetam toda a humanidade. A decisão coloca o Capitão América em rota de colisão com o Homem de Ferro.");
           
            Filmes filme3 = new Filmes("Joker", "Drama", 2019, " Isolado, intimidado e desconsiderado pela sociedade, o fracassado comediante Arthur Fleck\n" +
                " inicia seu caminho como uma mente criminosa após assassinar três homens em pleno metrô.\n" +
                " Sua ação inicia um movimento popular contra a elite de Gotham City, da qual Thomas Wayne é seu maior representante.");

            Filmes filme4 = new Filmes("Snowden", "Biografia", 2016, " Ex-funcionário terceirizado da Agência de Segurança dos Estados Unidos, \n" +
                " Edward Snowden (Joseph Gordon-Levitt) torna-se inimigo número um da nação\n" +
                " ao divulgar a jornalistas uma série de documentos sigilosos que comprovam atos de espionagem\n" +
                " praticados pelo governo estadunidense contra cidadãos comuns e lideranças internacionais. ");

            ////~//~// //~//~//~//~//~//~//~//~//~//~//~//~//~//~//~//~//~//~//~//~//~//~//~//~//~//~//

            Clientes cli1 = new Clientes("André", 20);
            Clientes cli2 = new Clientes("João", 20);

            Console.WriteLine("Introduz o teu nome: ");
            nome = Console.ReadLine();

            if (Clientes.confirmarClienteExiste(nome))
            {
                Console.Clear();

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("***********************");
                Console.WriteLine($"*** Bem Vindo {nome} ***");
                Console.WriteLine("***********************\n");
                Console.ResetColor();

                do
                {
                    Console.WriteLine("\nEscolhe uma das seguintes ações: \n");
                    Console.Write("1. Consultar os filmes disponíveis\n2. Alugar um filme\n3. Consultar os meus filmes alugados\n4. Remover Filme da Lista\n5. Limpar a Consola\n\nOpção: ");
                    opcao = Convert.ToInt32(Console.ReadLine());

                    switch (opcao)
                    {
                        case 1:
                            Filmes.listarFilmesDisponiveis();
                            Console.WriteLine("\nDesejas consultar informações acerca de algum filme? (s / n)");
                            string info = Console.ReadLine();

                            if (info == "s" || info == "S")
                            {
                                Console.WriteLine("\nIntroduz o nome do filme: ");
                                string infoFilme = Console.ReadLine();

                                if (Filmes.verificarFilmeExiste(infoFilme))
                                {
                                    Console.Clear();
                                    Filmes.informacoesFilme(infoFilme);
                                }
                            }
                            else
                            {
                                Console.Clear();
                            }
                            break;

                        case 2:

                            Console.WriteLine("\nIntroduz o nome do filme que desejas alugar:");
                            string nomeFilme = Console.ReadLine();
                            if (Filmes.verificarFilmeExiste(nomeFilme))
                            {
                                Clientes.alugarFilme(nome, nomeFilme);                                
                            }

                            break;
                        case 3:
                            Clientes.listarFilmesAlugados(nome);
                            break;
                        case 4:
                            Console.WriteLine("\nIntroduz o nome do filme que desejas remover: ");
                            string nomeFilme1 = Console.ReadLine();
                            if (Clientes.verificarFilmeExisteAlugado(nomeFilme1))
                            {
                                Clientes.removerFilmeDaLista(nome,nomeFilme1);
                            }
                            break;
                        case 5:
                            Console.Clear();
                            break;
                        default:
                            break;
                    }
                }
                while (opcao != default);
            }
            Console.ReadLine();
        }
    }
}
