using System;
using System.Collections.Generic;
using System.Linq;
namespace CursoCSharp.ClassesEMetodos
{

    using CursoCSharp.IPessoa;
    public class Pessoa : IPessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

        // Construtor da classe
        public Pessoa(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }

        // Implementação do método da interface
        public void MostrarInformacoes()
        {
            Console.WriteLine($"Nome: {Nome}, Idade: {Idade}");
        }
    }
}
