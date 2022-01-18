using Reports.Structure;

namespace Reports
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var basicReport = new BasicReport();
            var completeReport = new CompleteReport();

            var account1 = new Account("Felipe", 2, 1641811, 5000);
            var account2 = new Account("Joana", 4, 1631875, 50000);
            var accounts = new List<Account>() { account1, account2 };
            var bank = new Bank("BK", "11999999999", "Rua das Oliveiras", "bk@gmail.com", accounts);

            basicReport.CreateReport(bank);
            completeReport.CreateReport(bank);
        }
    }
}