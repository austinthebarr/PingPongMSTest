using Microsoft.VisualStudio.TestTools.UnitTesting;
using PingPong;

namespace PingPong.Tests
{
  [TestClass]
  public class PingPongGeneratorTest
  {
    [TestMethod]
    public void IsPingPong_NumberDivisibleByThree_True()
    {
      PingPongGenerator testPingPong = new PingPongGenerator();
      Assert.AreEqual(true, testPingPong.IsPingPong(10));
    }

    [TestMethod]
    public void IsPingPong_NumberDivisibleByThree_False()
    {
      PingPongGenerator testPingPong = new PingPongGenerator();
      Assert.AreEqual(false, testPingPong.IsPingPong(5));
    }

    [TestMethod]
    public void IsPingPong_NumberDivisibleByFive_True()
    {
      PingPongGenerator testPingPong = new PingPongGenerator();
      Assert.AreEqual(true, testPingPong.IsPingPong(5));
    }

    [TestMethod]
    public void IsPingPong_NumberDivisibleByThreeAndFive_True()
    {
      PingPongGenerator testPingPong = new PingPongGenerator();
      Assert.AreEqual(true, testPingPong.IsPingPong(15));
    }

    [TestMethod]
    public void PrintOutNumberList()
    {
      PingPongCounter testPingPong = new PingPongCounter();

    }

  }
}
