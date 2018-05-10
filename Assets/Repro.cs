using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEditor;
using UnityEngine;

[InitializeOnLoad]
public static class Repro{

  static Repro()
  {
    
    int i = 0;
    EditorApplication.update+= () =>
    {
//      i++;
//
//      if (i == 10)
//      {
//        Debug.Log("main" + DateTime.UtcNow);
//        var t1 = new Thread(() => { Debug.Log("thread" + DateTime.UtcNow); });
//        var t = t1;
//        t.Start();
//      }
//
//      for (int j = 0; j < 900; j++)
//      {
//        Debug.Log("Update "+i);  
//      }
    };
  }

}
