using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CRUDSBD.Models;
using CRUDSBD.Controllers;

namespace CRUDSBD.Views.Login {
    public partial class UserControlSignIn : UserControl {
        private static UserControlSignIn _instance;
        private LoginModel _model;

        public static UserControlSignIn instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new UserControlSignIn();
                }
                return _instance;
            }
        }


        public UserControlSignIn()
        {
            InitializeComponent();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            
            _model = new LoginModel();
            _model.username = textBox2.Text.ToString();
            _model.password = textBox5.Text.ToString();
            

        }

        public void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        public void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
