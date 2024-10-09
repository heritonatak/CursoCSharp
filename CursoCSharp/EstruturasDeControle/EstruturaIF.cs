using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasDeControle
{
    class EstruturaIF
    {
        public static void Executar()
        {
            bool bomComportamento = false;
            string entrada;

            Console.WriteLine("Digite a nota do aluno");
            entrada = Console.ReadLine();
            Double.TryParse(entrada, out double nota);

            Console.WriteLine("Possui bom comportamento (S/N):");
            entrada = Console.ReadLine();

            //if (entrada == "S" || entrada == "s")    // Exemplo 01
            //    bomComportamento = true;

            //bomComportamento = entrada == "S" || entrada == "s";   // Exemplo 02
            bomComportamento = entrada.ToLower() == "s";  // Exemplo 03

            if(nota >= 9.0 && bomComportamento)
            {
                Console.WriteLine("Quadro de honra!");
            }

        }
    }
}
