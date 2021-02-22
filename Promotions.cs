using System;
using System.Collections.Generic;

namespace PromotionalEngine.Core
{
  public class Promotion
  {
    public PromotionType Type { get; set; }
  }

  public class PriceForQuantityPromotion : Promotion
  {
    public Item Item { get; set; }
    public int Quantity { get; set; }
    public decimal Total { get; set; }
    public PriceForQuantityPromotion(Item item, int quantity, decimal total)
    {
      Item = item;
      Quantity = quantity;
      Total = total;
      Type = PromotionType.PriceForQuantityPromotion;
    }
  }
  
  public enum PromotionType
  {
    PriceForQuantityPromotion = 1,
    ComboPromotion = 2
  }
}