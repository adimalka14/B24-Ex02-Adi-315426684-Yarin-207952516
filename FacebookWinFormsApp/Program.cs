using System;
using System.Windows.Forms;
using BasicFacebookFeatures.View;
using CefSharp;
using CefSharp.WinForms;
using FacebookWrapper;

namespace BasicFacebookFeatures
{ 
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Clipboard.SetText("design.patterns20cc");
            FacebookService.s_UseForamttedToStrings = true;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            CefSettings settings = new CefSettings();
            Cef.Initialize(settings);
            Application.Run(new FormMain());
        }
    }
}
//dfdsfsdfs