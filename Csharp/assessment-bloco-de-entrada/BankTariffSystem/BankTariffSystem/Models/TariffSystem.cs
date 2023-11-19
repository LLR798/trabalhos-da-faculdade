namespace BankTariffSystem.Models;


class TariffSystem
{
    public event Action<string, double, double> CalculatedClientEvent;

    public void CalculateBalanceandCustomerTariff(List<DataFile> dataFile, Action<string> callback)
    {
        foreach (var line in dataFile)
        {
            var valueTotalBalance = 0d;
            var valueTotalTariff = 0d;

            var listAccountsCustomer = new List<Account>
      {
        new CurrentAccount(line.CurrentAccountBalanceValue),
        new InternationalAccount(line.InternationalAccountBalanceValue),
        new CryptoAccount(line.CryptoAccountBalanceValue)
      };

            foreach (var account in listAccountsCustomer)
            {
                if (account is ITariff)
                {
                    var accountTarifavel1 = (ITariff)account;
                    valueTotalTariff += accountTarifavel1.Calculate();
                }
                valueTotalBalance += account.BalanceValue;
            }
            CalculatedClientEvent?.Invoke(line.Cpf, valueTotalBalance, valueTotalTariff);
            callback(line.Cpf);
        }
    }
}