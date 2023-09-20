namespace BankTariffSystem.Models;

abstract class Account
{
    // Constructor:
    public Account(decimal initialBalance)
    {
        Balance = initialBalance;
    }

    // Field:
    private decimal _balance;

    // Property:
    public virtual decimal Balance
    {
        get => _balance;
        set
        {
            if (value <= 0)
            {
                throw new ArgumentOutOfRangeException("Balance cannot be less than zero.");
            }
            _balance = value;
        }
    }
}