using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CursoCSharp.EstruturasDeControle;  // Class DadosClientes

namespace CursoCSharp.EstruturasDeControle
{
    class ImprimeValores
    {
        public static void Executar()
        {
            string nome = DadosClientes.nomeCliente;
            int idade = DadosClientes.idadeCliente;
            double peso = DadosClientes.pesoCliente;
            double altura = DadosClientes.alturaCliente;
            char sexo = DadosClientes.sexoCliente;
            string sexoCli;            
            
            if(sexo == 'M')
            {
                sexoCli = "Masculino";
            }
            else
            {
                sexoCli = "Feminino";
            }

            Console.WriteLine($"Cliente: {nome}");
            Console.WriteLine($"Idade: {idade}");
            Console.WriteLine($"Peso: {peso}");
            Console.WriteLine($"Altura: {altura}");
            Console.WriteLine($"Sexo: {sexoCli}");


        }



    }
}
