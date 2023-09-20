namespace BankTariffSystem.Models;

sealed class InternationalAccount : Account, ITariff
{
    public InternationalAccount(decimal dollarBalance, decimal balance) : base(balance)
    {
        Balance = dollarBalance;
    }

    private decimal _dollarBalance;

    public override decimal Balance
    {
        get => _dollarBalance * 5m;
        set
        {
            if (value <= 0)
            {
                throw new ArgumentOutOfRangeException("Balance cannot be less than zero.");
            }
            _dollarBalance = value / 5m;
        }
    }

    public decimal Calculate(decimal tariff)
    {
        // 2.5% tariff on the balance.
        tariff = Balance * 0.025m;
        return tariff;
    }
}