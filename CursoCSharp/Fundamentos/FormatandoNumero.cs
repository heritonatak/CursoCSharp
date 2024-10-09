using System;
using System.Globalization;
namespace CursoCSharp.Fundamentos
{
    class FormatandoNumero
    {
        public static void Executar()
        {
            double valor = 15.175;
            Console.WriteLine(valor.ToString("F1"));    // (F1) = Quantidade de casas Decimais, Converte para => 15.2
            Console.WriteLine(valor.ToString("C"));     // (C) = Currency (Moeda), convete para moeda Local =>  R$ 15.175.     Obs: Conforme seu sistema esta configurado
            Console.WriteLine(valor.ToString("P"));     // (P) = Percentual, ele multiplica o valor por 100.
            Console.WriteLine(valor.ToString("#.##"));  //"#.##") = Quantidade de casas Decimais, Converte para => 15.18

            CultureInfo cultura = new CultureInfo("en-US");     // configuração da moeda local, ignorando a configuração do sistema
            // CultureInfo cultura = new CultureInfo("pt-BR");  // configuração da moeda local, ignorando a configuração do sistema
            Console.WriteLine(valor.ToString("C0", cultura));   //  (C0) = Currency com quantidade de casas decimais: => R$15
            int inteiro = 345;
            Console.WriteLine(inteiro.ToString("D10", cultura));  // (D10) = Preeche com zero(0) a esquerda Casas decimais e quantidade. 0000000345

        }
    }
}
