using TinyBank.Service.Dtos.Accounts;
using TinyBank.Service.Dtos.Customer;
using TinyBank.Service.Interfaces;

namespace TinyBank.UI
{
    public partial class AccountsOfCustomerUC : UserControl
    {
        private readonly IAccountService _accountService;
        private readonly int _customerId;

        public AccountsOfCustomerUC(IAccountService accountService, int customerId)
        {
            InitializeComponent();
            _accountService = accountService;
            _customerId = customerId;
        }

        #region EVENTS
        private void AccountsOfCustomerUC_Load(object sender, EventArgs e)
        {
            try
            {
                accountsList.DataSource = GetAccountsOfCustomer(_customerId);
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error showing accounts: {ex.Message}");
            }
        }
        private void accountsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var selectedAccount = accountsList.SelectedItem as AccountForGettingDto;
                if (selectedAccount != null)
                {
                    FillForm(selectedAccount);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error showing accounts: {ex.Message}");
            }
        }
        private void clearFormButton_Click(object sender, EventArgs e)
        {
            try
            {
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error showing accounts: {ex.Message}");
            }
        }
        #endregion

        #region HELPERS

        private List<AccountForGettingDto> GetAccountsOfCustomer(int customerId) =>
            _accountService.GetAllAccountsOfCustomer(customerId);
        private void FillForm(AccountForGettingDto model)
        {
            ibanValue.Text = model.Iban;
            currencyValue.Text = model.Currency;
            balanceLabel.Text = model.Balance.ToString();
            customerIdValue.Text = model.CustomerId.ToString();
            destinationValue.Text = model.Destination;

        }
        private void ClearForm()
        {
            ibanValue.Text = string.Empty;
            currencyValue.Text = string.Empty;
            balanceLabel.Text = string.Empty;
            customerIdValue.Text = string.Empty;
            destinationValue.Text = string.Empty;
        }

        #endregion


    }
}
