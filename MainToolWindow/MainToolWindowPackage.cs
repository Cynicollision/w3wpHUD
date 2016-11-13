using Microsoft.VisualStudio.Shell;
using System;
using System.Runtime.InteropServices;

namespace w3wpHUD
{
    [PackageRegistration(UseManagedResourcesOnly = true)]
    [InstalledProductRegistration("#110", "#112", "1.0", IconResourceID = 400)] // Info on this package for Help/About
    [ProvideMenuResource("Menus.ctmenu", 1)]
    [ProvideToolWindow(typeof(MainToolWindow))]
    [Guid(PackageGuidString)]
    public sealed class MainToolWindowPackage : Package
    {
        /// <summary>
        /// MainToolWindowPackage GUID string.
        /// </summary>
        public const string PackageGuidString = "afd931cf-9cf0-412d-8bb2-256af004f99f";

        protected override void Initialize()
        {
            MainToolWindowCommand.Initialize(this);
            base.Initialize();
        }
    }
}
