using System;

namespace Sales_System
{
    class Program
    {
        static void Main(string[] args)
        {
            // vendedor
            SalesMan s1 = new SalesMan();
            s1.name = "Jorge Gonzalez";
            s1.age = 32;

            SalesMan s2 = new SalesMan();
            s2.name = "Mauricio Sanchez";
            s2.age = 48;

            SalesMan s3 = new SalesMan();
            s3.name = "Valentina Gallego";
            s3.age = 22;


            // producto
            Product p1 = new Product();
            p1.productname = "interom";
            p1.productprice = 320000;

            Product p2 = new Product();
            p2.productname = "case";
            p2.productprice = 25000;

            Product p3 = new Product();
            p3.productname = "motorcycle";
            p3.productprice = 5000;

            //venta

            Sale sa1 = new Sale();
            sa1.SalesMan = s1.name;
            sa1.Product = p1.productname;
            sa1.comments = "approved.";
            sa1.price = p1.productprice;

            Sale sa2 = new Sale();
            sa2.SalesMan = s3.name;
            sa2.Product = p2.productname;
            sa2.comments = "approved";
            sa2.price = p2.productprice;


            Sale sa3 = new Sale();
            sa3.SalesMan = s1.name;
            sa3.Product = p2.productname;
            sa3.comments = "approved";
            sa3.price = p2.productprice;

            /*int totalprice(Sale price1, Sale price2, Sale price3)
            {
                int pricecalculation = price1.price + price2.price + price3.price;
                return pricecalculation;

            }
            Console.WriteLine("Sales total amount: " + totalprice(sa1, sa2, sa3));
            */


            Databases databases = new Databases ();

            databases.AddSalesMan(s1);
            databases.AddSalesMan(s2);
            databases.AddSalesMan(s3);

            databases.AddProduct(p1);
            databases.AddProduct(p2);
            databases.AddProduct(p3);

            databases.AddSale(sa1);
            databases.AddSale(sa2);
            databases.AddSale(sa3);

            //databases.SaleEconomic();
            //databases.averagevalue();
            //databases.Productforunit("interom");
            databases.expensiveproduct();
            



        }
    }
}
