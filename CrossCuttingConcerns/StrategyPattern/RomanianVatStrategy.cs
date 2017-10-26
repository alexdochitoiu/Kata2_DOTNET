namespace CrossCuttingConcerns.StrategyPattern
{
    public class RomanianVatStrategy : IVatStrategy
    {
        public string CountryCode => "RO";
        public int GetVat() => 19;
    }
}
