using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SampleLibrary.Test
{
  [TestClass]
  public class SampleTest
  {
    [TestMethod]
    public void TestSay()
    {
      var sample = new Sample();
      Assert.AreEqual("Hello TDD Boot Camp!", sample.Say());
    }
  }
}
