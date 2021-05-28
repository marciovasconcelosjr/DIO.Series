using System;

namespace DIO.Series.Classes.Funções
{
    public class Visualizar
    {
        public void ListagemSeries(SeriesRepositorio repositorio)
        {
            Console.WriteLine("Listar Séries:");

            var lista = repositorio.Lista();
            
            if (lista.Count == 0)
            {
                Console.WriteLine("Nenhuma série cadastrada.");
                return;
            }

            foreach (var serie in lista)
            {
                var excluido = serie.retornaExcluido();

                Console.WriteLine("#ID {0}: - {1} - {2}", serie.retornaId(), serie.retornaTitulo(), (excluido ? "*Excluido*" : ""));
            }
        }

        public void VisualizarPorID(SeriesRepositorio repositorio)
        {
            Console.WriteLine("Digite o ID da Seríe: ");
            int indiceSerie = int.Parse(Console.ReadLine());

            var serie = repositorio.RetornaPorId(indiceSerie);

            Console.WriteLine(serie);
        }
    }
}