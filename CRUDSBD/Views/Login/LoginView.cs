using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CRUDSBD.Views.Login;
using CRUDSBD.Controllers;

namespace CRUDSBD.Views {
    public partial class LoginView : Form {
        private LoginController _ctrl;

        public LoginView()
        {
            InitializeComponent();
            
        }
        private void panel3_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void label3_Click(object sender, EventArgs e)
        {
            if (!mainpanel.Controls.Contains(UserControlSignUp.instance))
            {
                mainpanel.Controls.Add(UserControlSignUp.instance);
                UserControlSignUp.instance.Dock = DockStyle.Fill;
                UserControlSignUp.instance.BringToFront();
                
            }
            else
            {
                UserControlSignUp.instance.BringToFront();
            }
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void CloseApp()
        {
            _ctrl = new LoginController();
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

            if (!mainpanel.Controls.Contains(UserControlSignIn.instance))
            {
                mainpanel.Controls.Add(UserControlSignIn.instance);
                UserControlSignIn.instance.Dock = DockStyle.Fill;
                UserControlSignIn.instance.BringToFront();
            }
            else
            {
                UserControlSignIn.instance.BringToFront();
            }

            CloseApp();

        }



    }
}
