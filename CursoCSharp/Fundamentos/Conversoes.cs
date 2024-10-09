using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    class Conversoes
    {
        public static void Executar() {
            int inteiro = 10;
            double quebrado = inteiro;
            Console.WriteLine(quebrado);

            
            double nota = 9.7;
            // int notaTruncada = nota;  // Conversão Implicita Gera problemas na coverssão perdas de valores
            int notaTruncada = (int) nota; // Castin (int) valor da variavel  //   Conversão Explicita gera perda do valor 9.7:  Saida => 9
            Console.WriteLine($"Nota truncada: {nota} => {notaTruncada}");


            // Converte de String para Numero
            Console.WriteLine("Digite sua idade:");
            string idadeString = Console.ReadLine();

            int idadeInteiro = int.Parse(idadeString);
            Console.WriteLine($"Idade inserida : {idadeInteiro}");

            idadeInteiro = Convert.ToInt32(idadeInteiro);
            Console.WriteLine($"Resultado: {idadeInteiro}");

            // Primeira Opção
            Console.WriteLine("Digite o primeiro numero");
            string palavra1 = Console.ReadLine();
            int numero1;
            int.TryParse(palavra1, out numero1);
            Console.WriteLine($"Resultado 1: {numero1}");

            // Segunda Opção
            Console.WriteLine("Digite o segundo valor");
            int.TryParse(Console.ReadLine(), out int numero2);
            Console.WriteLine($"Resultado 2 {numero2}");



        }
    }
}
