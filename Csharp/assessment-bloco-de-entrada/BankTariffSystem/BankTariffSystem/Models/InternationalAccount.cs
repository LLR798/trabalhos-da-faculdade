namespace BankTariffSystem.Models;

class InternationalAccount : Account, ITariff
{
    private const double rateCambioRealDolar = 5.0;
    public InternationalAccount(double valueCurrentBalanceInDollar) : base(valueCurrentBalanceInDollar) { }

    public override double BalanceValue 
    { 
        get => base.BalanceValue; 
        protected set 
        {
            base.BalanceValue = value * rateCambioRealDolar;
        }
    }
    
    public double Calculate() => BalanceValue * 2.5 / 100;
}