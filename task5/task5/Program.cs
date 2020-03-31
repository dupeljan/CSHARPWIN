using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task5
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            int TASK_NUM = 8;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if ( TASK_NUM == 1)
                Application.Run(new Form1());
            else if ( TASK_NUM == 2 || TASK_NUM == 4 )
                Application.Run(new Form2_4());
            else if ( TASK_NUM == 3 )
                Application.Run(new Form3());
            else if ( TASK_NUM == 5 || TASK_NUM == 6 || TASK_NUM == 7)
                Application.Run(new Form5_6_7());
            if ( TASK_NUM == 8 )
                Application.Run(new Form8());

        }
    }
}
