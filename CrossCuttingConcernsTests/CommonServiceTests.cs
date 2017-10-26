using System.Collections.Generic;
using CrossCuttingConcerns;
using CrossCuttingConcerns.StrategyPattern;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CrossCuttingConcernsTests
{
    [TestClass]
    public class CommonServiceTests
    {
        [TestMethod]
        public void Giving_FranceCode_When_GetVatByCountryCodeIsCalled_Then_Should_Return_20()
        {
            //Arrange
            var service = CreateSUT();

            //Act
            var vat = service.GetVatByCountryCode("FR");

            //Assert
            vat.Should().Be(20);
        }

        [TestMethod]
        public void Giving_RomanianCode_When_GetVatByCountryCodeIsCalled_Then_Should_Return_19()
        {
            //Arrange
            var service = CreateSUT();

            //Act
            var vat = service.GetVatByCountryCode("RO");

            //Assert
            vat.Should().Be(19);
        }

        [TestMethod]
        public void Giving_UKCode_When_GetVatByCountryCodeIsCalled_Then_Should_Return_20()
        {
            //Arrange
            var service = CreateSUT();

            //Act
            var vat = service.GetVatByCountryCode("UK");

            //Assert
            vat.Should().Be(20);
        }

        [TestMethod]
        public void Giving_RussianCode_When_GetVatByCountryCodeIsCalled_Then_Should_Return_18()
        {
            //Arrange
            var service = CreateSUT();

            //Act
            var vat = service.GetVatByCountryCode("RU");

            //Assert
            vat.Should().Be(18);
        }

        [TestMethod]
        public void Giving_PolandCode_When_GetVatByCountryCodeIsCalled_Then_Should_Return_23()
        {
            //Arrange
            var service = CreateSUT();

            //Act
            var vat = service.GetVatByCountryCode("PL");

            //Assert
            vat.Should().Be(23);
        }

        [TestMethod]
        public void Giving_FranceCode_When_CalculateVatIsCalled_WithValue1500_Then_Should_Return_300()
        {
            //Arrange
            var service = CreateSUT();

            //Act
            var vat = service.CalculateVat("FR", 1500);

            //Assert
            vat.Should().Be(300);
        }

        [TestMethod]
        public void Giving_RomanianCode_When_CalculateVatIsCalled_WithValue1500_Then_Should_Return_285()
        {
            //Arrange
            var service = CreateSUT();

            //Act
            var vat = service.CalculateVat("RO", 1500);

            //Assert
            vat.Should().Be(285);
        }

        [TestMethod]
        public void Giving_UKCode_When_CalculateVatIsCalled_WithValue3000_Then_Should_Return_600()
        {
            //Arrange
            var service = CreateSUT();

            //Act
            var vat = service.CalculateVat("UK", 3000);

            //Assert
            vat.Should().Be(600);
        }

        [TestMethod]
        public void Giving_RussianCode_When_CalculateVatIsCalled_WithValue3000_Then_Should_Return_540()
        {
            //Arrange
            var service = CreateSUT();

            //Act
            var vat = service.CalculateVat("RU", 3000);

            //Assert
            vat.Should().Be(540);
        }

        [TestMethod]
        public void Giving_PolandCode_When_CalculateVatIsCalled_WithValue3000_Then_Should_Return_690()
        {
            //Arrange
            var service = CreateSUT();

            //Act
            var vat = service.CalculateVat("PL", 3000);

            //Assert
            vat.Should().Be(690);
        }

        [TestMethod]
        public void Giving_FranceCode_When_CalculateTotalValueIsCalled_WithValue1500_Then_Should_Return_1800()
        {
            //Arrange
            var service = CreateSUT();

            //Act
            var vat = service.CalculateTotalValue("FR", 1500);

            //Assert
            vat.Should().Be(1800);
        }

        [TestMethod]
        public void Giving_RomanianCode_When_CalculateTotalValueIsCalled_WithValue1500_Then_Should_Return_1785()
        {
            //Arrange
            var service = CreateSUT();

            //Act
            var vat = service.CalculateTotalValue("RO", 1500);

            //Assert
            vat.Should().Be(1785);
        }

        [TestMethod]
        public void Giving_UKCode_When_CalculateTotalValueIsCalled_WithValue3000_Then_Should_Return_3600()
        {
            //Arrange
            var service = CreateSUT();

            //Act
            var vat = service.CalculateTotalValue("UK", 3000);

            //Assert
            vat.Should().Be(3600);
        }

        [TestMethod]
        public void Giving_RussianCode_When_CalculateTotalValueIsCalled_WithValue3000_Then_Should_Return_3540()
        {
            //Arrange
            var service = CreateSUT();

            //Act
            var vat = service.CalculateTotalValue("RU", 3000);

            //Assert
            vat.Should().Be(3540);
        }

        [TestMethod]
        public void Giving_PolandCode_When_CalculateTotalValueIsCalled_WithValue3000_Then_Should_Return_3690()
        {
            //Arrange
            var service = CreateSUT();

            //Act
            var vat = service.CalculateTotalValue("PL", 3000);

            //Assert
            vat.Should().Be(3690);
        }

        private CommonService CreateSUT()
        {
            List<IVatStrategy> strategies = new List<IVatStrategy>()
            {
                new FranceVatStrategy(),
                new RomanianVatStrategy(),
                new PolandVatStrategy(),
                new RussianVatStrategy(),
                new UnitedKingdomVatStrategy()
            };
            return new CommonService(strategies);
        }
    }
}
