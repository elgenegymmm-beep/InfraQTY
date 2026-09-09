namespace InfraQTY.Core.Models;

public class FittingItem
{
    public string Type { get; set; } = string.Empty;

    public double Diameter { get; set; }

    public int Quantity { get; set; }

    public string Unit { get; set; } = "pcs";

    public FittingItem()
    {
    }

    public FittingItem(
        string type,
        double diameter,
        int quantity)
    {
        Type = type;
        Diameter = diameter;
        Quantity = quantity;
    }
}