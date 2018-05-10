//using System;
//using UnityEngine;
//using UnityEditor;
//using UnityEngine.TestTools;
//using NUnit.Framework;
//using System.Collections;
//
//using System.Threading;
//using UGS.vrtoy.toys.orrery;
//
//public class StarTest {
//
//	[Test]
//	public void sector00() {
//	  Debug.Log("sectorX" + DateTime.UtcNow);
//	  var t = new Thread(() =>
//	  {
//	    Debug.Log("sectorXS" + DateTime.UtcNow);  
//	  });
//	  t.Start();
//		NUnit.Framework.Assert.That(new Star(){ RA = 0f, Dec = 0f }.sectorNum, Is.EqualTo(0));
//	}
//
//	[Datapoints]
//	public StarTest.D1[] testData = {
//		new D1{ RA =  0f, Dec =   0f, expectedSector = 0 },
//		new D1{ RA =  1f, Dec =   1f, expectedSector = 0 },
//		new D1{ RA =  7f, Dec =   0f, expectedSector = 0 },
////		new D1{ RA =  8f, Dec =   0f, expectedSector = 0 },
////		new D1{ RA =  9f, Dec =   0f, expectedSector = 0 },
////		new D1{ RA = 11f, Dec =   0f, expectedSector = 0 },
////		new D1{ RA = 12f, Dec =   0f, expectedSector = 0 },
////		new D1{ RA = 13f, Dec =   0f, expectedSector = 0 },
////		new D1{ RA = 15f, Dec =   0f, expectedSector = 0 },
////		new D1{ RA = 16f, Dec =   0f, expectedSector = 0 },
////		new D1{ RA = 17f, Dec =   0f, expectedSector = 0 },
////		new D1{ RA = 23f, Dec =   0f, expectedSector = 0 },
////		new D1{ RA = 24f, Dec =   0f, expectedSector = 0 },
//
////		new D{ RA =  0f, Dec =   1f, expectedSector = 0 },
////		new D{ RA =  0f, Dec =  -1f, expectedSector = 0 },
////		new D{ RA =  0f, Dec =  44f, expectedSector = 0 },
////		new D{ RA =  0f, Dec =  45f, expectedSector = 0 },
////		new D{ RA =  0f, Dec =  46f, expectedSector = 0 },
////		new D{ RA =  0f, Dec =  89f, expectedSector = 0 },
////		new D{ RA =  0f, Dec =  90f, expectedSector = 0 },
////		new D{ RA =  0f, Dec = -44f, expectedSector = 0 },
////		new D{ RA =  0f, Dec = -45f, expectedSector = 0 },
////		new D{ RA =  0f, Dec = -46f, expectedSector = 0 },
////		new D{ RA =  0f, Dec = -89f, expectedSector = 0 },
////		new D{ RA =  0f, Dec = -92f, expectedSector = 0 },
//	};
//
//	public class D1 {
//		public float RA, Dec;
//		public int expectedSector;
//
//		public override string ToString() {
//			return string.Format("RA:{0}, Dec:{1}, expectedSector:{2}", RA, Dec, expectedSector);
//		}
//	}
//
//  [TestCase(1)]
//  [TestCase(2)]
//  public void TestC11(int i)
//  {
//    Assert.AreEqual(i, 1);
//  }
//
//	[Theory]
//	public void theory(D1 d) {
//	  Assert.That(new Star(){ RA = d.RA, Dec = d.Dec }.sectorNum, Is.EqualTo(d.expectedSector));
//	}
//	
//  static readonly Vector3[] s_RightOffsetRotatedValidPoints = 
//  {
//    new Vector3(-2,  2,1),
//    new Vector3(-2,  4,1),
//    new Vector3(-5,  3,1),
//    new Vector3( 0,  0,1),
//    new Vector3( 1,  0,1),
//    new Vector3(-4,  2,1),
//  };
//  static readonly Vector3[] s_LeftOffsetRotatedValidPoints = 
//  {
//    new Vector3(-2,  2,1),
//    new Vector3(-2,  4), 
//    new Vector3(-5,  3),
//    new Vector3( 0,  0),
//    new Vector3( 1,  0),
//    new Vector3(-4,  2, 1),
//  };
//  
//	[Test, Sequential]
//  		public void Left120OffsetRotateTest(
//  			[ValueSource("s_RightOffsetRotatedValidPoints")] Vector3 source, 
//  			[ValueSource("s_LeftOffsetRotatedValidPoints")] Vector3 expected)
//  		{
//  			
//  			Assert.AreEqual(source, expected);
//  		}
//
//}
