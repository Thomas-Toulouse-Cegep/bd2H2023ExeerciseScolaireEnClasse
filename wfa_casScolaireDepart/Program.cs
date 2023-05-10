using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dark.Net;

namespace wfa_casScolaireDepart
{
    internal static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        ///

        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            DarkNet.Instance.SetCurrentProcessTheme(Theme.Auto);

            Form mainForm = new menuForm();
            /* var settings = new UISettings();
             var foreground = settings.GetColorValue(UIColorType.Foreground);
             var background = settings.GetColorValue(UIColorType.Background);*/
            DarkNet.Instance.SetWindowThemeForms(mainForm, Theme.Dark);
            Application.Run(mainForm);
        }
    }
}