using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUDSBD.Views.Login {
    public partial class UserControlSignUp : UserControl {

        private static UserControlSignUp _instance;

        public static UserControlSignUp instance
        {
            get
            {
                if(_instance == null)
                {
                    _instance = new UserControlSignUp();
                }
                return _instance;
            }
        }

        public UserControlSignUp()
        {
            InitializeComponent();
        }
    }
}
