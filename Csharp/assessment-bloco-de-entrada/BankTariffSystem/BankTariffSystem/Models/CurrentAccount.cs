namespace BankTariffSystem.Models;

class CurrentAccount : Account, ITariff
{
    public CurrentAccount(double valueCurrentBalance) : base(valueCurrentBalance){}

    public double Calculate() => BalanceValue * 1.5 /100;
    
}