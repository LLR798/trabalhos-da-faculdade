using System;
using System.Collections.Generic;
using System.IO;
using BankTariffSystem.Models;

namespace BankTariffSystem;

// Classe para representar os dados de cada linha do arquivo
class CustomerData
{
    public string CPF { get; set; }
    public string Name { get; set; }
    public decimal CheckingBalance { get; set; }
    public decimal InternationalBalance { get; set; }
    public decimal CryptoBalance { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        // Obtenha o caminho completo para o arquivo 'data.txt' no diretório 'Data'
        string dataFilePath = "/Users/lucaslumertz/Documents/1Programacao/Projetos/Faculdade/trabalhos-da-faculdade/Csharp/assessment-bloco-de-entrada/BankTariffSystem/BankTariffSystem/Data/data.txt";

        // Lê o arquivo de dados
        List<CustomerData> customerDataList = ReadDataFromFile(dataFilePath);
        
        // Instancia o sistema de tarifas
        var tariffSystem = new TariffSystem();

        // Define um método de callback para exibir mensagens de arquivo gerado
        Action<string> FileGeneratedCallback = (cpf) => { Console.WriteLine($"Arquivo gerado para o CPF {cpf}"); };

        // Assina o evento de conclusão do somatório
        tariffSystem.TariffCalculationCompleted += (cpf, totalBalance, totalTariff) =>
        {
            // Escreve os dados do cliente em um arquivo
            WriteCustomerDataToFile(cpf, totalBalance, totalTariff);
            // Dispara o callback de arquivo gerado
            FileGeneratedCallback(cpf);
        };

        // Calcula os somatórios de saldo e tarifa para cada cliente
        foreach (var customerData in customerDataList)
        {
            // Cria objetos de conta com base nos dados do cliente
            var checkingAccount = new CheckingAccount(customerData.CheckingBalance);
            var internationalAccount =
                new InternationalAccount(customerData.InternationalBalance, customerData.CheckingBalance);
            var cryptoAccount = new CryptoAccount(customerData.CryptoBalance);

            // Adiciona as contas ao sistema de tarifas
            tariffSystem.AddAccount(checkingAccount);
            tariffSystem.AddAccount(internationalAccount);
            tariffSystem.AddAccount(cryptoAccount);

            // Dispara o evento de conclusão do somatório para o cliente
            tariffSystem.OnTariffCalculationCompleted(customerData.CPF, tariffSystem.TotalBalance,
                tariffSystem.TotalTariff);
        }

        Console.WriteLine("Process completed. Press any key to exit.");
        Console.ReadKey();
    }

    // Método para ler os dados do arquivo e criar uma lista de objetos CustomerData
    static List<CustomerData> ReadDataFromFile(string filePath)
    {
        List<CustomerData> customerDataList = new List<CustomerData>();

        try
        {
            using (StreamReader sr = new StreamReader(filePath))
            {
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    string[] parts = line.Split('|');

                    if (parts.Length == 5)
                    {
                        var customerData = new CustomerData
                        {
                            CPF = parts[0].Trim(),
                            Name = parts[1].Trim(),
                            CheckingBalance = decimal.Parse(parts[2].Trim()),
                            InternationalBalance = decimal.Parse(parts[3].Trim()),
                            CryptoBalance = decimal.Parse(parts[4].Trim())
                        };

                        customerDataList.Add(customerData);
                    }
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error reading the file: {ex.Message}");
        }

        return customerDataList;
    }

    // Método para escrever os dados do cliente em um arquivo
    static void WriteCustomerDataToFile(string cpf, decimal totalBalance, decimal totalTariff)
    {
        string fileName = $"{cpf}.txt";
        using (StreamWriter sw = new StreamWriter(fileName))
        {
            sw.WriteLine($"{totalBalance} | {totalTariff}");
        }
    }
}