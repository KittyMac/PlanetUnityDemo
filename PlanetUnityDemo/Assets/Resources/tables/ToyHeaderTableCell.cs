
using UnityEngine;
using System.Collections.Generic;
using System;

public class ToyHeaderTableCell : PUTableCell {

	public PULabel ToyName;

	public override bool IsHeader() {
		return true;
	}

	public override string XmlPath() {
		return "tables/toyHeader";
	}

	public override void LoadIntoPUGameObject(PUTable parent, object data, int baseRenderQueue)
	{
		ToyHeader info = data as ToyHeader;

		// call the base method to have it load all of our PlanetUnity stuff
		base.LoadIntoPUGameObject(parent, data, baseRenderQueue);

		// Now everything is defined, we can fill in the data for our cell as we see fit
		ToyName.LoadTextString (info.name);
	}
}
