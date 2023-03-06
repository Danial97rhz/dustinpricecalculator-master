namespace DustinPriceCalculator.Calculators;
public interface ICalculator
{
    int PriceCalculator(int userType, int productType, int costPrice, DateTime campaignEndDate);
}
