using System;
using CursoCSharp.RelatorioOfx;

namespace CursoCSharp.RelatorioOfx
{
    // Classe principal para importar o arquivo OFX e exibir as informações extraídas
    class ImportOfx
    {
        // Método Main executado ao rodar o programa
        static void Main(string[] args)
        {
            // Define o caminho do arquivo OFX (substitua pelo caminho correto)
            string filePath = "C:/Users/bugbounty/Documents/arquivo.ofx"; // Substitua pelo caminho correto

            // Chama o método ParseOfx para carregar e interpretar o arquivo OFX
            BankStatement statement = OfxParser.ParseOfx(filePath);

            // Exibe as informações do extrato bancário
            Console.WriteLine("Conta: " + statement.AccountId); // Exibe o número da conta
            Console.WriteLine("Moeda: " + statement.Currency); // Exibe a moeda do extrato

            // Exibe as transações bancárias
            foreach (var transaction in statement.Transactions)
            {
                // Exibe cada transação com tipo, data, valor e nome
                Console.WriteLine($"Tipo: {transaction.Type}, Data: {transaction.PostedDate}, Valor: {transaction.Amount}, Nome: {transaction.Name}");
            }

            // Exibe os saldos
            Console.WriteLine("Saldo Ledger: " + statement.LedgerBalance); // Exibe o saldo total do extrato
            Console.WriteLine("Saldo Disponível: " + statement.AvailableBalance); // Exibe o saldo disponível
        }
    }
}
