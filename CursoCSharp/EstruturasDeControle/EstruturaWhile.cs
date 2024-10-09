using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasDeControle
{
    class EstruturaWhile
    {
        public static void Executar()
        {
            
            int palpite = 0;
            Random random = new Random();
            int numeroSecreto = random.Next(1, 16);
            bool numeroEncontrado = false;
            int tentativaRestantes = 5;
            int tentativas = 0;
           
            
            while (tentativaRestantes > 0 && !numeroEncontrado)
            {
                Console.WriteLine("Insira o seu palpite:");
                string entrada = Console.ReadLine();
                int.TryParse(entrada, out  palpite);

                tentativas++;
                tentativaRestantes--;

                if (numeroSecreto == palpite)
                {
                    numeroEncontrado = true;
                    var corAmterior = Console.BackgroundColor;
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Numero encontrado em {tentativas} tentativas");
                    Console.BackgroundColor = corAmterior;
                }
                else if (palpite > numeroSecreto)
                {
                    Console.WriteLine("Menor... Tente Novamente!");
                    Console.WriteLine($"Tentativas restantes {tentativas} ");
                }
                else
                {
                    Console.WriteLine("Maior... Tente novamente");
                    Console.WriteLine($"Tentativas restantes {tentativas}");
                }
                
            }
        }
    }
}
