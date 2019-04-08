using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using CRUDSBD.Models;
using CRUDSBD.Views;
using CRUDSBD.Controllers;


namespace CRUDSBD {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {


            LoginModel _model = new LoginModel();
            LoginView _view = new LoginView();
            LoginController _ctrl = new LoginController();
            Application.EnableVisualStyles();
            Application.Run(_view);

            

        }
    }
}
