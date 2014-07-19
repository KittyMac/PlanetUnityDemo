
using UnityEngine;
using System.Collections.Generic;
using System;
using System.Collections;

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
		myDemos.Add (new Demo ("Image", "images"));
		myDemos.Add (new Demo ("Text", "text"));
		myDemos.Add (new Demo ("Dynamic", "dynamic"));
		myDemos.Add (new Demo ("Masking", "masking"));
		myDemos.Add (new Demo ("Scrolling", "scrolling"));
		myDemos.Add (new Demo ("Table", "tables"));

		if (DemoTable != null) {
			DemoTable.SetObjectList (myDemos);
			DemoTable.ReloadTable ();
		}
	}

	public void GoToDemo(Hashtable args) {
		PUGameObject sender = (PUGameObject)args ["sender"];
		string levelToLoad = sender.tag;
		Application.LoadLevel (levelToLoad);
	}

	public void GoToMenu() {
		Application.LoadLevel ("menu");
	}
}
