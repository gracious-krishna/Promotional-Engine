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

    public void AddItem(CartItem item)
    {
      Items.Add(item);
      CalculateTotal();
    }
    public void AddPromotion(Promotion promo)
    {
      Promotions.Add(promo);
      CalculateTotal();
    }
    public void AddPromotions(List<Promotion> promos)
    {
      Promotions.AddRange(promos);
      CalculateTotal();
    }

    private void CalculateTotal()
    {
      if (Promotions.Any())
      {
        Total = 0;
        var itemUsedForPromotions = new List<string>();
        foreach (var promo in Promotions)
        {
          if (promo.Type == PromotionType.PriceForQuantityPromotion)
          {
            var promoType = (PriceForQuantityPromotion)promo;
            var item = promoType.Item;

            var cartItem = Items.FirstOrDefault(x => x.Item.SKU == item.SKU);
            if (cartItem == null) continue;

            var totalQuantity = Items.Where(x => x.Item.SKU == item.SKU).Sum(x => x.Quantity);
            var qualifiedQty = totalQuantity % promoType.Quantity;
            Total = qualifiedQty * promoType.Total + (totalQuantity - (qualifiedQty * promoType.Quantity)) * cartItem.Item.Price;
            itemUsedForPromotions.Add(cartItem.Item.SKU);
          }
        }

        //Add another promotion type here.

        var nonUsedItems = Items.Where(x => !itemUsedForPromotions.Contains(x.Item.SKU));
        foreach (var nonUsedItem in nonUsedItems)
        {
          Total += nonUsedItem.Item.Price * nonUsedItem.Quantity;
        }
      }

      else
      {
        Total = Items.Sum(x => x.Item.Price * x.Quantity);
      }
    }
  }
}