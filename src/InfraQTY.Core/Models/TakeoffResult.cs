namespace InfraQTY.Core.Models;

public class TakeoffResult
{
    public List<PipeItem> Pipes { get; set; } = new();

    public List<FittingItem> Fittings { get; set; } = new();

    public double TotalPipeLength { get; set; }

    public double TotalFittings { get; set; }
}