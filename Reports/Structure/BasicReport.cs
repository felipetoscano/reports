namespace Reports.Structure
{
    public class BasicReport : Report
    {
        protected override string CreateBody(Bank bank)
        {
            var body = "";

            foreach (var account in bank.Accounts)
            {
                body += $"{account.OwnerName}\n{account.Balance}\n\n";
            }

            return body;
        }

        protected override string CreateFooter(Bank bank)
        {
            return bank.Phone;
        }

        protected override string CreateHeader(Bank bank)
        {
            return bank.BankName;
        }
    }
}
