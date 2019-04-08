using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CRUDSBD.Models;
using CRUDSBD.Controllers;

namespace CRUDSBD.Views {
    public partial class RegistView : Form {
        private RegistModel _model;
        private RegistController _ctrl;
        public RegistView()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _ctrl = new RegistController();
            
            if(textBox1.Text.ToString() == "")
            {
                MessageBox.Show("Komputer anda akan meledak !!!!");
            }else if (textBox2.Text.ToString() == "")
            {
                MessageBox.Show("Komputer anda akan meledak !!!!");
            }
            else
            {
                _ctrl._flag = true;
                var state = _ctrl;
                this.Hide();
                _ctrl.createViewLogin();
            }
            
            
            


        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            
        }

        

        
    }
}
