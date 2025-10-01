using System;
using System.Windows.Forms;

namespace BooKKer
{
    internal static class Program
    {
        public static BookManager BookManager = new BookManager();

        [STAThread]
        static void Main()
        {
            

            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());
        }
    }
}
