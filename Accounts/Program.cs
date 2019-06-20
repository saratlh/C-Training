using System;
using Reference;

namespace AccountsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            AccountItem salary = new AccountItem(Category.Income, "salary", "salary of the month", "", 50000, Currency.RMB, new DateTime(2019, 6, 20));
            AccountItem rent = new AccountItem(Category.Spending, "rent", "rent of the month", "", 3000, Currency.RMB, new DateTime(2019, 6, 20));

            Accounts accountbook = new Accounts();
            accountbook.AddItem(salary);
            accountbook.AddItem(rent);

            // Display items
            accountbook.DisplayTotalIncome(DateTime.Now);
            accountbook.DisplayTotalExpenditure(DateTime.Now);
            accountbook.DisplayTotalRevenue(DateTime.Now);
            // accountbook.DisplayAllItems();

            foreach (var item in accountbook.Display(DateTime.Now))
            {
                Console.WriteLine(item);
            }
        }
    }
}
