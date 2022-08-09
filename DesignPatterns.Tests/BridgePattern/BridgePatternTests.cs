namespace DesignPatterns.Tests.BridgePattern;

public class BridgePatternTests
{
    [Fact]
    public void Menu_ShouldReturnPriceAfterTax_WithDifferentTaxes()
    {
        float totalPrice = 1000;
        float taleAwayExpected = 930;
        float diningInExpected = 810;

        TakeAwayVatTax takeAwayVatTax = new TakeAwayVatTax();
        DiningInVatTax diningInVatTax = new DiningInVatTax();

        MeatBasedMenu meatBasedMenu = new MeatBasedMenu(takeAwayVatTax);
        Assert.Equal(taleAwayExpected, meatBasedMenu.CalculatePrice(totalPrice));

        meatBasedMenu = new MeatBasedMenu(diningInVatTax);
        Assert.Equal(diningInExpected, meatBasedMenu.CalculatePrice(totalPrice));

        VegetarianMenu vegetarianMenu = new VegetarianMenu(takeAwayVatTax);
        Assert.Equal(taleAwayExpected, vegetarianMenu.CalculatePrice(totalPrice));

        vegetarianMenu = new VegetarianMenu(diningInVatTax);
        Assert.Equal(diningInExpected, vegetarianMenu.CalculatePrice(totalPrice));
    }
}