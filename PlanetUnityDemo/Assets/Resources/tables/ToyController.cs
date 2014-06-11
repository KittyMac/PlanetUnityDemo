
using UnityEngine;
using System.Collections.Generic;
using System;

public class Toy {
	public string name;
	public string image;
	public string description;

	public Toy(string _name, string _image, string _description) {
		name = _name;
		image = _image;
		description = _description;
	}
}

public class ToyController : MonoBehaviour, IPUCode{

	public PUTable ToyTable;

	string randomLoremIpsum()
	{
		string lorem = "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.";
		int length = UnityEngine.Random.Range (0, lorem.Length - 20);
		return lorem.Substring (0, 20 + length);
	}

	void Start () {
		List<object> myToys = new List<object> ();

		myToys.Add (new Toy ("Robot", "tables/robot", randomLoremIpsum()));
		myToys.Add (new Toy ("Doll", "tables/doll", randomLoremIpsum()));
		myToys.Add (new Toy ("Airplane", "tables/airplane", randomLoremIpsum()));
		myToys.Add (new Toy ("Robot", "tables/robot", randomLoremIpsum()));
		myToys.Add (new Toy ("Doll", "tables/doll", randomLoremIpsum()));
		myToys.Add (new Toy ("Airplane", "tables/airplane", randomLoremIpsum()));
		myToys.Add (new Toy ("Robot", "tables/robot", randomLoremIpsum()));
		myToys.Add (new Toy ("Doll", "tables/doll", randomLoremIpsum()));
		myToys.Add (new Toy ("Airplane", "tables/airplane", randomLoremIpsum()));
		myToys.Add (new Toy ("Robot", "tables/robot", randomLoremIpsum()));
		myToys.Add (new Toy ("Doll", "tables/doll", randomLoremIpsum()));
		myToys.Add (new Toy ("Airplane", "tables/airplane", randomLoremIpsum()));
		myToys.Add (new Toy ("Robot", "tables/robot", randomLoremIpsum()));
		myToys.Add (new Toy ("Doll", "tables/doll", randomLoremIpsum()));
		myToys.Add (new Toy ("Airplane", "tables/airplane", randomLoremIpsum()));
		myToys.Add (new Toy ("Robot", "tables/robot", randomLoremIpsum()));
		myToys.Add (new Toy ("Doll", "tables/doll", randomLoremIpsum()));
		myToys.Add (new Toy ("Airplane", "tables/airplane", randomLoremIpsum()));
		myToys.Add (new Toy ("Robot", "tables/robot", randomLoremIpsum()));
		myToys.Add (new Toy ("Doll", "tables/doll", randomLoremIpsum()));
		myToys.Add (new Toy ("Airplane", "tables/airplane", randomLoremIpsum()));
		myToys.Add (new Toy ("Robot", "tables/robot", randomLoremIpsum()));
		myToys.Add (new Toy ("Doll", "tables/doll", randomLoremIpsum()));
		myToys.Add (new Toy ("Airplane", "tables/airplane", randomLoremIpsum()));

		ToyTable.SetObjectList (myToys);
		ToyTable.ReloadTable ();
	}

}
