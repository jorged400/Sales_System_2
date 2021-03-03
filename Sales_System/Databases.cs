using System;
using System.Collections.Generic;
using System.Text;
using Sales_System;

namespace Sales_System
{
    public class Databases


    {
        SalesMan[] SalesMan = new SalesMan[30];
        int SalesManCount = 0;

        Product[] Products = new Product[30];
        int ProductCount = 0;

        Sale[] Sales = new Sale[30];
        int SalesCount = 0;

        public void AddSalesMan(SalesMan newSalesman)
        {
            SalesMan[SalesManCount] = newSalesman;
            SalesManCount++;
        }

        public void AddProduct(Product newProduct)
        {
            Products[ProductCount] = newProduct;
            ProductCount++;
        }
        public void AddSale(Sale newSale)
        {
            Sales[SalesCount] = newSale;
            SalesCount++;
        }
        // venta mas economica
       public void SaleEconomic()
        {
            int salepricetemp = this.Sales[0].price;
            string salenametemp = this.Sales[0].SalesMan;

            for (int i = 0; i < this.Sales.Length; i++)
            {
                if (this.Sales[i] != null)
                {
                    if (this.Sales[i].price < salepricetemp)
                    {
                        salepricetemp = this.Sales[i].price;
                        salenametemp = this.Sales[i].SalesMan;

                    }
                }
            }
            Console.WriteLine(" the SalesMan who sold the SaleEconomic was" + salenametemp);
        }

            //promedio 

        public void averagevalue()
        {
            int sumarypricetemp = 0;
            int amountpricetemp = 0;

            for (int i = 0; i < this.Products.Length; i++)
            {
                if (this.Products[i] != null)
                {
                    sumarypricetemp = sumarypricetemp + this.Products[i].productprice;
                    amountpricetemp++;
                }

            }

            Console.WriteLine("the average price is" + (sumarypricetemp / amountpricetemp));
        }
        //productos por unidad 
        public void Productforunit (string nameProduct)
        {
            int CountTemp = 0;
             
            for (int i = 0; i < this.Sales.Length; i++)
            {
                if (this.Sales[i] != null)
                {
                    if (this.Sales[i].Product == nameProduct)
                    {
                        CountTemp++;
                    }
                }

              
            }
                Console.WriteLine("product" + nameProduct + "mas vendido" + CountTemp);
        }

        public void expensiveproduct()
        {
            int productpriectemp = this.Products[0].productprice;
            string productnametemp = this.Products[0].productname;


            for (int i = 0; i < this.Products.Length; i++)
            {
                if (this.Products[i] != null)
                {
                    if (this.Products[i].productprice > productpriectemp)
                    {
                        productpriectemp = this.Products[i].productprice;
                        productnametemp = this.Products[i].productname;
                    }
                }
            }
            Console.WriteLine("the highest value product" + productnametemp + "worth" + productpriectemp);

        }

        

    }


}

