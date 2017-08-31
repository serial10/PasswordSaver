using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Data.SqlClient;
using Dapper;


namespace Password_Saver.Forms
{
    public partial class MainPasswordForm : Form
    {
        public int User_Login_ID;
        private List<Credential> credentialDbList = new List<Credential>();
        private List<Credential> credentialAppList = new List<Credential>();

        private SQLiteConnection connection = new SQLiteConnection("Data Source=PasswordSaver.db");

        public MainPasswordForm(int user_login_id)
        {
            this.User_Login_ID = user_login_id;
            InitializeComponent();

            // Test_AddCredsToList();
            // Check to see if user is admin, if they are, show all added websites from all users
            if (User_Login_ID == 6)
            {
                credentialDbList.AddRange((List<Credential>)connection.Query<Credential>("SELECT * FROM Credentials WHERE IsDeleted = 0"));
            }
            // if not, pull only website associated with the ID
            else
            {
                credentialDbList.AddRange((List<Credential>)connection.Query<Credential>("SELECT * FROM Credentials WHERE IsDeleted = 0 and User_Login_ID = @User_Login_ID", new { User_Login_ID = this.User_Login_ID }));
            }
            RefreshCombobox();
        }
        //----------------Creates a test item for the combo box------------------------------------
        //private void Test_AddCredsToList()
        //{
        //    Credential cred = new Credential("google", "gadams", "1234", " I am a note.");
        //    credentialDbList.Add(cred);
        //}
        //------------------------------------------------------------------------------------------
        private void addButton_Click(object sender, EventArgs e)
        {
            //
            AddForm newAddForm = new AddForm(credentialAppList);
            newAddForm.ShowDialog();
            credentialAppList.ForEach(i => i.User_Login_ID = this.User_Login_ID);
            connection.Open();
            connection.Execute("INSERT INTO Credentials VALUES( null, @Website, @Username, @Password, @Notes, 0, @User_Login_ID)", credentialAppList);
            connection.Close();
            if (User_Login_ID == 6)
            {
                credentialDbList = (List<Credential>)connection.Query<Credential>("SELECT * FROM Credentials WHERE IsDeleted = 0");
            }
            else
            {
                credentialDbList = (List<Credential>)connection.Query<Credential>("SELECT * FROM Credentials WHERE IsDeleted = 0 and User_Login_ID = @User_Login_ID", new { User_Login_ID = this.User_Login_ID });
            }

            RefreshCombobox();
            credentialAppList.Clear();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            // Calls and returns DetSelectedCredential method and stores it into returnedCredential
            Credential returnedCredential = GetSelectedCredential();

            // Creates newUpdateForm and passes it returnedCredential and a true parameter
            UpdateForm newUpdateForm = new UpdateForm(returnedCredential, true);

            // Shows newUpdate in a ShowDialog window 
            newUpdateForm.ShowDialog();

            // Opens a connection to the database
            connection.Open();

            // Updates the database based on the data in returnedCredential
            connection.Execute("UPDATE Credentials SET Website = @Website, Username = @Username, Password = @Password, Notes = @Notes WHERE CredentialID = @CredentialID", returnedCredential);

            // Assigns the returnedCredential to the credentialDbList's combo box selected index
            credentialDbList[this.selectionComboBox.SelectedIndex] = returnedCredential;

            // Closes the database
            connection.Close();

            // Calls the RefreshCombobox method
            RefreshCombobox();


        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            // This calls the method GetSelectedCredential and stores the value in returnedCredential
            Credential returnedCredential = GetSelectedCredential();

            // Removes the returnCredential from the credentialDbList
            credentialDbList.Remove(returnedCredential);

            //Opens a connections to the DB
            connection.Open();

            // Executes an update query and sets the selected item to IsDeleted = 1
            connection.Execute("UPDATE Credentials SET IsDeleted = 1 WHERE CredentialID = @CredentialID", returnedCredential);

            // Pulls a fresh list to the credentialDBList based on the User that is logged in and if the record isn't deleted.
            credentialDbList = (List<Credential>)connection.Query<Credential>("SELECT * FROM Credentials WHERE IsDeleted = 0 and User_Login_ID = @User_Login_ID", new { User_Login_ID = this.User_Login_ID });

            // Closes connection
            connection.Close();
          
            // Calls the RefreshCombobox method
            RefreshCombobox();  
        }

        private void viewButton_Click(object sender, EventArgs e)
        {
            // Creates a newUpdateForm object and passes it the GetSelectedCredential method
            UpdateForm newUpdateForm = new UpdateForm(GetSelectedCredential());

            // Shows newUpdate in a ShowDialog window
            newUpdateForm.ShowDialog();
        }

        private void MainPasswordForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Exits the entire application
            Environment.Exit(0);
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {

        }

        private void RefreshCombobox()
        {
            // Sets the Data Source on the selection combo box to null(erases everything in the combo box)
            this.selectionComboBox.DataSource = null;

            // Populates combo box with items that are currently in the credentialDbList(comes from the database)
            this.selectionComboBox.DataSource = credentialDbList;

            //Tells the combo box to display the Website name from the database and uses its ValueMember(ID behind it).
            this.selectionComboBox.DisplayMember = "Website";
            this.selectionComboBox.ValueMember = "Website";

            // Calls the refresh method
            this.Refresh();

            // Checks to see if there is atleast 1 item in the combobox
            if (this.selectionComboBox.SelectedIndex >= 1)
            {
                // Selects the first item in the combo box
                this.selectionComboBox.SelectedIndex = 0;
            }

        }

        private Credential GetSelectedCredential()
        {
            // Converts the Selected value to a string and stores it in selectedValue
            string selectedValue = this.selectionComboBox.SelectedValue.ToString();

            // Creates credFromComboBox object
            Credential credFromComboBox = new Credential();

            // Looks up the selectedValue in the database and stores it into credFromComboBox
            credFromComboBox = (Credential)connection.QueryFirst<Credential>("SELECT * FROM Credentials where Website = @Website", new { Website = selectedValue });
            
            return credFromComboBox;
        }
    }
}
