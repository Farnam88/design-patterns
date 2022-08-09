namespace DesignPatterns.Laboratory.BridgePattern;

public interface IVatTax
{
    float TaxPercentage { get; }
}

public class DiningInVatTax : IVatTax
{
    public DiningInVatTax()
    {
        TaxPercentage = 19;
    }

    public float TaxPercentage { get; }
}

public class TakeAwayVatTax : IVatTax
{
    public TakeAwayVatTax()
    {
        TaxPercentage = 7;
    }

    public float TaxPercentage { get; }
}