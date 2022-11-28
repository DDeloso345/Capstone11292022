using System;
using System.Windows.Forms;

namespace Capstone
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Admin_LibrarianUI());
            Application.Run(new LogInForm());
            //Application.Run(new Admin_BookInventory());
            //Application.Run(new Admin_BookBorrowing());
            //Application.Run(new Admin_Member_Account_Management());

        }
    }
}
