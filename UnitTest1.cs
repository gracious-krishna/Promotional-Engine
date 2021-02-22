using NUnit.Framework;
using PromotionalEngine.Core;

namespace Promotional_Engine
{
  public class Tests
  {
    private Cart CartScenario1 { get; set; }
    private Cart CartScenario2 { get; set; }
    private Cart CartScenario3 { get; set; }

    [SetUp]
    public void Setup()
    {
      CartScenario1 = new Cart();
      CartScenario2 = new Cart();
      CartScenario3 = new Cart();

      var a = new Item("A", 50);
      var b = new Item("B", 30);
      var c = new Item("C", 20);
      var d = new Item("D", 15);

      var promotion1 = new PriceForQuantityPromotion(a, 3, 130);
      var promotion2 = new PriceForQuantityPromotion(b, 2, 45);
      var promotion3 = new ComboPromotion(new List<Tuple<Item, int>> { Tuple.Create(c, 1), Tuple.Create(d, 1) }, 30);

      var promotions = new List<Promotion>() { promotion1, promotion2, promotion3 };
      CartScenario1.AddPromotions(promotions);
      CartScenario2.AddPromotions(promotions);
      CartScenario3.AddPromotions(promotions);

      CartScenario1.AddItem(new CartItem(a, 1));
      CartScenario1.AddItem(new CartItem(b, 1));
      CartScenario1.AddItem(new CartItem(c, 1));

      CartScenario2.AddItem(new CartItem(a, 5));
      CartScenario2.AddItem(new CartItem(b, 5));
      CartScenario2.AddItem(new CartItem(c, 1));

      CartScenario3.AddItem(new CartItem(a, 3));
      CartScenario3.AddItem(new CartItem(b, 5));
      CartScenario3.AddItem(new CartItem(c, 1));
      CartScenario3.AddItem(new CartItem(d, 1));
    }

    [Test]
    public void Test1()
    {
      Assert.True(CartScenario1.Total == 100);
      Assert.True(CartScenario1.Total == 370);
      Assert.True(CartScenario1.Total == 280);

      Assert.Pass();
    }
  }
}