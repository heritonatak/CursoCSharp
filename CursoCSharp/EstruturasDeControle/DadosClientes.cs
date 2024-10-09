using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasDeControle
{
    class DadosClientes
    {
        // Propriedade pública para expor o valor da pessoa
        public static string nomeCliente { get; private set; } = "Heriton Vieira";  // Define o valor inicial
        public static int idadeCliente { get; private set; } = 28;  

        public static double pesoCliente { get; private set; } = 50.90;
        public static double alturaCliente { get; private set; } = 1.90;
        public static char sexoCliente { get; private set; } = 'M';


    }
}
