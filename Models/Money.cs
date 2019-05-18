namespace CorsoDotnet.Models
{
    public class Money
    {
        private Currency _currency;
        public Currency Currency
        {
            get { return _currency; }
            set { _currency = value; }

        }

        private decimal _price;
        public decimal Price
        {
            get { return _price; }
            set { _price = value; }
        }

        public Money(Currency currency, decimal price)
        {
            Currency = currency;
            Price = price;
        }

    }
}