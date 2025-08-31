namespace TinyBank.UI
{
    partial class AccountsOfCustomerUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            accountsList = new ListBox();
            modifyGroupBox = new GroupBox();
            deleteAccountButton = new Button();
            clearFormButton = new Button();
            updateAccountButton = new Button();
            addAccountButton = new Button();
            destinationLabel = new Label();
            customerIdLabel = new Label();
            balanceLabel = new Label();
            currencyLabel = new Label();
            ibanLabel = new Label();
            destinationValue = new TextBox();
            customerIdValue = new TextBox();
            balanceValue = new TextBox();
            currencyValue = new TextBox();
            ibanValue = new TextBox();
            modifyGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // accountsList
            // 
            accountsList.Cursor = Cursors.Hand;
            accountsList.Dock = DockStyle.Top;
            accountsList.FormattingEnabled = true;
            accountsList.Location = new Point(0, 0);
            accountsList.Name = "accountsList";
            accountsList.Size = new Size(1057, 329);
            accountsList.TabIndex = 0;
            accountsList.SelectedIndexChanged += accountsList_SelectedIndexChanged;
            // 
            // modifyGroupBox
            // 
            modifyGroupBox.Controls.Add(deleteAccountButton);
            modifyGroupBox.Controls.Add(clearFormButton);
            modifyGroupBox.Controls.Add(updateAccountButton);
            modifyGroupBox.Controls.Add(addAccountButton);
            modifyGroupBox.Controls.Add(destinationLabel);
            modifyGroupBox.Controls.Add(customerIdLabel);
            modifyGroupBox.Controls.Add(balanceLabel);
            modifyGroupBox.Controls.Add(currencyLabel);
            modifyGroupBox.Controls.Add(ibanLabel);
            modifyGroupBox.Controls.Add(destinationValue);
            modifyGroupBox.Controls.Add(customerIdValue);
            modifyGroupBox.Controls.Add(balanceValue);
            modifyGroupBox.Controls.Add(currencyValue);
            modifyGroupBox.Controls.Add(ibanValue);
            modifyGroupBox.Location = new Point(3, 335);
            modifyGroupBox.Name = "modifyGroupBox";
            modifyGroupBox.Size = new Size(490, 558);
            modifyGroupBox.TabIndex = 1;
            modifyGroupBox.TabStop = false;
            modifyGroupBox.Text = "Modify";
            // 
            // deleteAccountButton
            // 
            deleteAccountButton.BackColor = Color.Crimson;
            deleteAccountButton.Cursor = Cursors.Hand;
            deleteAccountButton.ForeColor = Color.White;
            deleteAccountButton.Location = new Point(220, 412);
            deleteAccountButton.Name = "deleteAccountButton";
            deleteAccountButton.Size = new Size(168, 34);
            deleteAccountButton.TabIndex = 21;
            deleteAccountButton.Text = "Delete Account";
            deleteAccountButton.UseVisualStyleBackColor = false;
            // 
            // clearFormButton
            // 
            clearFormButton.BackColor = Color.Gold;
            clearFormButton.Cursor = Cursors.Hand;
            clearFormButton.ForeColor = Color.Black;
            clearFormButton.Location = new Point(75, 412);
            clearFormButton.Name = "clearFormButton";
            clearFormButton.Size = new Size(139, 34);
            clearFormButton.TabIndex = 20;
            clearFormButton.Text = "Clear Form";
            clearFormButton.UseVisualStyleBackColor = false;
            clearFormButton.Click += clearFormButton_Click;
            // 
            // updateAccountButton
            // 
            updateAccountButton.BackColor = Color.DeepSkyBlue;
            updateAccountButton.Cursor = Cursors.Hand;
            updateAccountButton.ForeColor = Color.Black;
            updateAccountButton.Location = new Point(220, 372);
            updateAccountButton.Name = "updateAccountButton";
            updateAccountButton.Size = new Size(168, 34);
            updateAccountButton.TabIndex = 19;
            updateAccountButton.Text = "Update Account";
            updateAccountButton.UseVisualStyleBackColor = false;
            // 
            // addAccountButton
            // 
            addAccountButton.BackColor = Color.SeaGreen;
            addAccountButton.Cursor = Cursors.Hand;
            addAccountButton.ForeColor = Color.White;
            addAccountButton.Location = new Point(72, 372);
            addAccountButton.Name = "addAccountButton";
            addAccountButton.Size = new Size(142, 34);
            addAccountButton.TabIndex = 18;
            addAccountButton.Text = "Add Account";
            addAccountButton.UseVisualStyleBackColor = false;
            // 
            // destinationLabel
            // 
            destinationLabel.AutoSize = true;
            destinationLabel.Location = new Point(6, 297);
            destinationLabel.Name = "destinationLabel";
            destinationLabel.Size = new Size(102, 25);
            destinationLabel.TabIndex = 14;
            destinationLabel.Text = "Destination";
            // 
            // customerIdLabel
            // 
            customerIdLabel.AutoSize = true;
            customerIdLabel.Location = new Point(6, 222);
            customerIdLabel.Name = "customerIdLabel";
            customerIdLabel.Size = new Size(105, 25);
            customerIdLabel.TabIndex = 14;
            customerIdLabel.Text = "CustomerId";
            // 
            // balanceLabel
            // 
            balanceLabel.AutoSize = true;
            balanceLabel.Location = new Point(6, 160);
            balanceLabel.Name = "balanceLabel";
            balanceLabel.Size = new Size(71, 25);
            balanceLabel.TabIndex = 14;
            balanceLabel.Text = "Balance";
            // 
            // currencyLabel
            // 
            currencyLabel.AutoSize = true;
            currencyLabel.Location = new Point(6, 98);
            currencyLabel.Name = "currencyLabel";
            currencyLabel.Size = new Size(81, 25);
            currencyLabel.TabIndex = 14;
            currencyLabel.Text = "Currency";
            // 
            // ibanLabel
            // 
            ibanLabel.AutoSize = true;
            ibanLabel.Location = new Point(6, 36);
            ibanLabel.Name = "ibanLabel";
            ibanLabel.Size = new Size(52, 25);
            ibanLabel.TabIndex = 14;
            ibanLabel.Text = "IBAN";
            // 
            // destinationValue
            // 
            destinationValue.Location = new Point(6, 325);
            destinationValue.Name = "destinationValue";
            destinationValue.Size = new Size(461, 31);
            destinationValue.TabIndex = 13;
            // 
            // customerIdValue
            // 
            customerIdValue.Location = new Point(6, 250);
            customerIdValue.Name = "customerIdValue";
            customerIdValue.Size = new Size(461, 31);
            customerIdValue.TabIndex = 13;
            // 
            // balanceValue
            // 
            balanceValue.Location = new Point(6, 188);
            balanceValue.Name = "balanceValue";
            balanceValue.Size = new Size(461, 31);
            balanceValue.TabIndex = 13;
            // 
            // currencyValue
            // 
            currencyValue.Location = new Point(6, 126);
            currencyValue.Name = "currencyValue";
            currencyValue.Size = new Size(461, 31);
            currencyValue.TabIndex = 13;
            // 
            // ibanValue
            // 
            ibanValue.Location = new Point(6, 64);
            ibanValue.Name = "ibanValue";
            ibanValue.Size = new Size(461, 31);
            ibanValue.TabIndex = 13;
            // 
            // AccountsOfCustomerUC
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(modifyGroupBox);
            Controls.Add(accountsList);
            Name = "AccountsOfCustomerUC";
            Size = new Size(1057, 896);
            Load += AccountsOfCustomerUC_Load;
            modifyGroupBox.ResumeLayout(false);
            modifyGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ListBox accountsList;
        private GroupBox modifyGroupBox;
        private Label ibanLabel;
        private TextBox ibanValue;
        private Label currencyLabel;
        private TextBox currencyValue;
        private Label balanceLabel;
        private TextBox balanceValue;
        private Label customerIdLabel;
        private TextBox customerIdValue;
        private Label destinationLabel;
        private TextBox destinationValue;
        private Button addAccountButton;
        private Button updateAccountButton;
        private Button clearFormButton;
        private Button deleteAccountButton;
    }
}
