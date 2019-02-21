using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ascored
{
    //Это точка входа в программу.
    //Отсюда запускаешь первую форму



    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new MainForm());

            //Application.Run(new ManageOrderForm());
            Application.Run(new OrderForm());
        }
    }
}
