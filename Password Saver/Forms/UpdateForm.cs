using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Password_Saver.Forms
{
    public partial class UpdateForm : Form
    {

        public Credential credential;

        public UpdateForm(Credential credentialPassedIn, bool _isUpdate = false)
        {
            InitializeComponent();
            this.credential = credentialPassedIn;

            websiteUpdateTextBox.Text = credential.Website;
            updateUserNameTextBox.Text = credential.Username;
            updatePasswordTextBox.Text = credential.Password;
            updateNotesRichTextBox.Text = credential.Notes;
            if (_isUpdate == false)
            {
                updateSubmitButton.Visible = false;
            }         
        }

        private void updateSubmitButton_Click(object sender, EventArgs e)
        {
            credential.Website = websiteUpdateTextBox.Text;
            credential.Username = updateUserNameTextBox.Text;
            credential.Password = updatePasswordTextBox.Text;
            credential.Notes = updateNotesRichTextBox.Text;

            this.Close();
        }
    }
}
