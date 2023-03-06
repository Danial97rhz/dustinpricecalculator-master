namespace DustinPriceCalculator.Calculators;
public class Calculator : ICalculator
{
    //Constants
    private const int COMPANY_DISCOUNT = 5;
    private const int CAMPAIGN_DISCOUNT = 10;
    private const int INSURANCE_MARGIN = 25;
    private const int HARDWARE_MARGIN = 35;

    public int PriceCalculator(int userType, int productType, int costPrice, DateTime campaignEndDate) =>
    costPrice + CalculateMargin(productType) - CalculateDiscount(userType, campaignEndDate);
    
    int CalculateMargin(int productType) => productType == 0 ? INSURANCE_MARGIN : HARDWARE_MARGIN;

    int CalculateDiscount(int userType, DateTime campaignEndDate)
    {
        int campaignDiscount = campaignEndDate > DateTime.Today ? CAMPAIGN_DISCOUNT : 0;
        int companyDiscount = userType == 1 ? COMPANY_DISCOUNT : 0;

        return campaignDiscount + companyDiscount;
    }
}
