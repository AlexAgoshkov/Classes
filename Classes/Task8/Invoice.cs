using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8
{
    class Invoice
    {
        public Invoice(int account, string customer, string provider)
        {
            _account = account;
            _customer = customer;
            _provider = provider;
        }

        public void OrderList(double price, string product, int count)
        {
            article = product;
            quantity = count;
            double tax = OrderPrice(price) / 100 * 20;
            Console.WriteLine($"Customer {_account} {_customer}");
            Console.WriteLine($"Product {article} from {_provider} Quantity {quantity}" );
            Console.WriteLine($"Order Price {OrderPrice(price)} without Tax");
            Console.WriteLine($"Order Price {OrderPrice(price) - tax} with Tax");
        }

        public double OrderPrice(double price)
        {
            return price * quantity;
        }


        private int quantity;

        private string article;

        readonly string _provider;

        readonly string _customer;

        readonly int _account;
    }
}
