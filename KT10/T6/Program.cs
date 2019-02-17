using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T6
{
    class Program
    {
        static void Main(string[] args)
        {
            InvoiceItem i = new InvoiceItem();
            i.Name = "Milk";
            i.Price = 1.5;
            i.Quantity = 3;
            i.TotalPrice();
            Console.WriteLine(i.ToString());
            Console.WriteLine("====================================");

            InvoiceItem b = new InvoiceItem();
            b.Name = "Beer";
            b.Price = 1.2;
            b.Quantity = 12;
            b.TotalPrice();
            Console.WriteLine(b.ToString());
            Console.WriteLine("====================================");

            InvoiceItem d = new InvoiceItem();
            d.Name = "Doritos";
            d.Price = 1.9;
            d.Quantity = 1;
            d.TotalPrice();
            Console.WriteLine(d.ToString());

            Invoice i1 = new Invoice();
            i1.products.Add(i);
            i1.products.Add(b);
            i1.products.Add(d);

            i1.TotalInvoice();

            i1.PrintInvoice();
        }
    }

    public class InvoiceItem
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public double Total;

        public double TotalPrice()
        {
            Total = Quantity * Price;
            return Total;

        }

        public override string ToString()
        {
            return string.Format("Name: {0} \nPrice: {1}e \nQuantity: {2} \nTotal: {3}e", Name, Price, Quantity, Total);
        }
    }

    public class Invoice
    {
        public string Customer { get; set; }
        public List<InvoiceItem> products = new List<InvoiceItem>();
        public string Total;

        public string TotalInvoice()
        {
            double total = products.Sum(item=>item.Total);
            //foreach (InvoiceItem item in products)
            //{
            //    total += item.Total;
            //}

            Total =  string.Format("{0}", total);
            return Total;
        }

        public void PrintInvoice()
        {
            Console.WriteLine("\n\nCustomer {0}'s invoice:", Customer);
            Console.WriteLine("====================================");
            foreach(InvoiceItem item in products)
            {
                Console.WriteLine("{0}    {1}e {2} pieces {3}e total", item.Name, item.Price, item.Quantity, item.Total);
            }
            Console.WriteLine("====================================");
            Console.WriteLine("Total  :  {0} euros", Total);
        }
    }
}
