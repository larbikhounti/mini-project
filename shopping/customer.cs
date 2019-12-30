


using System;
using System.Globalization;
using System.Linq; 
using System.Collections.Generic;
namespace shopping {
    public class customer {
        public static long count ;
        public long Id { get; set; }
        public String Name { get; set; }
        public String Adress { get; set; }
        public String Email { get; set; }
        // orders with who order them
        public  List<orders> Order  = new List<orders>();
        // list of customers simple with out orders
        public  List<customer> Customers  = new List<customer>();
        //ctor 
        public customer()
        {
             
        }
        //ctor with paramitre
            public customer (String name, String adress, String email) {
            
            this.Name = name;
            this.Adress = adress;
            this.Email = email;
            this.Id = count++;
            
        
        }
       //add order
        public void AddOrder(orders order)
        {
            
          if(SearchOrder(order.Id)){ 
             System.Console.WriteLine("order existe");
            }else
            {
                Order.Add(order);
            }
           
        }
        // search order
         public bool SearchOrder(long Id)
         {
             foreach (var item in Order)
             {
                  if (item.Id == Id)
                  {
                      return true;
                  }
             }
             return false;
         }
        //delete order
        public void DeleteOrder(long Id)
        {
            if(SearchOrder(Id)){
           var itemToRemove = Order.Single(Order => Order.Id == Id);
           Order.Remove(itemToRemove);
           System.Console.WriteLine("Order is deleted");
            }
            else
            {
                System.Console.WriteLine("we don't fine the the order!");
            }
        }
        //show order
           public void ShowOrders()
        {
           
            if(Order != null){ 
            for(int i=0;i<Order.Count;i++)
            {
                System.Console.WriteLine( "order title :"+Order[i].Title);
                System.Console.WriteLine("order Description :"+Order[i].Description);
                System.Console.WriteLine("OrderDate :"+Order[i].OrderDate);
               
                   //List CustomerWithOrders always has index 0 
                    System.Console.WriteLine("costumer name :"+Order[i].CustomerWithOrders[0].Name); 
                  
            
                
            }
            }
        }

public  bool Equals(customer op)
 {
      if(op != null)
   {
      customer Op = op as customer;
     return this.Id == Op.Id; 
   }
    return false;
 }
    

    }
}