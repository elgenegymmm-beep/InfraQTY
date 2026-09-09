namespace InfraQTY.Core.Models;

public class PipeItem
{
    public string Material { get; set; } = string.Empty;

    public double Diameter { get; set; }

    public double Length { get; set; }

    public int ObjectCount { get; set; }

    public string Unit { get; set; } = "m";

    public PipeItem()
    {
    }

    public PipeItem(
        string material,
        double diameter,
        double length,
        int objectCount)
    {
        Material = material;
        Diameter = diameter;
        Length = length;
        ObjectCount = objectCount;
    }
}