using System;
using System.Windows.Forms;
using DogWalkingManager.Forms;

namespace DogWalkingManager
{
    /// <summary>
    /// The main entry point for the DogWalkingManager application.
    /// </summary>
    internal static class Program
    {
        /// <summary>
        /// Main method to start the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
        }
    }
}
