using System;
using DIO.Series;
using DIO.Series.Classes.Funções;

namespace DIO.Series
{
    class Program
    {
        static SeriesRepositorio repositorio = new SeriesRepositorio();
        static void Main(string[] args)
        {
            string opcaoUsuario = ObterOpcaoDoUsuario();

            while(opcaoUsuario.ToUpper() != "X")
            {
                switch (opcaoUsuario)
                {
                    case "1":
                        ListarSeries();
                        break;
                    case "2":
                        InserirSeries();
                        break;
                    case "3":
                        AtualizarSeries();
                        break;
                    case "4":
                        ExcluirSeries();
                        break;
                    case "5":
                        VisualizarSeries();
                        break;
                    case "C":
                        Console.Clear();
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }

                opcaoUsuario = ObterOpcaoDoUsuario();
            }
        }

        private static void ListarSeries()
        {
            Visualizar obj = new Visualizar();
            obj.ListagemSeries(repositorio);
        }
        private static void InserirSeries()
        {
            Console.WriteLine("Inserir série.");
            Cadastro obj = new Cadastro(repositorio);
        }        
         private static void AtualizarSeries()
         {
             Atualizar obj = new Atualizar(repositorio);
         }       
        private static void ExcluirSeries()
        {
            Console.WriteLine("Digite o ID da Seríe: ");
            int indiceSerie = int.Parse(Console.ReadLine());
            repositorio.Exclui(indiceSerie);
        }
        private static void VisualizarSeries()
        {
            Visualizar obj = new Visualizar();
            obj.VisualizarPorID(repositorio);
        }


         private static string ObterOpcaoDoUsuario()
        {
            Console.WriteLine();
            Console.WriteLine("Olá...");
            Console.WriteLine("Informe a opção desejada: ");

            Console.WriteLine("1 - Listar séries");
            Console.WriteLine("2 - Inserir nova série");
            Console.WriteLine("3 - Atualizar série");
            Console.WriteLine("4 - Excluir série");
            Console.WriteLine("5 - Visualizar série");
            Console.WriteLine("C - Limpar tela");
            Console.WriteLine("X - Sair");
            Console.WriteLine();

            string opcaoUsuario = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return opcaoUsuario;
            
        }
    }
}
