using TinyBank.Service.Interfaces;

namespace TinyBank.UI
{
    public partial class Main : Form
    {
        private readonly ICustomerService _customerService;
        private readonly IAccountService _accountService;

        public Main(ICustomerService customerService, IAccountService accountService)
        {
            InitializeComponent();
            _customerService = customerService;
            _accountService = accountService;
        }

        private void customersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowUserControl(new CustomersUC(_customerService, _accountService));
            logoPictureBox.Visible = false;
        }


        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearUserControls();
            logoPictureBox.Visible = true;
        }


        private void ShowUserControl(UserControl control)
        {
            ClearUserControls();
            control.Dock = DockStyle.Fill;
            this.Controls.Add(control);
            control.BringToFront();
        }

        private void ClearUserControls()
        {
            // Remove all user controls except the logoPictureBox and MenuStrip
            for (int i = this.Controls.Count - 1; i >= 0; i--)
            {
                if (!(this.Controls[i] is PictureBox) && !(this.Controls[i] is MenuStrip))
                {
                    this.Controls.RemoveAt(i);
                }
            }
        }

    }
}
