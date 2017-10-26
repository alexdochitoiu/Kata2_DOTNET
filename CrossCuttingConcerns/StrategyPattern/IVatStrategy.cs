namespace CrossCuttingConcerns.StrategyPattern
{
    public interface IVatStrategy
    {
        string CountryCode { get; }
        int GetVat();
    }
}
