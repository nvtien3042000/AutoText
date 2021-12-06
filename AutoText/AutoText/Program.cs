using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoText
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Thread thr = new Thread(() =>
            {
                Hook.HookKeyboard();

            }
            );
            thr.SetApartmentState(ApartmentState.STA);
            thr.IsBackground = true;
            thr.Start();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            Console.WriteLine("a");
        }
    }
}
