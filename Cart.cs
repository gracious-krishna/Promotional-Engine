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
    {}
  }
}