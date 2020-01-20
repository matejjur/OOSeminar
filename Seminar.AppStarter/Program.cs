using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Seminar.PresentationLayer;
using Seminar.Controllers;

namespace Seminar.AppStarter
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            WindowFormsFactory formsFactory = new WindowFormsFactory();
            MainFormController mainController = new MainFormController(formsFactory, null);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Seminar.PresentationLayer.LoginForm(mainController));
        }
    }
}
