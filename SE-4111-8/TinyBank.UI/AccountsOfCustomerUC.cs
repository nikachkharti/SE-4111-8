using TinyBank.Service.Dtos.Accounts;
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

        private void AccountsOfCustomerUC_Load(object sender, EventArgs e)
        {
            var x = GetAccountsOfCustomer(_customerId);
        }


        #region HELPERS

        private List<AccountForGettingDto> GetAccountsOfCustomer(int customerId) =>
            _accountService.GetAllAccountsOfCustomer(customerId);

        #endregion
    }
}
