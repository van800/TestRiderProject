using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
  void Update()
  {
    Debug.Log("Play");
    for (int i = 0; i < 900; i++)
    {
      new Thread(() =>
      {
        Thread.CurrentThread.IsBackground = true;
        /* run your code here */


        Debug.Log("Hello, world" + i);


      }).Start();
    }
    Debug.Log("Hello, world");
  }
}
