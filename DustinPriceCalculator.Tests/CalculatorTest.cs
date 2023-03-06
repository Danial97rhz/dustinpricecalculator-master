using System;
using Xunit;

namespace DustinPriceCalculator.Tests;


public class CalculatorTest
{
    private const int NORMAL_USER = 0;
    private const int COMPANY_USER = 1;
    private const int INSURANCE = 0;
    private const int HARDWARE = 1;

    [Theory]
    [InlineData(NORMAL_USER, INSURANCE, 100, "2099-03-01", 115)]
    [InlineData(COMPANY_USER, INSURANCE, 100, "2099-03-01", 110)]
    [InlineData(NORMAL_USER, HARDWARE, 100, "2099-03-01", 125)]
    [InlineData(COMPANY_USER, HARDWARE, 100, "2099-03-01", 120)]
    [InlineData(NORMAL_USER, INSURANCE, 100, "2022-01-01", 125)]
    [InlineData(COMPANY_USER, INSURANCE, 100, "2022-01-01", 120)]
    [InlineData(NORMAL_USER, HARDWARE, 100, "2022-01-01", 135)]
    [InlineData(COMPANY_USER, HARDWARE, 100, "2022-01-01", 130)]
    public void CalculatePrice(int userType, int productType, int costPrice, string campaignEndDate, int expectedPrice)
    {
        DateTime endDate = DateTime.Parse(campaignEndDate);
        int caculatedPrice = PriceCalculator.CalculatePrice(userType, productType, costPrice, endDate);
        Assert.Equal(expectedPrice, caculatedPrice);
    }

    //TODO: Add test for invalid product & user type
}
