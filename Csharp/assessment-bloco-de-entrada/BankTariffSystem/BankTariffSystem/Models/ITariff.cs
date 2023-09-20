namespace BankTariffSystem.Models;

public interface ITariff
{
    decimal Calculate(decimal tariff);
}