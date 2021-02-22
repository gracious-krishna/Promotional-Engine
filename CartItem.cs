using System;

namespace PromotionalEngine.Core
{
  public class CartItem
  {
    public Item Item { get; set; }
    public int Quantity { get; set; }
    public CartItem(Item item, int quantity)
    {
      Item = item;
      Quantity = quantity;
    }
  }
}