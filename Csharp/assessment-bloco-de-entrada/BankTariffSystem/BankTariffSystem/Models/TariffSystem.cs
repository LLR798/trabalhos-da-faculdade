namespace BankTariffSystem.Models;


class TariffSystem
{
    private decimal _totalBalance;
    private decimal _totalTariff;

    public decimal TotalBalance
    {
        get => _totalBalance;
        set
        {
            if (value <= 0)
            {
                throw new ArgumentOutOfRangeException("Total balance cannot be less than zero.");
            }
            _totalBalance = value;
        }
    }

    public decimal TotalTariff
    {
        get => _totalTariff;
        set
        {
            if (value <= 0)
            {
                throw new ArgumentOutOfRangeException("Total tariff cannot be less than zero.");
            }
            _totalTariff = value;
        }
    }

    // Evento para notificar o término do cálculo
    public event Action<string, decimal, decimal> TariffCalculationCompleted;

    // Método para disparar o evento
    public void OnTariffCalculationCompleted(string cpf, decimal totalBalance, decimal totalTariff)
    {
        TariffCalculationCompleted?.Invoke(cpf, totalBalance, totalTariff);
    }        

    public void AddAccount(Account account)
    {
        if (account is CheckingAccount checkingAccount)
        {
            decimal tariff = checkingAccount.Calculate(1.5m); // Pass the tariff value, e.g., 1.5%.
            TotalBalance += checkingAccount.Balance;
            TotalTariff += tariff;
        }
        else if (account is InternationalAccount internationalAccount)
        {
            decimal tariff = internationalAccount.Calculate(2.5m); // Pass the tariff value, e.g., 2.5%.
            TotalBalance += internationalAccount.Balance;
            TotalTariff += tariff;
        }
        else if (account is CryptoAccount cryptoAccount)
        {
            // For CryptoAccount, there is no tariff, just add the balance.
            TotalBalance += cryptoAccount.Balance;
        }
    }
}