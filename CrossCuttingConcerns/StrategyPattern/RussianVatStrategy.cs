namespace CrossCuttingConcerns.StrategyPattern
{
    public class RussianVatStrategy : IVatStrategy
    {
        public string CountryCode => "RU";
        public int GetVat() => 18;
    }
}
