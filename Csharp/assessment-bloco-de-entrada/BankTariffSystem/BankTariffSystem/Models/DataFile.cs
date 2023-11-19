namespace BankTariffSystem.Models;

public class DataFile
{
  public string Cpf { get; set; }
  public string Name { get; set; }
  public double CurrentAccountBalanceValue { get; set; }
  public double InternationalAccountBalanceValue { get; set; }
  public double CryptoAccountBalanceValue { get; set; }
}