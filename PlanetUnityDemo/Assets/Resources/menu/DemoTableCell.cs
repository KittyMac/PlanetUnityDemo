
using UnityEngine;
using System.Collections.Generic;
using System;

public class DemoTableCell : PUTableCell {

	public PULabel Name;

	public override string XmlPath() {
		return "menu/demo";
	}

	public override void LoadIntoPUGameObject(PUTable parent, object data, int baseRenderQueue)
	{
		Demo info = data as Demo;

		// call the base method to have it load all of our PlanetUnity stuff
		base.LoadIntoPUGameObject(parent, data, baseRenderQueue);

		// Now everything is defined, we can fill in the data for our cell as we see fit
		Name.LoadTextString (info.name);

		// We have some special code to run when a button is pressed in me
		NotificationCenter.addObserver (this, "GoToDemo", puGameObject, (args,name) => {
			Debug.Log ("TableCell: GoToDemo");
		});
	}

}
