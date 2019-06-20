using System;
using System.Collections.Generic;
using System.Text;
using Reference;

namespace Reference
{
    public enum Category { Spending, Income }

    public class AccountItem
    {
        public string Name { get; set; }
        public string Content { get; set; }
        public string Note { get; set; }

        public Category Category;
        public Money Amount;
        public DateTime OccuredTime;

        public AccountItem(Category category, string name, string content, string note, double value, Currency currency, DateTime occuredTime)
        {
            this.Category = category;
            this.Name = name;
            this.Content = content;
            this.Note = Note;
            this.Amount = new Money(value, currency);
            this.OccuredTime = occuredTime;
        }

        public override string ToString()
        {
            return $"Type: {Category.ToString()} | {Name} ({OccuredTime.ToString("MMMM dd, yyyy")}): {Amount.ToString()}. | Content: {Content} | Note: {Note}";
        }
    }
}
