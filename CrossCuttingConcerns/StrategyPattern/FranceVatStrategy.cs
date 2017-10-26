namespace CrossCuttingConcerns.StrategyPattern
{
    public class FranceVatStrategy : IVatStrategy
    {
        public string CountryCode => "FR";
        public int GetVat() => 20;
    }
}
