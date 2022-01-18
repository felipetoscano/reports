namespace Reports.Structure
{
    public abstract class Report
    {
        public string CreateReport(Bank bank)
        {
            return $"**********\n" +
                $"{CreateHeader(bank)}\n" +
                $"{CreateBody(bank)}\n" +
                $"{CreateFooter(bank)}\n" +
                $"**********\n";
        }

        protected abstract string CreateHeader(Bank bank);
        protected abstract string CreateBody(Bank bank);
        protected abstract string CreateFooter(Bank bank);
    }
}
