using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task6
{
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
            Form f;
            const int TASK_NUM = 5;
            if (TASK_NUM == 1)
                f = new Form1();
            else if (TASK_NUM == 2)
                f = new Form2();
            else if (TASK_NUM == 3)
                f = new Form3();
            else if (TASK_NUM == 4)
                f = new Form4();
            else if (TASK_NUM == 5)
                f = new Form5();
            Application.Run(f);
        }
    }
}
