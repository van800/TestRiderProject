//using NUnit.Framework;
//
//namespace Editor
//{
//  public class EditModeTest1
//  {
//
//    [Test]
//    public void MyTest1()
//    {}
//    
//    [Test]
//    public void MyTest([Values(1, 2, 3)] int x)
//    {
//      // Use the Assert class to test conditions.
//if (x==3)
//      Assert.Fail("djsfhk");
//      
//    }
//    
//    // A UnityTest behaves like a coroutine in PlayMode
//    // and allows you to yield null to skip a frame in EditMode
//    [UnityEngine.TestTools.UnityTest]
//    public System.Collections.IEnumerator EditModeTest1WithEnueratorPasses()
//    {
//      // Use the Assert class to test conditions.
//      // yield to skip a frame
//      yield return null;
//    }
//  }
//}