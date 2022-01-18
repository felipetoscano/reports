namespace Reports.Structure
{
    public class CompleteReport : Report
    {
        protected override string CreateBody(Bank bank)
        {
            var body = "";

            foreach (var account in bank.Accounts)
            {
                body += $"{account.OwnerName}\n{account.AgencyNumber}\n{account.AccountNumber}\n{account.Balance}\n\n";
            }

            return body;
        }

        protected override string CreateFooter(Bank bank)
        {
            return $"{bank.Email}\n{DateTime.Now}";
        }

        protected override string CreateHeader(Bank bank)
        {
            return $"{bank.BankName}\n{bank.Address}\n{bank.Phone}\n";
        }
    }
}
