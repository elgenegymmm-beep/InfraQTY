using InfraQTY.Core.Models;

namespace InfraQTY.Core.Services;

public class PipeCalculator
{
    public double CalculateTotalLength(IEnumerable<PipeItem> pipes)
    {
        return pipes.Sum(pipe => pipe.Length);
    }

    public double CalculateLengthByDiameter(
        IEnumerable<PipeItem> pipes,
        double diameter)
    {
        return pipes
            .Where(pipe => pipe.Diameter == diameter)
            .Sum(pipe => pipe.Length);
    }
}