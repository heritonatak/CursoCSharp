using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace CursoCSharp.RelatorioOfx
{
    // Define uma classe para representar uma transação bancária
    public class Transaction
    {
        // Tipo da transação, por exemplo, "DEBIT" ou "CREDIT"
        public string Type { get; set; }
        // Data em que a transação foi realizada
        public DateTime PostedDate { get; set; }
        // Valor da transação
        public decimal Amount { get; set; }
        // Identificador único da transação
        public string FitId { get; set; }
        // Nome associado à transação
        public string Name { get; set; }
        // Memorização adicional da transação (detalhes extras)
        public string Memo { get; set; }
    }

    // Define uma classe que representa um extrato bancário
    public class BankStatement
    {
        // Moeda utilizada no extrato (ex: "BRL")
        public string Currency { get; set; }
        // Código do banco
        public string BankId { get; set; }
        // Número da conta bancária
        public string AccountId { get; set; }
        // Tipo de conta bancária (ex: "CHECKING")
        public string AccountType { get; set; }
        // Lista de transações associadas ao extrato
        public List<Transaction> Transactions { get; set; }
        // Saldo do extrato (Ledger Balance)
        public decimal LedgerBalance { get; set; }
        // Saldo disponível para o cliente (Available Balance)
        public decimal AvailableBalance { get; set; }
    }

    // Define a classe responsável por analisar o arquivo OFX
    public class OfxParser
    {
        // Método estático que lê e interpreta o arquivo OFX
        public static BankStatement ParseOfx(string filePath)
        {
            // Carrega o documento XML (arquivo OFX)
            XDocument doc = XDocument.Load(filePath);

            // Cria um objeto BankStatement e preenche com os dados extraídos do arquivo OFX
            var stmt = new BankStatement
            {
                // Obtém o valor da moeda do extrato
                Currency = doc.Root.Element("BANKMSGSRSV1")
                                  .Element("STMTTRNRS")
                                  .Element("STMTRS")
                                  .Element("CURDEF").Value,
                // Obtém o código do banco
                BankId = doc.Root.Element("BANKMSGSRSV1")
                                 .Element("STMTTRNRS")
                                 .Element("STMTRS")
                                 .Element("BANKACCTFROM")
                                 .Element("BANKID").Value,
                // Obtém o número da conta
                AccountId = doc.Root.Element("BANKMSGSRSV1")
                                    .Element("STMTTRNRS")
                                    .Element("STMTRS")
                                    .Element("BANKACCTFROM")
                                    .Element("ACCTID").Value,
                // Obtém o tipo da conta (CHECKING, SAVINGS, etc.)
                AccountType = doc.Root.Element("BANKMSGSRSV1")
                                      .Element("STMTTRNRS")
                                      .Element("STMTRS")
                                      .Element("BANKACCTFROM")
                                      .Element("ACCTTYPE").Value,
                // Inicializa a lista de transações
                Transactions = new List<Transaction>()
            };

            // Itera sobre todas as transações no arquivo OFX
            foreach (var trn in doc.Root.Element("BANKMSGSRSV1")
                                       .Element("STMTTRNRS")
                                       .Element("STMTRS")
                                       .Element("BANKTRANLIST")
                                       .Elements("STMTTRN"))
            {
                // Cria e preenche um objeto Transaction para cada transação no arquivo
                var transaction = new Transaction
                {
                    Type = trn.Element("TRNTYPE").Value, // Tipo da transação (DEBIT ou CREDIT)
                    PostedDate = DateTime.ParseExact(trn.Element("DTPOSTED").Value, "yyyyMMddHHmmss", null), // Converte a data para DateTime
                    Amount = decimal.Parse(trn.Element("TRNAMT").Value), // Valor da transação
                    FitId = trn.Element("FITID").Value, // Identificador único da transação
                    Name = trn.Element("NAME").Value, // Nome associado à transação
                    Memo = trn.Element("MEMO").Value // Memo ou descrição adicional
                };

                // Adiciona a transação à lista de transações do extrato
                stmt.Transactions.Add(transaction);
            }

            // Obtém o saldo total do extrato (Ledger Balance)
            stmt.LedgerBalance = decimal.Parse(doc.Root.Element("BANKMSGSRSV1")
                                                      .Element("STMTTRNRS")
                                                      .Element("STMTRS")
                                                      .Element("LEDGERBAL")
                                                      .Element("BALAMT").Value);

            // Obtém o saldo disponível (Available Balance)
            stmt.AvailableBalance = decimal.Parse(doc.Root.Element("BANKMSGSRSV1")
                                                          .Element("STMTTRNRS")
                                                          .Element("STMTRS")
                                                          .Element("AVAILBAL")
                                                          .Element("BALAMT").Value);

            // Retorna o objeto BankStatement preenchido com os dados do OFX
            return stmt;
        }
    }
}
