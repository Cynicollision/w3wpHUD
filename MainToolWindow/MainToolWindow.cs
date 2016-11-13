namespace w3wpHUD
{
    using System;
    using System.Runtime.InteropServices;
    using Microsoft.VisualStudio.Shell;

    [Guid("5c49eadc-f670-4d5e-9e16-65ca16f60efb")]
    public class MainToolWindow : ToolWindowPane
    {
        public MainToolWindow() : base(null)
        {
            MainToolWindowControl toolWindow = new MainToolWindowControl();

            this.Caption = "w3wp HUD";
            this.Content = toolWindow;

            string wpStatus = AppCommand.GetWorkerProcessesList();
            toolWindow.SetStatus(wpStatus);
        }
    }
}
