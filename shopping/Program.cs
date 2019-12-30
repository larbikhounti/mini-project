using System.Runtime.CompilerServices;
using System;

namespace shopping
{
    public class Program 
    {
        static void Main(string[] args)
        {
            // create a costumer
            customer c1 = new customer("mohamed","hay bouhout 1 rue 16 n 23","larbo@gmail.com");
            customer c2 = new customer("khalid","hay bouhout 1 rue 16 n 23","larbo@gmail.com");
            //create an order
            orders o1 = new orders(c1,"pizza","pizza margarita",DateTime.Now);
            orders o2 = new orders(c2,"pepsi","pespi no sugar",DateTime.Now);
            orders o3 = new orders(c2,"haski","hot haski",DateTime.Now);
            //show how many customers with order
            System.Console.WriteLine("CustomerWithOrders : "+o1.CustomerWithOrders.Count );

             //add the order to client
            c1.AddOrder(o1);
            c1.AddOrder(o2);
            c1.AddOrder(o3);
            //search order by Id
           // System.Console.WriteLine("is it exist  ? : " + c1.SearchOrder(0).ToString());

           // Delete order by Id
           //c1.DeleteOrder(o3.Id);
         
            //show order
           c1.ShowOrders();
           
            // show how many orders
          // System.Console.WriteLine("orders count : " + c1.Order.Count);
           // show how many customers
          // System.Console.WriteLine("customers : " + count);
             
        }
    }
}
