using System.Collections.Generic;
using NUnit.Framework;

namespace Editor
{
  [TestFixture]
  public class SimpleTests
  {
  
    [TestCase(1)]
    [TestCase(2)]
    public void TestC11(int i)
    {
      Assert.AreEqual(i, 1);
    }

   
    [Test]
    public void Test()
    {}
    
    // All values of MyEnum that should result in true
    public static IEnumerable<int> MyTrueEnumDataSource
    {
      
      
      get
      {
        yield return 1;
        yield return 2;
        yield return 3;
      }
    }
    
    [Test]
    public void MethodReturnsTrueForAllEnums(
      [ValueSource("MyTrueEnumDataSource")]int i)
    {
      Assert.IsTrue(i==3);
    }

  }
}