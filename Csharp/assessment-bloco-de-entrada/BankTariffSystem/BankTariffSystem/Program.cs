using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Globalization;
using BankTariffSystem.Models;

namespace BankTariffSystem
{
    public class Program
    {
        private static NumberStyles style = NumberStyles.AllowDecimalPoint;
        private static CultureInfo culture = CultureInfo.CreateSpecificCulture("pt-br");

        static List<DataFile> ReadFileClients()
        {
            var currentDirectory = Environment.CurrentDirectory;
            var filePath = Path.Combine(currentDirectory, "Data", "data.txt");

            // File reading:
            var lines = File.ReadAllLines(filePath);
            var list = lines.Select(item =>
            {
                var fields = item.Split('|');
                return new DataFile
                {
                    Cpf = fields[0],
                    Name = fields[1],
                    CurrentAccountBalanceValue = ConverterBalance(fields[2]),
                    InternationalAccountBalanceValue = ConverterBalance(fields[3]),
                    CryptoAccountBalanceValue = ConverterBalance(fields[4]),
                };
            }).ToList();
            return list;
        }

        static double ConverterBalance(string field)
        {
            return double.Parse(field, style, culture);
        }

        static void GenerateClientFile(string cpf, double totalBalanceAmount, double totalTariffAmount)
        {
            var currentDirectory = Environment.CurrentDirectory;
            var filePath = Path.Combine(currentDirectory, "Data", $"{cpf}.txt");
            var line = new List<string>
            {
                $"{totalBalanceAmount.ToString("N2", culture)}|{totalTariffAmount.ToString("N2", culture)}",
            };
            File.WriteAllLines(filePath, line);
        }

        static void ShowMessageGeneratedFile(string cpf)
        {
            Console.WriteLine($"File successfully generated for cpf: {cpf}");
        }

        static void Main()
        {
            var list = ReadFileClients();
            var manager = new TariffSystem();

            manager.CalculatedClientEvent += GenerateClientFile;
            manager.CalculateBalanceandCustomerTariff(list, ShowMessageGeneratedFile);
        }
    }
}
