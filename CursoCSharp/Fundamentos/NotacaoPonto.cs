using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    class NotacaoPonto
    {
        /// <summary>
        /// .ToUpper() => Isso é um Metodo.
        /// .Length => Isso é um valor.
        /// Utilizando o ( ? ):  Ex:  Console.WriteLine(valorImportante?.Length) serve para validar se esta tudo certo para evitar erro, se estiver vazia não vai esta gerando erro.
        /// </summary>
        public static void Executar() {
            var saudacao = "Olá".ToUpper().Insert(3, " World!")
                .Replace("World!", "Mundo!");

            Console.WriteLine(saudacao);

            Console.WriteLine("O tamanho da palavra (Teste) é => " + "Teste".Length);

            string valorImportante = null;
            Console.WriteLine(valorImportante?.Length);

        }
    }
}
  