namespace BankTariffSystem.Models;

sealed class CryptoAccount : Account, ITariff
{
    public CryptoAccount(decimal dollarBalance) : base(dollarBalance * 5m)
    {
        DollarBalance = dollarBalance;
    }

    private decimal _dollarBalance;
    public decimal DollarBalance
    {
        get => _dollarBalance;
        set
        {
            if (value <= 0)
            {
                throw new ArgumentOutOfRangeException("Balance cannot be less than zero.");
            }
            _dollarBalance = value;
        }
    }

    public decimal Calculate(decimal tariff)
    {
        // Crypto account has no tariff.
        tariff = 0m;
        return tariff;
    }
}