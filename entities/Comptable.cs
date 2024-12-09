namespace Cours.Models
{
    public class Comptable
    {
        private static int count = 0;
        private int id;
        private string surnom;
        private decimal balance;

        public Comptable(string surnom, string? email)
        {
            count++;
            this.id = count;
            this.surnom = surnom;
            this.balance = 0m;
        }

        public int Id => id;
        public string Surnom => surnom;
        public decimal Balance => balance;

        public string? Name { get; internal set; }
        public string? Email { get; internal set; }

        public void AddPayment(decimal amount)
        {
            balance += amount;
        }

        public void GenerateFinancialReport()
        {
            Console.WriteLine($"Rapport financier pour {surnom} :");
            Console.WriteLine($"Balance actuelle : {balance} €");
        }
    }
}
