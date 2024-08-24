using Bricscad.ApplicationServices;
using Bricscad.Runtime;
using Teigha.Runtime;

namespace BricsCADDialogLibrary
{
    public class BricsCADDialog
    {
        [CommandMethod("OW:BatchScripter")]
        public void BatchScripter()
        {
            MainForm form = new MainForm();
            Application.ShowModalDialog(form);
        }
    }
}
