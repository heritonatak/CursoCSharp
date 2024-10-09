using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    class Interpolacao
    {
        public static void Executar() {
            string nome = "Notebook Gamer";
            string marca = "Dell";
            double preco = 5900.00;

            // Tipos de Interpolacão
            Console.WriteLine("O {0} da marca {1} custa {2}.",nome, marca, preco);
            Console.WriteLine($"O {nome} da marca {marca} custa {preco}");
            Console.WriteLine($"1 + 1 = {1 + 1}!");
        }
    }
}
