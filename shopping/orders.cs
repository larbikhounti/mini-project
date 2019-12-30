using System.Runtime.InteropServices;
using System.ComponentModel.DataAnnotations;
using System;
using System.Reflection.Emit;
using System.Collections.Generic;
namespace shopping {
    public class orders {
        private  static long count;
        public long Id { get; set; }
        public String Title { get; set; }
        public String Description { get; set; }
        public DateTime OrderDate;
        public List<customer> CustomerWithOrders = new List<customer>() ;
            public orders (customer customer, String title, String description,DateTime orderdate) {
            this.Id = count++;
            this.Title = title;
            this.Description = description;
            this.OrderDate = orderdate;
            CustomerWithOrders.Add(customer);
        }
 
       

      
      public  bool Equals(orders op)
      {
      if(op != null)
      {
         orders Op = op as orders;
          return this.Id == op.Id; 
      }
       return false;
      }
      
    }
}