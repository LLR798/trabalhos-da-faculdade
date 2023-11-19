namespace BankTariffSystem.Models;

class CryptoAccount : Account
{
    public static CryptoAccount CreateNewCryptoAccountWithExchange10x()
  => new CryptoAccount(10);

    public static CryptoAccount CreateNewCryptoAccountWithExchange5x()
      => new CryptoAccount(5);
    
    private const double rateCambioRealCrypto = 5.0;
    public CryptoAccount(double valueCurrentBalance) : base(valueCurrentBalance) { }

    public override double BalanceValue
    {
        get => base.BalanceValue;
        protected set
        {
            base.BalanceValue = value * rateCambioRealCrypto;
        }
    }
}