
using UnityEngine;
using System.Collections.Generic;
using System;

public class ToyTableCell : PUTableCell {

	public PULabel ToyName;
	public PULabel ToyDesc;
	public PUImage ToyIcon;

	public override string XmlPath() {
		return "tables/toy";
	}

	public override void LoadIntoPUGameObject(PUGameObject parent, object data, int baseRenderQueue)
	{
		Toy info = data as Toy;

		// call the base method to have it load all of our PlanetUnity stuff
		base.LoadIntoPUGameObject(parent, data, baseRenderQueue);

		// Now everything is defined, we can fill in the data for our cell as we see fit
		ToyName.LoadTextString (info.name);
		ToyDesc.LoadTextString (info.description);
		ToyIcon.LoadImageResource (info.image);
	}
}
