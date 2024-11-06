using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment3
{
    class Sales
    {
        static protected int Sales_NUM;
        static protected int ProductNo;
        static protected int Price;
        static protected int Quantity;
        static protected string Dateofsale;

        public Sales(int salesNo, int productno, int price, int Qty, string dateofsale)
        {
            Sales_NUM = salesNo;
            ProductNo = productno;
            Price = price;
            Quantity = Qty;
            Dateofsale = dateofsale;

        }
    }
    class sales : Sales
    {
        public sales(int salesNo, int productno, int price, int Qty, string dateofsale)
                : base(salesNo, productno, price, Qty, dateofsale)
        {
        }
        public void Total_amount(int quantity, int price)
        {
            int total_price = Quantity * Price;
            Console.WriteLine("the total price : {0}", total_price);

        }
        public static void showdata()
        {
            Console.WriteLine("Sales no is {0}", Sales_NUM);
            Console.WriteLine("product no is {0}", ProductNo);
            Console.WriteLine("Price is {0} ", Price);
            Console.WriteLine("Date of sale is {0}", Dateofsale);

        }
        public static void Main()
        {
            Console.WriteLine("ENTER SALES NO ");
            int salesNo = int.Parse(Console.ReadLine());
            Console.WriteLine("ENTER PRODUCT NO ");
            int productno = int.Parse(Console.ReadLine());
            Console.WriteLine("ENTER price ");
            int price = int.Parse(Console.ReadLine());
            Console.WriteLine("ENTER QUANTITY ");
            int Qty = int.Parse(Console.ReadLine());
            Console.WriteLine("ENTER DATE OF SALE ");
            String dateofsale = Console.ReadLine();
            sales obj2 = new sales(salesNo, productno, price, Qty, dateofsale);
            obj2.Total_amount(Qty, price);
            showdata();
            Console.Read();
        }

    }
}

