using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasDeControle
{
    class EstruturaFor
    {
        public static void Executar()
        {
            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine($"O valor de i é {i}");
            //}

            double somatorio = 0;
            string  entrada;

            Console.WriteLine("informe o tamanho da turma");
            entrada = Console.ReadLine();
            int.TryParse(entrada, out int tamanhopTurma);

            for (int i = 1; i < tamanhopTurma; i++)
            {
                Console.WriteLine($"Informe a nota do aluno {i}");
                entrada = Console.ReadLine();
                double.TryParse(entrada, out double notaAtual);

                somatorio += notaAtual;
            }

            double media = tamanhopTurma > 0 ? somatorio / tamanhopTurma : 0;
            Console.WriteLine($"Media da turma {media}");
        }
    }
}
