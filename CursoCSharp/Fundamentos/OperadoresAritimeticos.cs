using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    class OperadoresAritimeticos
    {
        public static void Executar()
        {
            // Preço com desconto 

            var preco = 1000.0;
            var imposto = 355;
            var desconto = 0.1;

            double total = preco + imposto;
            var totalComDesconto = total - (total * desconto);
            Console.WriteLine($"O preço final é {totalComDesconto}");

            // IMC

            double peso = 91.2;
            double altura = 1.82;
            double imc = peso / Math.Pow(altura, 2); // Math.Pow(), Serve para exponenciação
            Console.WriteLine($"IMC é {imc}");

            // Numero Par/Impar

            int par = 24;
            int impar = 33;
            Console.WriteLine($"{par}/2 tem resto {par % 2}");
            Console.WriteLine($"{impar}/2 tem resto {impar % 2}");

        }
    }
}
