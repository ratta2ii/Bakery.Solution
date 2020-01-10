using System.Collections.Generic;

namespace Bakery.Models;
{
    public class Order
    {
      public string Title { get; set; } 
      public string Description { get; set; }
      public float Price { get; set; }

      // Create a date field to go into the constructor 
      public Order(string title, string description, float price)
      {
          Title = title;
          Description = description;
          Price = price;
          // Add date to the constructor, and a date argument
      }
    }
}