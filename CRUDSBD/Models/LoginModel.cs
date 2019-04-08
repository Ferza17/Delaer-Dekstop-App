namespace CRUDSBD.Models {
    class LoginModel {
        private string _username;
        private string _password;
        private bool _flag;

        public string username
        {
            get { return this._username; }
            set { this._username = value; }
        }

        public string password
        {
            get { return this._password; }
            set { this._password = value; }
        }

        public bool flag
        {
            get { return this._flag; }
            set { this._flag = value; }
        }
    }
}
