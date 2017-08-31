namespace Password_Saver.Forms
{
    partial class DeleteForm
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
            this.deleteComboBox = new System.Windows.Forms.ComboBox();
            this.deleteDeleteButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // deleteComboBox
            // 
            this.deleteComboBox.FormattingEnabled = true;
            this.deleteComboBox.Location = new System.Drawing.Point(133, 32);
            this.deleteComboBox.Name = "deleteComboBox";
            this.deleteComboBox.Size = new System.Drawing.Size(121, 21);
            this.deleteComboBox.TabIndex = 2;
            // 
            // deleteDeleteButton
            // 
            this.deleteDeleteButton.Location = new System.Drawing.Point(159, 87);
            this.deleteDeleteButton.Name = "deleteDeleteButton";
            this.deleteDeleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteDeleteButton.TabIndex = 5;
            this.deleteDeleteButton.Text = "Delete";
            this.deleteDeleteButton.UseVisualStyleBackColor = true;
            // 
            // DeleteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 217);
            this.Controls.Add(this.deleteDeleteButton);
            this.Controls.Add(this.deleteComboBox);
            this.Name = "DeleteForm";
            this.Text = "DeleteForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox deleteComboBox;
        private System.Windows.Forms.Button deleteDeleteButton;
    }
}