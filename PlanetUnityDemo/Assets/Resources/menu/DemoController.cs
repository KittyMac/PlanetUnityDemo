
using UnityEngine;
using System.Collections.Generic;
using System;

public class DemoHeader {
	public string name;

	public DemoHeader(string _name) {
		name = _name;
	}
}

public class Demo {
	public string name;
	public string scene;

	public Demo(string _name, string _scene) {
		name = _name;
		scene = _scene;
	}
}

public class DemoController : MonoBehaviour, IPUCode{

	public PUTable DemoTable;

	void Start () {
		List<object> myDemos = new List<object> ();

		myDemos.Add (new DemoHeader ("Planet Unity Demo"));
		myDemos.Add (new Demo ("Image", "image/main"));
		myDemos.Add (new Demo ("Text", "text/main"));
		myDemos.Add (new Demo ("Dynamic", "dynamic/main"));
		myDemos.Add (new Demo ("Masking", "masking/main"));
		myDemos.Add (new Demo ("Scrolling", "scrolling/main"));
		myDemos.Add (new Demo ("Table", "tables/main"));

		DemoTable.SetObjectList (myDemos);
		DemoTable.ReloadTable ();
	}

	public void GoToDemo() {
		Debug.Log ("DemoController: GoToDemo");
	}
}
