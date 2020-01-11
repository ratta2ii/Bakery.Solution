using System.Collections.Generic;
using System;


namespace Bakery.Models
{
    public class Order
  {
    public string Title { get; set; } 
    public string Description { get; set; }
    public float Price { get; set; }
    public string Date { get; set; }
    public int Id { get; }
    private static List<Order> _orders = new List<Order> {};

    public Order(string title, string description, float price)
    {
      Title = title;
      Description = description;
      Price = price;
      Date = DateTime.Now.ToString("MM-dd-yyyy");
      _orders.Add(this);
      Id = _orders.Count;
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