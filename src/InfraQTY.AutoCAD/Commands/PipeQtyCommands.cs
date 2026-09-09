using Autodesk.AutoCAD.Runtime;
using Autodesk.AutoCAD.ApplicationServices;
using Autodesk.AutoCAD.EditorInput;
using InfraQTY.Core.Models;
using InfraQTY.Core.Services;

namespace InfraQTY.AutoCAD.Commands;

public class PipeQtyCommands
{
    [CommandMethod("PIPEQTY")]
    public void CalculatePipeQuantity()
    {
        Document doc = Application.DocumentManager.MdiActiveDocument;
        Editor ed = doc.Editor;

        List<PipeItem> pipes = new List<PipeItem>
        {
            new PipeItem("PVC", 0.30, 100, 1),
            new PipeItem("PVC", 0.30, 50, 1),
            new PipeItem("HDPE", 0.50, 75, 1)
        };

        PipeCalculator calculator = new PipeCalculator();

        double totalLength = calculator.CalculateTotalLength(pipes);
        double pvcLength = calculator.CalculateLengthByDiameter(pipes, 0.30);

        ed.WriteMessage(
            "\n------------------------" +
            "\n     InfraQTY Results" +
            "\n------------------------" +
            $"\nTotal Pipe Length: {totalLength} m" +
            $"\nPVC 300mm Length: {pvcLength} m"
        );
    }
}