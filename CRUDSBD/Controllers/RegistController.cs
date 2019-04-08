using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRUDSBD.Models;
using CRUDSBD.Views;

namespace CRUDSBD.Controllers {
    class RegistController {
        private RegistModel _model;
        private RegistView _view;
        public bool _flag;

        public RegistController(RegistModel model, RegistView view)
        {
            this._model = model;
            this._view = view;
        }

        public RegistController() { _flag = false; }

        public void CreateView()
        {
            _view.Show();
        }


        public void createViewLogin()
        {
            /*LoginModel _modelLogin = new LoginModel();
            LoginView _viewLogin = new LoginView();
            LoginController _ctrlLogin = new LoginController(_modelLogin,_viewLogin);
            _ctrlLogin.createViewLogin();*/
        }
    }
}
