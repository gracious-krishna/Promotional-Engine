using System;
using System.Collections.Generic;
using System.Text;

namespace PromotionalEngine.Core
{
  public class Item
  {
    public string SKU { get; set; }
    public decimal Price { get; set; }
    public Item(string sku, decimal price)
    {
      SKU = sku;
      Price = price;
    }
  }
}
