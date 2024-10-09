using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp
{
    class OperadoresRelacionais
    {
        public static void Executar()
        {
            //double nota = 6.0;
            Console.WriteLine("Digite a nota do aluno:");
            double.TryParse(Console.ReadLine(), out double nota);
            double notaDecorte = 7.0;

            Console.WriteLine($"Nota inválida {nota > 10}");
            Console.WriteLine($"Nota inválida {nota < 0}");
            Console.WriteLine($"Perfeito? {nota == 10.0}");
            Console.WriteLine($"Tem como melhorar: {nota != 10.0}");
            Console.WriteLine($"Passou por média? {nota >= notaDecorte}");
            Console.WriteLine($"Recuperação? {nota < notaDecorte}");
            Console.WriteLine($"Reprovado? {nota <= 3.0}");
        }
    }
}
 