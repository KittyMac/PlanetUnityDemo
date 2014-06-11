
using UnityEngine;
using System.Collections.Generic;
using System;

public class ToyTableCell : PUTableCell {

	public PULabel ToyName;
	public PULabel ToyDesc;
	public PUImage ToyIcon;
	public PUColor Line;

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

		// Wouldn't it be cool to support multiple row heights?  Its easier than you'd think.
		// Just remember at this level we're in unity coords, so 0 is the bottom of the cell.
		puGameObject.bounds.h = ToyDesc.textMesh.renderer.bounds.size.y + ( puGameObject.bounds.h - ToyDesc.bounds.y );

		// We want the line to attach to the bottom of the cell
		Vector2 pos = Line.gameObject.transform.localPosition;
		pos.y -= ToyDesc.textMesh.renderer.bounds.size.y ;
		Line.gameObject.transform.localPosition = pos;
	}
}
