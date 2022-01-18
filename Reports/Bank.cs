namespace Reports
{
    public class Bank
    {
        public string BankName { get; private set; }
        public string Phone { get; private set; }
        public string Address { get; private set; }
        public string Email { get; private set; }
        public IList<Account> Accounts { get; private set; }

        public Bank(
            string bankName,
            string phone,
            string address,
            string email,
            IList<Account> accounts)
        {
            BankName = bankName;
            Phone = phone;
            Address = address;
            Email = email;
            Accounts = accounts;
        }
    }
}
