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

  public class ComboPromotion : Promotion
  {
    public List<Tuple<Item, int>> ItemAndQuantity { get; set; }
    public decimal Total { get; set; }
    public ComboPromotion(List<Tuple<Item, int>> items, decimal total)
    {
      ItemAndQuantity = items;
      Total = total;
      Type = PromotionType.ComboPromotion;
    }
  }

  public enum PromotionType
  {
    PriceForQuantityPromotion = 1,
    ComboPromotion = 2
  }
}