namespace Reports
{
    public class Account
    {
        public string OwnerName { get; set; }
        public int AgencyNumber { get; set; }
        public int AccountNumber { get; set; }
        public double Balance { get; set; }

        public Account(string ownerName, int agencyNumber, int accountNumber, double balance)
        {
            OwnerName = ownerName;
            AgencyNumber = agencyNumber;
            AccountNumber = accountNumber;
            Balance = balance;
        }
    }
}
