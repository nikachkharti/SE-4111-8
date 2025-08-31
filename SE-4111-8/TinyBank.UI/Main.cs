using TinyBank.Service.Interfaces;

namespace TinyBank.UI
{
    public partial class Main : Form
    {
        public Main(ICustomerService customerService)
        {
            InitializeComponent();

            var customersUserControl = new CustomersUC(customerService);
            customersUserControl.Dock = DockStyle.Fill;
            this.Controls.Add(customersUserControl);
        }
    }
}
