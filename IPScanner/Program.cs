using System;
using System.Windows.Forms;

namespace IPScanner
{
    internal static class Program
    {
        public static Form1 window;

        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            window = new Form1();
            Application.Run(window);
        }
    }
}
