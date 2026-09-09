using Autodesk.AutoCAD.Runtime;
using Autodesk.AutoCAD.ApplicationServices;
using Autodesk.AutoCAD.EditorInput;

namespace InfraQTY.AutoCAD;

public class Commands
{
    [CommandMethod("INFRAQTY")]
    public void StartInfraQTY()
    {
        Document doc = Application.DocumentManager.MdiActiveDocument;
        Editor ed = doc.Editor;

        ed.WriteMessage("\nInfraQTY is running!");
    }
}