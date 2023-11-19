namespace BankTariffSystem.Models;

abstract class Account
{
    public Account(double valueCurrentBalance) => BalanceValue = valueCurrentBalance;

    public virtual double BalanceValue { get; protected set; }
}