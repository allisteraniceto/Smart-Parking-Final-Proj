using System;
using System.Windows.Forms;
using System.IO; //for StreamReader

namespace SmartParking
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        //public Login(string username, string password) //overloaded default constructor
        //{
        //    InitializeComponent();
        //    this.username = username;
        //    this.password = password;
        //}


        private void getCredentials(Admin admin_user) //PATH: "C:\Users\allister18\OneDrive - Columbia Basin College\Documents\CPTS322\Smart-Parking-Final-Proj\SP\SmartParking\user.txt"
        { //use: \ for escape char
            //string path = "C:\\Users\\allister18\\OneDrive - Columbia Basin College\\Documents\\CPTS322\\Smart-Parking-Final-Proj\\SP\\SmartParking\\user.txt";
            string path = "C:\\Users\\lez18\\OneDrive\\Documents\\CPTS322\\Smart-Parking-Final-Proj\\SP\\SmartParking\\user.txt";
            //string currentDirectory = Environment.CurrentDirectory;
            //string filePath = Path.Combine(currentDirectory, "user.txt");

            try
            {
                //create new StreamReader instance
                using (StreamReader reader = new StreamReader(path)) //using: ensures object is disposed of when the block is exited
                {
                    string line1, line2;
                    while((line1 = reader.ReadLine()) != null && (line2 = reader.ReadLine()) != null) //read 2 lines at a time
                    {
                        admin_user.username = line1;
                        admin_user.password = line2;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("An error occurred while reading the file: " + e.Message);
            }
        }

        private void loginBtn_Click_1(object sender, EventArgs e)
        {
            Admin user = new Admin();
            //read fron a file the username and passwor
            //loaddata(user);
            //set values of username and password to user object here

            getCredentials(user); //get username and password from text file

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
