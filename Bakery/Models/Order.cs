using System.Collections.Generic;

namespace Bakery.Models
{
    public class Order
    {
      public string Title { get; set; } 
      public string Description { get; set; }
      public float Price { get; set; }

      // Add a Date field here 

      public int Id { get; }
      private static List<Order> _orders = new List<Order> {};

      public Order(string title, string description, float price)
      {
          Title = title;
          Description = description;
          Price = price;
          _orders.Add(this);
          Id = _orders.Count;
          // Add date to the constructor, and a date argument
      }

      public static Order Find(int searchId)
      {
        return _orders[searchId- 1];
      }

      public static List<Order> GetAll()
      {
        return _orders;
      }

    }
}