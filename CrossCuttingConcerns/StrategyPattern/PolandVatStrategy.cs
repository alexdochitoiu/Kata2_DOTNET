namespace CrossCuttingConcerns.StrategyPattern
{
    public class PolandVatStrategy : IVatStrategy
    {
        public string CountryCode => "PL";
        public int GetVat() => 23;
    }
}
