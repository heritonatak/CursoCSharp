namespace CursoCSharp
{
    using CursoCSharp.ClassesEMetodos;

    class ChamaPessoa
    {
        public static void Executar()
        {
            // Criando uma pessoa
            Pessoa pessoa = new Pessoa("Heriton", 30);

            // Chamando o método para exibir as informações
            pessoa.MostrarInformacoes();
        }
    }
}
