namespace DesignPatterns.Laboratory.BridgePattern;

public abstract class Menu
{
    protected readonly IVatTax VatTax;

    protected Menu(IVatTax vatTax)
    {
        VatTax = vatTax;
    }

    public abstract float CalculatePrice(float totalPrice);
}

public class MeatBasedMenu : Menu
{
    public MeatBasedMenu(IVatTax vatTax) : base(vatTax)
    {
    }

    public override float CalculatePrice(float totalPrice)
    {
        return totalPrice - totalPrice * VatTax.TaxPercentage / 100;
    }
}

public class VegetarianMenu : Menu
{
    public VegetarianMenu(IVatTax vatTax) : base(vatTax)
    {
    }

    public override float CalculatePrice(float totalPrice)
    {
        return totalPrice - totalPrice * VatTax.TaxPercentage / 100;
    }
}

