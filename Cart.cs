using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PromotionalEngine.Core
{
  public class Cart
  {
    public Cart()
    {
      this.Items = new List<CartItem>();
      this.Promotions = new List<Promotion>();
    }
    public List<CartItem> Items { get; set; }
    public List<Promotion> Promotions { get; set; }
    public decimal Total { get; set; }

    
  }
}