using TinyBank.Service.Implementations;
using TinyBank.Service.Interfaces;

namespace TinyBank.UI
{
    public partial class Main : Form
    {
        private readonly ICustomerService _customerService;

        public Main(ICustomerService customerService)
        {
            InitializeComponent();
            _customerService = customerService;
        }

        private void customersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var customersUserControl = new CustomersUC(_customerService);
            customersUserControl.Dock = DockStyle.Fill;
            this.Controls.Add(customersUserControl);
        }
    }
}
