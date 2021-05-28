using System;

namespace DIO.Series.Classes.Funções
{
    public class Atualizar
    {
        public Atualizar(SeriesRepositorio repositorio)
        {
            Console.WriteLine("Atualizar série.");
            Console.WriteLine("Digite o ID da série: ");
            int indiceSerie = int.Parse(Console.ReadLine());

            foreach(int i in Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine("{0} - {1}", i , Enum.GetName(typeof(Genero), i));
            }
            Console.WriteLine("Digite o Genero entre as opções acima: ");
            int entradaGenero = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o Título da Série: ");
            string entradaTitulo = Console.ReadLine();

            Console.WriteLine("Digite o Ano de Ínicio da Série: ");
            int entradaAno = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a descrição da série: ");
            string entradaDescricao = Console.ReadLine();            

             Series atualizaSeries = new Series(id: indiceSerie,
                                             genero: (Genero)entradaGenero,
                                             titulo: entradaTitulo,
                                             ano: entradaAno,
                                             descricao: entradaDescricao);

             repositorio.Atualiza(indiceSerie, atualizaSeries);
        }
    }
}