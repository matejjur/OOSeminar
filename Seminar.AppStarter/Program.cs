using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Seminar.PresentationLayer;
using Seminar.Controllers;
using Seminar.MemoryBasedDAL;

namespace Seminar.AppStarter
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            WindowFormsFactory formsFactory = new WindowFormsFactory();
            MainFormController mainController = new MainFormController(formsFactory, UserRepository.getInstance(), RecordRepository.getInstance(), CurrentUserRepository.getInstance());


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new RegistrationForm(mainController));
        }
    }
}
