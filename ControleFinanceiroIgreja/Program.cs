using ControleFinanceiroIgreja.GUI;
using System;
using System.Windows.Forms;

namespace ControleFinanceiroIgreja
{
    static class Program
    {

        static public bool tablet = false;
        static public int heightGrid = 45;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {



            //tablet = true;

            if (!tablet)
                Application.EnableVisualStyles();


            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmHome());
        }
    }
}
