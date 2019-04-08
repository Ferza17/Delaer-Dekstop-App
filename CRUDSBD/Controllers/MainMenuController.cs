using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using CRUDSBD.Models;
using CRUDSBD.Views;
using CRUDSBD.Controllers;

namespace CRUDSBD.Controllers {
    class MainMenuController {
        private Models.MainMenu _model;
        private Views.MainMenu _view;

        public MainMenuController(Models.MainMenu model, Views.MainMenu view)
        {
            this._model = model;
            this._view = view;
            createViewMenu();
        }

        public void createViewMenu()
        {
            _view.Show();
        }
    }

    
}
