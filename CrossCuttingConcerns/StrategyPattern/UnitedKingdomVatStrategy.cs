namespace CrossCuttingConcerns.StrategyPattern
{
    public class UnitedKingdomVatStrategy : IVatStrategy
    {
        public string CountryCode => "UK";
        public int GetVat() => 20;
    }
}
