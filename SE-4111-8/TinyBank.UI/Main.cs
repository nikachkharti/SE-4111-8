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

        private void Main_Load(object sender, EventArgs e)
        {
            var customers = _customerService.GetAllCustomers();
            customersList.DataSource = customers;
        }
    }
}
