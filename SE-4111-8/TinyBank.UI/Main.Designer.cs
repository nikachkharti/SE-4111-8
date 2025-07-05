namespace TinyBank.UI
{
    partial class Main
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
            customersList = new ListBox();
            modifyGroupBox = new GroupBox();
            clearFormButton = new Button();
            deleteCustomerButton = new Button();
            updateCustomerButton = new Button();
            addCustomerButton = new Button();
            customerTypeValue = new ComboBox();
            customerTypeLabel = new Label();
            emailLabel = new Label();
            PhoneNumberLabel = new Label();
            identityNumberLabel = new Label();
            nameLabel = new Label();
            emailValue = new TextBox();
            phoneNumberValue = new TextBox();
            identityNumberValue = new TextBox();
            nameValue = new TextBox();
            modifyGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // customersList
            // 
            customersList.Cursor = Cursors.Hand;
            customersList.Dock = DockStyle.Top;
            customersList.FormattingEnabled = true;
            customersList.Location = new Point(0, 0);
            customersList.Name = "customersList";
            customersList.Size = new Size(1035, 254);
            customersList.TabIndex = 0;
            customersList.SelectedIndexChanged += customersList_SelectedIndexChanged;
            // 
            // modifyGroupBox
            // 
            modifyGroupBox.Controls.Add(clearFormButton);
            modifyGroupBox.Controls.Add(deleteCustomerButton);
            modifyGroupBox.Controls.Add(updateCustomerButton);
            modifyGroupBox.Controls.Add(addCustomerButton);
            modifyGroupBox.Controls.Add(customerTypeValue);
            modifyGroupBox.Controls.Add(customerTypeLabel);
            modifyGroupBox.Controls.Add(emailLabel);
            modifyGroupBox.Controls.Add(PhoneNumberLabel);
            modifyGroupBox.Controls.Add(identityNumberLabel);
            modifyGroupBox.Controls.Add(nameLabel);
            modifyGroupBox.Controls.Add(emailValue);
            modifyGroupBox.Controls.Add(phoneNumberValue);
            modifyGroupBox.Controls.Add(identityNumberValue);
            modifyGroupBox.Controls.Add(nameValue);
            modifyGroupBox.Location = new Point(12, 260);
            modifyGroupBox.Name = "modifyGroupBox";
            modifyGroupBox.Size = new Size(558, 352);
            modifyGroupBox.TabIndex = 1;
            modifyGroupBox.TabStop = false;
            modifyGroupBox.Text = "Modify";
            // 
            // clearFormButton
            // 
            clearFormButton.BackColor = Color.Gold;
            clearFormButton.Cursor = Cursors.Hand;
            clearFormButton.ForeColor = Color.Black;
            clearFormButton.Location = new Point(285, 217);
            clearFormButton.Name = "clearFormButton";
            clearFormButton.Size = new Size(62, 34);
            clearFormButton.TabIndex = 3;
            clearFormButton.Text = "Clear";
            clearFormButton.UseVisualStyleBackColor = false;
            clearFormButton.Click += clearFormButton_Click;
            // 
            // deleteCustomerButton
            // 
            deleteCustomerButton.BackColor = Color.Crimson;
            deleteCustomerButton.Cursor = Cursors.Hand;
            deleteCustomerButton.ForeColor = Color.White;
            deleteCustomerButton.Location = new Point(328, 312);
            deleteCustomerButton.Name = "deleteCustomerButton";
            deleteCustomerButton.Size = new Size(168, 34);
            deleteCustomerButton.TabIndex = 3;
            deleteCustomerButton.Text = "Delete Customer";
            deleteCustomerButton.UseVisualStyleBackColor = false;
            deleteCustomerButton.Click += deleteCustomerButton_Click;
            // 
            // updateCustomerButton
            // 
            updateCustomerButton.BackColor = Color.DeepSkyBlue;
            updateCustomerButton.Cursor = Cursors.Hand;
            updateCustomerButton.ForeColor = Color.Black;
            updateCustomerButton.Location = new Point(154, 312);
            updateCustomerButton.Name = "updateCustomerButton";
            updateCustomerButton.Size = new Size(168, 34);
            updateCustomerButton.TabIndex = 3;
            updateCustomerButton.Text = "Update Customer";
            updateCustomerButton.UseVisualStyleBackColor = false;
            updateCustomerButton.Click += updateCustomerButton_Click;
            // 
            // addCustomerButton
            // 
            addCustomerButton.BackColor = Color.SeaGreen;
            addCustomerButton.Cursor = Cursors.Hand;
            addCustomerButton.ForeColor = Color.White;
            addCustomerButton.Location = new Point(6, 312);
            addCustomerButton.Name = "addCustomerButton";
            addCustomerButton.Size = new Size(142, 34);
            addCustomerButton.TabIndex = 3;
            addCustomerButton.Text = "Add Customer";
            addCustomerButton.UseVisualStyleBackColor = false;
            addCustomerButton.Click += addCustomerButton_Click;
            // 
            // customerTypeValue
            // 
            customerTypeValue.Cursor = Cursors.Hand;
            customerTypeValue.DropDownStyle = ComboBoxStyle.DropDownList;
            customerTypeValue.FormattingEnabled = true;
            customerTypeValue.Items.AddRange(new object[] { "Phyisical", "Legal" });
            customerTypeValue.Location = new Point(285, 139);
            customerTypeValue.Name = "customerTypeValue";
            customerTypeValue.Size = new Size(258, 33);
            customerTypeValue.TabIndex = 2;
            // 
            // customerTypeLabel
            // 
            customerTypeLabel.AutoSize = true;
            customerTypeLabel.Location = new Point(285, 111);
            customerTypeLabel.Name = "customerTypeLabel";
            customerTypeLabel.Size = new Size(49, 25);
            customerTypeLabel.TabIndex = 1;
            customerTypeLabel.Text = "Type";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new Point(21, 189);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(54, 25);
            emailLabel.TabIndex = 1;
            emailLabel.Text = "Email";
            // 
            // PhoneNumberLabel
            // 
            PhoneNumberLabel.AutoSize = true;
            PhoneNumberLabel.Location = new Point(21, 113);
            PhoneNumberLabel.Name = "PhoneNumberLabel";
            PhoneNumberLabel.Size = new Size(62, 25);
            PhoneNumberLabel.TabIndex = 1;
            PhoneNumberLabel.Text = "Phone";
            // 
            // identityNumberLabel
            // 
            identityNumberLabel.AutoSize = true;
            identityNumberLabel.Location = new Point(285, 42);
            identityNumberLabel.Name = "identityNumberLabel";
            identityNumberLabel.Size = new Size(72, 25);
            identityNumberLabel.TabIndex = 1;
            identityNumberLabel.Text = "Identity";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(21, 42);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(59, 25);
            nameLabel.TabIndex = 1;
            nameLabel.Text = "Name";
            // 
            // emailValue
            // 
            emailValue.Location = new Point(21, 217);
            emailValue.Name = "emailValue";
            emailValue.Size = new Size(258, 31);
            emailValue.TabIndex = 0;
            // 
            // phoneNumberValue
            // 
            phoneNumberValue.Location = new Point(21, 141);
            phoneNumberValue.Name = "phoneNumberValue";
            phoneNumberValue.Size = new Size(258, 31);
            phoneNumberValue.TabIndex = 0;
            // 
            // identityNumberValue
            // 
            identityNumberValue.Location = new Point(285, 70);
            identityNumberValue.Name = "identityNumberValue";
            identityNumberValue.Size = new Size(258, 31);
            identityNumberValue.TabIndex = 0;
            // 
            // nameValue
            // 
            nameValue.Location = new Point(21, 70);
            nameValue.Name = "nameValue";
            nameValue.Size = new Size(258, 31);
            nameValue.TabIndex = 0;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1035, 840);
            Controls.Add(modifyGroupBox);
            Controls.Add(customersList);
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main";
            Load += Main_Load;
            modifyGroupBox.ResumeLayout(false);
            modifyGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ListBox customersList;
        private GroupBox modifyGroupBox;
        private Label nameLabel;
        private TextBox nameValue;
        private Label identityNumberLabel;
        private TextBox identityNumberValue;
        private Label PhoneNumberLabel;
        private TextBox phoneNumberValue;
        private Label customerTypeLabel;
        private ComboBox customerTypeValue;
        private Label emailLabel;
        private TextBox emailValue;
        private Button addCustomerButton;
        private Button updateCustomerButton;
        private Button deleteCustomerButton;
        private Button clearFormButton;
    }
}