
using UnityEngine;
using System.Collections.Generic;
using System;

public class DemoHeaderTableCell : PUTableCell {

	public PULabel Name;

	public override bool IsHeader() {
		return true;
	}

	public override string XmlPath() {
		return "menu/demoHeader";
	}

	public override void LoadIntoPUGameObject(PUTable parent, object data, int baseRenderQueue)
	{
		DemoHeader info = data as DemoHeader;

		// call the base method to have it load all of our PlanetUnity stuff
		base.LoadIntoPUGameObject(parent, data, baseRenderQueue);

		// Now everything is defined, we can fill in the data for our cell as we see fit
		Name.LoadTextString (info.name);
	}
}
