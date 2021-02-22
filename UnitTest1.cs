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
    }

    [Test]
    public void Test1()
    {
      Assert.Pass();
    }
  }
}