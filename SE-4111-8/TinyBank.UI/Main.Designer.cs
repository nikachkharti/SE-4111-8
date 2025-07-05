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
            SuspendLayout();
            // 
            // customersList
            // 
            customersList.Dock = DockStyle.Top;
            customersList.FormattingEnabled = true;
            customersList.Location = new Point(0, 0);
            customersList.Name = "customersList";
            customersList.Size = new Size(1035, 304);
            customersList.TabIndex = 0;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1035, 648);
            Controls.Add(customersList);
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main";
            Load += Main_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListBox customersList;
    }
}