// See https://aka.ms/new-console-template for more information
using DustinPriceCalculator.Calculators;

Console.WriteLine("Hello, World!");
var price = 0;

try
{
    price = PriceCalculator.CalculatePrice(1, 0, 100, DateTime.Today);

}
catch (Exception exception)
{
    Console.WriteLine(exception.Message);
    throw;
}

System.Console.WriteLine(price.ToString());
Console.ReadKey();

public static class PriceCalculator
{
    /// <summary>
    ///   This function handles all calculation you ever need!
    /// </summary>
    /// <param name="userType"> 0 = Normal, 1 = Company</param>
    /// <param name="productType"> 0 = Insurance, 1 = Hardware</param>
    /// <param name="costPrice">product cost price</param>
    /// <param name="campaignEndDate">campaign end date</param>
    /// <returns></returns>
    public static int CalculatePrice(int userType, int productType, int costPrice, DateTime campaignEndDate)
    {
        ICalculator calculator = new Calculator();
        
        if (userType != 0 && userType != 1) throw new ArgumentException("Invalid user type");
        if (productType != 0 && productType != 1) throw new ArgumentException("Invalid product type");

        return calculator.PriceCalculator(userType, productType, costPrice, campaignEndDate);
    }
}