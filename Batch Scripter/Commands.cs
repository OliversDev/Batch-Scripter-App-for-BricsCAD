﻿using Bricscad.ApplicationServices;
using Bricscad.Runtime;
using Teigha.Runtime;

namespace BatchScripter
{
    public class BatchScripterDialog
    {
        [CommandMethod("OW:BatchScripter")]
        public void BatchScripter()
        {
            MainForm form = new MainForm();
            Application.ShowModalDialog(form);
        }
    }
}
