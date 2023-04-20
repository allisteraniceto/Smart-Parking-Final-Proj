using System;
using System.Windows.Forms;

namespace TeamVaxxers
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

      


        private void loginBtn_Click_1(object sender, EventArgs e)
        {
            Admin user = new Admin(); //enter username here
            //read fron a file the username and passwor
            //loaddata(user);
            //set values of username and password to user object here

            if (user.username == usernameBox.Text && user.password == passwordBox.Text)
            {
                this.Hide();
                ParkingLot engine = new ParkingLot();
                engine.ShowDialog();
                this.Close();

            }
            else
            {
                label.Text = "Wrong Username or Password";
                usernameBox.Text = passwordBox.Text = "";
            }
        }


        private void passwordBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void usernameBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
