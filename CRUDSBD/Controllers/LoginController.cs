using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;


using CRUDSBD.Models;
using CRUDSBD.Views;

namespace CRUDSBD.Controllers {
    class LoginController {
        private LoginModel _model;
        private LoginView _view;
        public bool _flag;
        

        public LoginController() { _flag = false; }
        

        public void createViewLogin()
        {
            _view.Show();
            
        }

        public void closeViewLogin()
        {
            
            _view.Close();
        }

        public void createViewHome()
        {
            _view = new LoginView();
            Models.MainMenu _modelHome = new Models.MainMenu();
            Views.MainMenu _viewMenu = new Views.MainMenu();
            MainMenuController _ctrlMenu = new MainMenuController(_modelHome, _viewMenu);
            _flag = true;
            _ctrlMenu.createViewMenu();
        }

        public void createViewRegist()
        {
            _view = new LoginView();
            RegistView _viewRegist = new RegistView();
            RegistModel _modelRegist = new RegistModel();
            RegistController _ctrlRegist = new RegistController(_modelRegist, _viewRegist);
            _ctrlRegist.CreateView();
            _flag = true;
        }


    }

        
        
        
    
}
