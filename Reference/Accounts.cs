using System;
using System.Collections.Generic;
using System.Text;

namespace Reference
{
    public class Accounts
    {
        public List<AccountItem> AccountList = new List<AccountItem>();

        public void AddItem(AccountItem item)
        {
            AccountList.Add(item);
        }

        public Money TotalRevenue(DateTime time)
        {
            Money revenue = new Money(0);

            foreach (AccountItem item in AccountList)
            {
                if (item.OccuredTime.Month == time.Month)
                {
                    if (item.Category == Category.Spending)
                    {
                        revenue -= item.Amount;
                    }
                    else
                    {
                        revenue += item.Amount;
                    }
                }
            }
            return revenue;
        }

        public void DisplayTotalRevenue(DateTime time)
        {
            Money TotalRevenue = this.TotalRevenue(time);
            Console.WriteLine($"Revenue of {time.ToString("MMMM")} equals {TotalRevenue}");
        }

        public Money TotalExpenditure(DateTime time)
        {
            Money expenditure = new Money(0);

            foreach (AccountItem item in AccountList)
            {
                if (item.OccuredTime.Month == time.Month)
                {
                    if (item.Category == Category.Spending)
                    {
                        expenditure += item.Amount;
                    }
                }
            }
            return expenditure;
        }

        public void DisplayTotalExpenditure(DateTime time)
        {
            Money TotalExpenditure = this.TotalExpenditure(time);
            Console.WriteLine($"Expenditure of {time.ToString("MMMM")} equals {TotalExpenditure}");
        }

        public Money TotalIncome(DateTime time)
        {
            Money income = new Money(0);

            foreach (AccountItem item in AccountList)
            {
                if (item.OccuredTime.Month == time.Month)
                {
                    if (item.Category == Category.Income)
                    {
                        income += item.Amount;
                    }
                }
            }
            return income;
        }

        public void DisplayTotalIncome(DateTime time)
        {
            Money TotalIncome = this.TotalIncome(time);
            Console.WriteLine($"Income of {time.ToString("MMMM")} equals {TotalIncome}");
        }

        public IEnumerable<AccountItem> Display(DateTime time)
        {
            foreach (AccountItem item in AccountList)
            {
                if (item.OccuredTime.Month == time.Month)
                {
                    yield return item;
                }
            }
        }

        public void DisplayAllItems()
        {
            foreach (AccountItem item in AccountList)
            {
                Console.WriteLine(item);
            }
        }
    }
}
