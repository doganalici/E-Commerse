using System;

namespace E_Commerse
{
    class Program
    {
        static void Main(string[] args)
        {
            Trade product1 = new Trade();
            product1.product_Id = 15;
            product1.product_Name = "T-shirt";
            product1.product_Category = "Clothing";
            product1.product_Stock = 78;
            product1.product_Price = 44.90;

            Trade product2 = new Trade();
            product2.product_Id = 22;
            product2.product_Name = "Sandals";
            product2.product_Category = "Shoe";
            product2.product_Stock = 51;
            product2.product_Price = 34.50;

            Trade product3 = new Trade();
            product3.product_Id = 41;
            product3.product_Name = "Sweater";
            product3.product_Category = "Clothing";
            product3.product_Stock = 30;
            product3.product_Price = 69.90;

            Trade product4 = new Trade();
            product4.product_Id = 71;
            product4.product_Name = "Wristband";
            product4.product_Category = "Accessory";
            product4.product_Stock = 13;
            product4.product_Price = 10;

            Trade[] product = new Trade[] { product1, product2, product3, product4 };
            Console.WriteLine("Product1 => Product Name : {0}", product1.product_Name);
            Console.WriteLine();
            Console.WriteLine("--------Foreach Loop--------- \n");
            foreach (Trade trade in product)
            {
                Console.WriteLine("\n" + "Product Id : " + trade.product_Id + " / Product Name : " + trade.product_Name +
                                 " / Product Category : " + trade.product_Category + " / Product Stock : " + trade.product_Stock +
                                 " / Product Pride : " + trade.product_Price + " $");
            }
            Console.WriteLine("\n \n \n");
            Console.WriteLine("--------For Loop---------\n");
            for (int i = 0; i < product.Length; i++)
            {
                Console.WriteLine("Product Id : " + product[i].product_Id);
                Console.WriteLine("Produck Name : " + product[i].product_Name);
                Console.WriteLine("Product Category : " + product[i].product_Category);
                Console.WriteLine("Product Stock : " + product[i].product_Stock);
                Console.WriteLine("Product Price : " + product[i].product_Price + " $");
                Console.WriteLine();
            }
            Console.WriteLine("\n \n \n");
            Console.WriteLine("--------While Loop---------\n");

            int x = 0;
            while (x < product.Length)
            {
                Console.WriteLine("Product Id : " + product[x].product_Id);
                Console.WriteLine("Produck Name : " + product[x].product_Name);
                Console.WriteLine("Product Category : " + product[x].product_Category);
                Console.WriteLine("Product Stock : " + product[x].product_Stock);
                Console.WriteLine("Product Price : " + product[x].product_Price + " $");
                x++;
                Console.WriteLine();
            }
        }
    }

}
