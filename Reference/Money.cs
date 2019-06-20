using System;
using System.Collections.Generic;
using System.Text;

namespace Reference
{
    public class Money
    {
        public double Value;
        public Currency Currency;

        public Money(double val) { Value = val; Currency = Currency.RMB;}
        public Money(double val, Currency currency) { this.Value = val; this.Currency = currency;}

        public static Money operator + (Money money1, Money money2)
        {
            double TotalAmount = money1.Value + money2.Value;
            Currency GeneralCurrency = money1.Currency;
            return new Money(TotalAmount, GeneralCurrency);
        }

        public static Money operator - (Money money1, Money money2)
        {
            double TotalAmount = money1.Value - money2.Value;
            Currency GeneralCurrency = money1.Currency;
            return new Money(TotalAmount, GeneralCurrency);
        }

        public override string ToString()
        {
            return $"{this.Value} {this.Currency}";
        }
    }
}
