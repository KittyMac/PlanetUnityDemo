
using UnityEngine;
using System.Collections.Generic;
using System;

public class Toy {
	string name;
	string image;
	string description;

	public Toy(string _name, string _image, string _description) {
		name = _name;
		image = _image;
		description = _description;
	}
}

public class ToyController : MonoBehaviour, IPUCode{

	public PUTable ToyTable;

	void Start () {
		List<object> myToys = new List<object> ();

		myToys.Add (new Toy ("Robot", "tables/robot", "This is a cool, cool robot!"));
		myToys.Add (new Toy ("Doll", "tables/doll", "This is a cool, cool doll!"));
		myToys.Add (new Toy ("Airplane", "tables/airplane", "This is a cool, cool airplane!"));
		myToys.Add (new Toy ("Robot", "tables/robot", "This is a cool, cool robot!"));
		myToys.Add (new Toy ("Doll", "tables/doll", "This is a cool, cool doll!"));
		myToys.Add (new Toy ("Airplane", "tables/airplane", "This is a cool, cool airplane!"));
		myToys.Add (new Toy ("Robot", "tables/robot", "This is a cool, cool robot!"));
		myToys.Add (new Toy ("Doll", "tables/doll", "This is a cool, cool doll!"));
		myToys.Add (new Toy ("Airplane", "tables/airplane", "This is a cool, cool airplane!"));
		myToys.Add (new Toy ("Robot", "tables/robot", "This is a cool, cool robot!"));
		myToys.Add (new Toy ("Doll", "tables/doll", "This is a cool, cool doll!"));
		myToys.Add (new Toy ("Airplane", "tables/airplane", "This is a cool, cool airplane!"));
		myToys.Add (new Toy ("Robot", "tables/robot", "This is a cool, cool robot!"));
		myToys.Add (new Toy ("Doll", "tables/doll", "This is a cool, cool doll!"));
		myToys.Add (new Toy ("Airplane", "tables/airplane", "This is a cool, cool airplane!"));
		myToys.Add (new Toy ("Robot", "tables/robot", "This is a cool, cool robot!"));
		myToys.Add (new Toy ("Doll", "tables/doll", "This is a cool, cool doll!"));
		myToys.Add (new Toy ("Airplane", "tables/airplane", "This is a cool, cool airplane!"));
		myToys.Add (new Toy ("Robot", "tables/robot", "This is a cool, cool robot!"));
		myToys.Add (new Toy ("Doll", "tables/doll", "This is a cool, cool doll!"));
		myToys.Add (new Toy ("Airplane", "tables/airplane", "This is a cool, cool airplane!"));
		myToys.Add (new Toy ("Robot", "tables/robot", "This is a cool, cool robot!"));
		myToys.Add (new Toy ("Doll", "tables/doll", "This is a cool, cool doll!"));
		myToys.Add (new Toy ("Airplane", "tables/airplane", "This is a cool, cool airplane!"));

		ToyTable.SetObjectList (myToys);
		ToyTable.ReloadTable ();
	}

}
