using System;
using System.Windows.Forms;

namespace CoordinatesXY
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();  
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}