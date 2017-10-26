using System.Collections.Generic;
using System.Linq;
using CrossCuttingConcerns.StrategyPattern;

namespace CrossCuttingConcerns
{
    public class CommonService
    {
        public List<IVatStrategy> Strategies { get; set; }

        public CommonService(List<IVatStrategy> strategies)
        {
            Strategies = strategies;
        }

        public int GetVatByCountryCode(string countryCode)
        {
            var strategy = Strategies.First(s => s.CountryCode == countryCode);
            return strategy.GetVat();
        }

        public double CalculateVat(string countryCode, double value)
        {
            var vat = GetVatByCountryCode(countryCode);
            var vatValue = vat / 100.0 * value;
            return vatValue;
        }

        public double CalculateTotalValue(string countryCode, double value)
        {
            var vatValue = CalculateVat(countryCode, value);
            return vatValue + value;
        }
    }
}
