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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            menuStrip1 = new MenuStrip();
            homeToolStripMenuItem = new ToolStripMenuItem();
            customersToolStripMenuItem = new ToolStripMenuItem();
            accountsToolStripMenuItem = new ToolStripMenuItem();
            operationsToolStripMenuItem = new ToolStripMenuItem();
            logoPictureBox = new PictureBox();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logoPictureBox).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { homeToolStripMenuItem, customersToolStripMenuItem, accountsToolStripMenuItem, operationsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1035, 33);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            homeToolStripMenuItem.Size = new Size(77, 29);
            homeToolStripMenuItem.Text = "Home";
            homeToolStripMenuItem.Click += homeToolStripMenuItem_Click;
            // 
            // customersToolStripMenuItem
            // 
            customersToolStripMenuItem.Name = "customersToolStripMenuItem";
            customersToolStripMenuItem.Size = new Size(113, 29);
            customersToolStripMenuItem.Text = "Customers";
            customersToolStripMenuItem.Click += customersToolStripMenuItem_Click;
            // 
            // accountsToolStripMenuItem
            // 
            accountsToolStripMenuItem.Name = "accountsToolStripMenuItem";
            accountsToolStripMenuItem.Size = new Size(101, 29);
            accountsToolStripMenuItem.Text = "Accounts";
            // 
            // operationsToolStripMenuItem
            // 
            operationsToolStripMenuItem.Name = "operationsToolStripMenuItem";
            operationsToolStripMenuItem.Size = new Size(116, 29);
            operationsToolStripMenuItem.Text = "Operations";
            // 
            // logoPictureBox
            // 
            logoPictureBox.Image = (Image)resources.GetObject("logoPictureBox.Image");
            logoPictureBox.Location = new Point(240, 234);
            logoPictureBox.Name = "logoPictureBox";
            logoPictureBox.Size = new Size(535, 306);
            logoPictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
            logoPictureBox.TabIndex = 1;
            logoPictureBox.TabStop = false;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 43, 80);
            ClientSize = new Size(1035, 840);
            Controls.Add(logoPictureBox);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MainMenuStrip = menuStrip1;
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)logoPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem customersToolStripMenuItem;
        private ToolStripMenuItem accountsToolStripMenuItem;
        private ToolStripMenuItem operationsToolStripMenuItem;
        private ToolStripMenuItem homeToolStripMenuItem;
        private PictureBox logoPictureBox;
    }
}