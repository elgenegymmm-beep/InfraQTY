using Autodesk.AutoCAD.Runtime;
using Autodesk.AutoCAD.ApplicationServices;
using Autodesk.AutoCAD.EditorInput;
using InfraQTY.Core.Models;

namespace InfraQTY.AutoCAD;

public class Commands
{
    [CommandMethod("INFRAQTY")]
    public void StartInfraQTY()
    {
        Document doc = Application.DocumentManager.MdiActiveDocument;
        Editor ed = doc.Editor;

        PipeItem testPipe = new PipeItem(
            "PVC",
            0.30,
            100,
            1);

        ed.WriteMessage(
            $"\nInfraQTY is running!" +
            $"\nMaterial: {testPipe.Material}" +
            $"\nDiameter: {testPipe.Diameter}" +
            $"\nLength: {testPipe.Length} m");
    }
}