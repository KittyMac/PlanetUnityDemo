
using UnityEngine;
using System.Collections.Generic;
using System;

public class DemoTableCell : PUTableCell {

	public PULabelButton Name;

	public override string XmlPath() {
		return "menu/demo";
	}

	public override void LoadIntoPUGameObject(PUTable parent, object data, int baseRenderQueue)
	{
		Demo info = data as Demo;

		// call the base method to have it load all of our PlanetUnity stuff
		base.LoadIntoPUGameObject(parent, data, baseRenderQueue);

		// We're going to pass the information we want through the entity tag
		Name.tag = info.scene;

		// Now everything is defined, we can fill in the data for our cell as we see fit
		Name.LoadTextString (info.name);
	}
}
