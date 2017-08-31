namespace Password_Saver.Forms
{
    partial class UpdateForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.updateSubmitButton = new System.Windows.Forms.Button();
            this.updateNotesRichTextBox = new System.Windows.Forms.RichTextBox();
            this.updatePasswordTextBox = new System.Windows.Forms.TextBox();
            this.updateUserNameTextBox = new System.Windows.Forms.TextBox();
            this.notesLbl = new System.Windows.Forms.Label();
            this.passwordLbl = new System.Windows.Forms.Label();
            this.usernameLbl = new System.Windows.Forms.Label();
            this.websiteUpdateTextBox = new System.Windows.Forms.TextBox();
            this.websiteUpdateLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // updateSubmitButton
            // 
            this.updateSubmitButton.Location = new System.Drawing.Point(136, 189);
            this.updateSubmitButton.Name = "updateSubmitButton";
            this.updateSubmitButton.Size = new System.Drawing.Size(75, 23);
            this.updateSubmitButton.TabIndex = 13;
            this.updateSubmitButton.Text = "Submit";
            this.updateSubmitButton.UseVisualStyleBackColor = true;
            this.updateSubmitButton.Click += new System.EventHandler(this.updateSubmitButton_Click);
            // 
            // updateNotesRichTextBox
            // 
            this.updateNotesRichTextBox.Location = new System.Drawing.Point(136, 87);
            this.updateNotesRichTextBox.Name = "updateNotesRichTextBox";
            this.updateNotesRichTextBox.Size = new System.Drawing.Size(202, 96);
            this.updateNotesRichTextBox.TabIndex = 12;
            this.updateNotesRichTextBox.Text = "";
            // 
            // updatePasswordTextBox
            // 
            this.updatePasswordTextBox.Location = new System.Drawing.Point(136, 61);
            this.updatePasswordTextBox.Name = "updatePasswordTextBox";
            this.updatePasswordTextBox.Size = new System.Drawing.Size(100, 20);
            this.updatePasswordTextBox.TabIndex = 11;
            // 
            // updateUserNameTextBox
            // 
            this.updateUserNameTextBox.Location = new System.Drawing.Point(136, 35);
            this.updateUserNameTextBox.Name = "updateUserNameTextBox";
            this.updateUserNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.updateUserNameTextBox.TabIndex = 10;
            // 
            // notesLbl
            // 
            this.notesLbl.AutoSize = true;
            this.notesLbl.Location = new System.Drawing.Point(72, 131);
            this.notesLbl.Name = "notesLbl";
            this.notesLbl.Size = new System.Drawing.Size(38, 13);
            this.notesLbl.TabIndex = 9;
            this.notesLbl.Text = "Notes:";
            // 
            // passwordLbl
            // 
            this.passwordLbl.AutoSize = true;
            this.passwordLbl.Location = new System.Drawing.Point(72, 57);
            this.passwordLbl.Name = "passwordLbl";
            this.passwordLbl.Size = new System.Drawing.Size(56, 13);
            this.passwordLbl.TabIndex = 8;
            this.passwordLbl.Text = "Password:";
            // 
            // usernameLbl
            // 
            this.usernameLbl.AutoSize = true;
            this.usernameLbl.Location = new System.Drawing.Point(72, 35);
            this.usernameLbl.Name = "usernameLbl";
            this.usernameLbl.Size = new System.Drawing.Size(58, 13);
            this.usernameLbl.TabIndex = 7;
            this.usernameLbl.Text = "Username:";
            // 
            // websiteUpdateTextBox
            // 
            this.websiteUpdateTextBox.Location = new System.Drawing.Point(136, 12);
            this.websiteUpdateTextBox.Name = "websiteUpdateTextBox";
            this.websiteUpdateTextBox.Size = new System.Drawing.Size(100, 20);
            this.websiteUpdateTextBox.TabIndex = 9;
            // 
            // websiteUpdateLbl
            // 
            this.websiteUpdateLbl.AutoSize = true;
            this.websiteUpdateLbl.Location = new System.Drawing.Point(72, 12);
            this.websiteUpdateLbl.Name = "websiteUpdateLbl";
            this.websiteUpdateLbl.Size = new System.Drawing.Size(49, 13);
            this.websiteUpdateLbl.TabIndex = 14;
            this.websiteUpdateLbl.Text = "Website:";
            // 
            // UpdateForm
            // 
            this.AcceptButton = this.updateSubmitButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 262);
            this.Controls.Add(this.websiteUpdateTextBox);
            this.Controls.Add(this.websiteUpdateLbl);
            this.Controls.Add(this.updateSubmitButton);
            this.Controls.Add(this.updateNotesRichTextBox);
            this.Controls.Add(this.updatePasswordTextBox);
            this.Controls.Add(this.updateUserNameTextBox);
            this.Controls.Add(this.notesLbl);
            this.Controls.Add(this.passwordLbl);
            this.Controls.Add(this.usernameLbl);
            this.Name = "UpdateForm";
            this.Text = "UpdateForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button updateSubmitButton;
        private System.Windows.Forms.RichTextBox updateNotesRichTextBox;
        private System.Windows.Forms.TextBox updatePasswordTextBox;
        private System.Windows.Forms.TextBox updateUserNameTextBox;
        private System.Windows.Forms.Label notesLbl;
        private System.Windows.Forms.Label passwordLbl;
        private System.Windows.Forms.Label usernameLbl;
        private System.Windows.Forms.TextBox websiteUpdateTextBox;
        private System.Windows.Forms.Label websiteUpdateLbl;
    }
}