using TinyBank.Models;
using TinyBank.Service.Dtos.Customer;
using TinyBank.Service.Interfaces;

namespace TinyBank.UI
{
    public partial class CustomersUC : UserControl
    {
        private readonly ICustomerService _customerService;
        public CustomersUC(ICustomerService customerService)
        {
            InitializeComponent();
            _customerService = customerService;
        }

        #region EVENTS
        private void CustomersUC_Load(object sender, EventArgs e)
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
        private void addCustomerButton_Click(object sender, EventArgs e)
        {
            try
            {
                var newCustomer = GenerateCreateForm();
                _customerService.AddCustomer(newCustomer);
                customersList.DataSource = GetCustomers();
                ClearForm();

                MessageBox.Show("Customer added successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding customer: {ex.Message}");
            }
        }
        private void clearFormButton_Click(object sender, EventArgs e) => ClearForm();
        private void deleteCustomerButton_Click(object sender, EventArgs e)
        {
            var selectedCustomer = customersList.SelectedItem as CustomerForGettingDto;

            if (selectedCustomer is null)
            {
                MessageBox.Show("Please select a customer to delete.");
                return;
            }

            var confirmResult = MessageBox.Show(
                $"Are you sure you want to delete '{selectedCustomer.Name}'?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);


            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    _customerService.DeleteCustomer(selectedCustomer.Id);
                    MessageBox.Show("Customer deleted successfully.");

                    customersList.DataSource = GetCustomers();
                    ClearForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error deleting customer: {ex.Message}");
                }
            }

        }
        private void updateCustomerButton_Click(object sender, EventArgs e)
        {
            try
            {
                var customerToUpdate = GenerateUpdateForm();
                _customerService.UpdateCustomer(customerToUpdate);
                customersList.DataSource = GetCustomers();
                ClearForm();

                MessageBox.Show("Customer updated successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating customer: {ex.Message}");
            }
        }


        #endregion


        #region HELPERS
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
        private CustomerForCreatingDto GenerateCreateForm() => new CustomerForCreatingDto()
        {
            Name = nameValue.Text,
            IdentityNumber = identityNumberValue.Text,
            PhoneNumber = phoneNumberValue.Text,
            CustomerType = Enum.Parse<CustomerType>(customerTypeValue.Text),
            Email = emailValue.Text
        };
        private CustomerForUpdatingDto GenerateUpdateForm()
        {
            var selectedCustomer = customersList.SelectedItem as CustomerForGettingDto;

            return new CustomerForUpdatingDto()
            {
                Id = selectedCustomer.Id,
                Name = nameValue.Text,
                IdentityNumber = identityNumberValue.Text,
                PhoneNumber = phoneNumberValue.Text,
                CustomerType = Enum.Parse<CustomerType>(customerTypeValue.Text),
                Email = emailValue.Text
            };
        }
        #endregion


    }
}
