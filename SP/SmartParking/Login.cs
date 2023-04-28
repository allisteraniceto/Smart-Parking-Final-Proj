using System;
using System.Windows.Forms;
using System.IO; //for StreamReader

namespace SmartParking
{
    public partial class Login : Form
    {
        string path = "";

        public Login()
        {
            InitializeComponent();
            Console.WriteLine($"{Environment.CurrentDirectory}"); //current working directory inside SmartParking\bin\Debug
            path = Path.Combine(Environment.CurrentDirectory, "user.txt");
        }

        private void getWorkingDirectory()
        {
            //currently at SmartParking\bin\Debug, go up 2 directories to get to SmartParking
            string currentDirectory = Environment.CurrentDirectory;
        }

        private void getCredentials(Admin admin_user) //PATH: "C:\Users\allister18\OneDrive - Columbia Basin College\Documents\CPTS322\Smart-Parking-Final-Proj\SP\SmartParking\user.txt"
        { //use: \ for escape char
            //path = "C:\\Users\\allister18\\OneDrive - Columbia Basin College\\Documents\\CPTS322\\Smart-Parking-Final-Proj\\SP\\SmartParking\\user.txt";
            //path = "C:\\Users\\lez18\\OneDrive\\Documents\\CPTS322\\Smart-Parking-Final-Proj\\SP\\SmartParking\\user.txt";

            try
            {
                if (!File.Exists(path)) //if file does not exist, create a new file
                {
                    
                    using (StreamWriter writer = new StreamWriter(path))
                    {
                        writer.WriteLine("new");
                        writer.WriteLine("new");
                    }
                    label.Text = "new user: enter 'user' for password and username";
                    return;
                }


                if (usernameBox.Text == "" || passwordBox.Text == "") //if either field is empty, fail login
                {
                    label.Text = "Please enter username AND password";
                    return;
                }

                //create new StreamReader instance
                using (StreamReader reader = new StreamReader(path)) //using: ensures object is disposed of when the block is exited
                {
                    string line1, line2;
                    while ((line1 = reader.ReadLine()) != null && (line2 = reader.ReadLine()) != null) //read 2 lines at a time
                    {
                        if (line1 == usernameBox.Text && line2 == passwordBox.Text) //if user input matches admin
                        {
                            admin_user.username = line1;
                            admin_user.password = line2;
                        }
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
