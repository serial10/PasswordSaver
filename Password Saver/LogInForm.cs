using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Password_Saver.Forms;
using Dapper;
using System.Data.SQLite;

namespace Password_Saver
{
    public partial class LogInForm : Form
    {
        
        // Create a MasterLogin List Object
        private List<MasterLogin> masterLoginList = new List<MasterLogin>();

        // Create a connection to the SQL DB
        private SQLiteConnection connection = new SQLiteConnection("Data Source=PasswordSaver.db");

        public LogInForm()
        {
            InitializeComponent();
            

        }

        private void logInButton_Click(object sender, EventArgs e)
        {
            
            // Create a newQuery Object to store the data from the Username and Password text boxes
            MasterLogin newQuery = new MasterLogin();

            newQuery.Username = userNameTextBox.Text;
            newQuery.Password = passwordTextBox.Text;

            // Starting the try/catch method
            try
            {
                // takes newQuery and checks the DB to see if there is a match. If there is a match, open MainPasswordForm
                int user_login_id = connection.QueryFirst<int>("SELECT User_Login_ID FROM User_Login where Username = @Username AND Password = @Password", newQuery);
                
                    MainPasswordForm newForm = new MainPasswordForm(user_login_id);
                    newForm.Show();
                    this.Hide();   
            }
            catch (Exception)
            {
                // If no match is found, show this message box.
                MessageBox.Show("The username and password combination is wrong!");
            }
        }

        private void createLoginButton_Click(object sender, EventArgs e)
        {
            // Creat newLoginForm Object and pass in the masterLoginList Object
            CreateLoginForm newLoginForm = new CreateLoginForm(masterLoginList);
            newLoginForm.ShowDialog();

        }
    }
}
