namespace Password_Saver.Forms
{
    partial class AddForm
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
            this.usernameLbl = new System.Windows.Forms.Label();
            this.passwordLbl = new System.Windows.Forms.Label();
            this.notesLbl = new System.Windows.Forms.Label();
            this.userAddNameTextBox = new System.Windows.Forms.TextBox();
            this.passwordAddTextBox = new System.Windows.Forms.TextBox();
            this.notesAddRichTextBox = new System.Windows.Forms.RichTextBox();
            this.addSubmitButton = new System.Windows.Forms.Button();
            this.websiteAddTextBox = new System.Windows.Forms.TextBox();
            this.websiteLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // usernameLbl
            // 
            this.usernameLbl.AutoSize = true;
            this.usernameLbl.Location = new System.Drawing.Point(47, 43);
            this.usernameLbl.Name = "usernameLbl";
            this.usernameLbl.Size = new System.Drawing.Size(58, 13);
            this.usernameLbl.TabIndex = 0;
            this.usernameLbl.Text = "Username:";
            // 
            // passwordLbl
            // 
            this.passwordLbl.AutoSize = true;
            this.passwordLbl.Location = new System.Drawing.Point(47, 69);
            this.passwordLbl.Name = "passwordLbl";
            this.passwordLbl.Size = new System.Drawing.Size(56, 13);
            this.passwordLbl.TabIndex = 1;
            this.passwordLbl.Text = "Password:";
            // 
            // notesLbl
            // 
            this.notesLbl.AutoSize = true;
            this.notesLbl.Location = new System.Drawing.Point(49, 139);
            this.notesLbl.Name = "notesLbl";
            this.notesLbl.Size = new System.Drawing.Size(38, 13);
            this.notesLbl.TabIndex = 2;
            this.notesLbl.Text = "Notes:";
            // 
            // userAddNameTextBox
            // 
            this.userAddNameTextBox.Location = new System.Drawing.Point(113, 43);
            this.userAddNameTextBox.Name = "userAddNameTextBox";
            this.userAddNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.userAddNameTextBox.TabIndex = 3;
            // 
            // passwordAddTextBox
            // 
            this.passwordAddTextBox.Location = new System.Drawing.Point(113, 69);
            this.passwordAddTextBox.Name = "passwordAddTextBox";
            this.passwordAddTextBox.Size = new System.Drawing.Size(100, 20);
            this.passwordAddTextBox.TabIndex = 4;
            // 
            // notesAddRichTextBox
            // 
            this.notesAddRichTextBox.Location = new System.Drawing.Point(113, 95);
            this.notesAddRichTextBox.Name = "notesAddRichTextBox";
            this.notesAddRichTextBox.Size = new System.Drawing.Size(202, 96);
            this.notesAddRichTextBox.TabIndex = 5;
            this.notesAddRichTextBox.Text = "";
            // 
            // addSubmitButton
            // 
            this.addSubmitButton.Location = new System.Drawing.Point(113, 197);
            this.addSubmitButton.Name = "addSubmitButton";
            this.addSubmitButton.Size = new System.Drawing.Size(75, 23);
            this.addSubmitButton.TabIndex = 6;
            this.addSubmitButton.Text = "Submit";
            this.addSubmitButton.UseVisualStyleBackColor = true;
            this.addSubmitButton.Click += new System.EventHandler(this.addSubmitButton_Click);
            // 
            // websiteAddTextBox
            // 
            this.websiteAddTextBox.Location = new System.Drawing.Point(113, 17);
            this.websiteAddTextBox.Name = "websiteAddTextBox";
            this.websiteAddTextBox.Size = new System.Drawing.Size(100, 20);
            this.websiteAddTextBox.TabIndex = 2;
            // 
            // websiteLbl
            // 
            this.websiteLbl.AutoSize = true;
            this.websiteLbl.Location = new System.Drawing.Point(47, 20);
            this.websiteLbl.Name = "websiteLbl";
            this.websiteLbl.Size = new System.Drawing.Size(49, 13);
            this.websiteLbl.TabIndex = 7;
            this.websiteLbl.Text = "Website:";
            // 
            // AddForm
            // 
            this.AcceptButton = this.addSubmitButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 259);
            this.Controls.Add(this.websiteAddTextBox);
            this.Controls.Add(this.websiteLbl);
            this.Controls.Add(this.addSubmitButton);
            this.Controls.Add(this.notesAddRichTextBox);
            this.Controls.Add(this.passwordAddTextBox);
            this.Controls.Add(this.userAddNameTextBox);
            this.Controls.Add(this.notesLbl);
            this.Controls.Add(this.passwordLbl);
            this.Controls.Add(this.usernameLbl);
            this.Name = "AddForm";
            this.Text = "AddForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label usernameLbl;
        private System.Windows.Forms.Label passwordLbl;
        private System.Windows.Forms.Label notesLbl;
        private System.Windows.Forms.TextBox userAddNameTextBox;
        private System.Windows.Forms.TextBox passwordAddTextBox;
        private System.Windows.Forms.RichTextBox notesAddRichTextBox;
        private System.Windows.Forms.Button addSubmitButton;
        private System.Windows.Forms.TextBox websiteAddTextBox;
        private System.Windows.Forms.Label websiteLbl;
    }
}