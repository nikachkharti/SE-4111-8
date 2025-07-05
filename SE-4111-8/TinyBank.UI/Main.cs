using TinyBank.Service.Dtos;
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
            customersList.DataSource = GetCustomers();
            ClearForm();
        }

        private void customersList_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedCustomer = customersList.SelectedItem as CustomerForGettingDto;
            if (selectedCustomer != null)
                FillForm(selectedCustomer);
        }


        private void clearFormButton_Click(object sender, EventArgs e) => ClearForm();


        private List<CustomerForGettingDto> GetCustomers() => _customerService.GetAllCustomers();

        private void FillForm(CustomerForGettingDto model)
        {
            nameValue.Text = model.Name;
            identityNumberValue.Text = model.IdentityNumber;
            phoneNumberValue.Text = model.PhoneNumber;
            customerTypeValue.Text = model.CustomerType.ToString();
            emailValue.Text = model.Email;
        }
        private void ClearForm()
        {
            nameValue.Text = string.Empty;
            identityNumberValue.Text = string.Empty;
            phoneNumberValue.Text = string.Empty;
            customerTypeValue.Text = string.Empty;
            emailValue.Text = string.Empty;
        }


    }
}
