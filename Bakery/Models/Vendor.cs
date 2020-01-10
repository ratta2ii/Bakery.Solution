using System.Collections.Generic;

namespace Bakery.Models
{
    public class Vendor
    {
       public string Name { get; set; }
       public string Description { get; set; }
       public static List<Order> orders = new List<Order> { } ;  

       public Vendor(string name, string description)
       {
           Name = name;
           Description = description;
           // Need to add Order List in the constructor 
       }


    }
}