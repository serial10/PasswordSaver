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
    public partial class AddForm : Form
    {
       public List<Credential> credentialList;

        public AddForm(List<Credential> credentialListPassedIn)
        {
            InitializeComponent();
            this.credentialList = credentialListPassedIn;
        }

        private void addSubmitButton_Click(object sender, EventArgs e)
        {
            Credential newCredential = new Credential();

            newCredential.Website = websiteAddTextBox.Text;
            newCredential.Username = userAddNameTextBox.Text;
            newCredential.Password = passwordAddTextBox.Text;
            newCredential.Notes = notesAddRichTextBox.Text;

            credentialList.Add(newCredential);

            websiteAddTextBox.Text = "";
            userAddNameTextBox.Text = "";
            passwordAddTextBox.Text = "";
            notesAddRichTextBox.Text = "";
        }         
    }
}
