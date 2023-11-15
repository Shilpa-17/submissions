using System;
using static System.Console;

namespace assignment5
{
    class que3
    {
        int salesno;
        int productno;
        double price;
        DateTime Dateofsale;
        int quantity;
        double totalamount;

        public que3(int sno, int prdctno, double rate, int qty, DateTime dateofsale)
        {
            this.salesno = sno;
            this.productno = prdctno;
            this.price = rate;
            this.quantity = qty;
            this.Dateofsale = dateofsale ;
        }
        public void sales()
        {
            this.totalamount = this.quantity * this.price;

        }
        public void ShowData()
        {
            WriteLine("salesno:" + this.salesno);
            WriteLine("productno:" + this.productno);
            WriteLine("price:" + this.price);
            WriteLine("Dateofsale:" + this.Dateofsale);
            WriteLine("quantity:" + this.quantity);
            WriteLine("totalamount:" + this.totalamount);

        }
    }
    class Details
    {
        static void Main()
        {
            WriteLine("Enter The Sales Number");
            int sno = int.Parse(ReadLine());

            WriteLine("Enter The Product Number");
            int prdctno = int.Parse(ReadLine());

            WriteLine("Enter The Price Of The Product");
            double rate = double.Parse(ReadLine());

            WriteLine("Enter The Quantity");
            int qty = int.Parse(ReadLine());

            WriteLine("Enter The Date and Time");
            DateTime dateofsale = DateTime.Parse(ReadLine());

            que3 sale = new que3(sno, prdctno, rate, qty, dateofsale);
            sale.sales();
            sale.ShowData();



        }

    }
}
