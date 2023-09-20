namespace BankTariffSystem.Models;

sealed class CheckingAccount : Account, ITariff
{
    public CheckingAccount(decimal balance) : base(balance)
    {
    }
    
    public decimal Calculate(decimal tariff)
    {
        // 1.5% tariff on the balance.
        tariff = Balance * 0.015m;
        return tariff;
    }
}