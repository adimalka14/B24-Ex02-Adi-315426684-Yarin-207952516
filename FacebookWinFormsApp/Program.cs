using System;
using System.Windows.Forms;
using CefSharp.WinForms;
using CefSharp;
using FacebookWrapper;

namespace BasicFacebookFeatures
{
    // $G$ THE-001 (-10) your grade on diagrams document - 90. please see comments inside the document. 40% of your grade).
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