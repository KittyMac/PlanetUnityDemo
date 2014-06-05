using UnityEngine;
using System.Collections;

public class PlanetUnityDynamicExample : MonoBehaviour {

	// Use this for initialization
	void Start () {

		// Create some stuff programatically.
		cColor red = new cColor (1, 0, 0, 1);
		cColor blue = new cColor (0, 0, 1, 1);

		for (int i = -10; i < 10; i++) {
			for (int j = -10; j < 10; j++) {
				cColor color = red;

				if ((i & 1) == 0) {
					if ((j & 1) == 0) {
						color = blue;
					}
				} else {
					if ((j & 1) != 0) {
						color = blue;
					}
				}

				PUColor depthMask2 = new PUColor (null, color, new cVector2 (0, 0), new cRect (-50+(i*100), -50+(j*100), 100, 100));
				if(color == blue)
					depthMask2.SetTitle ("Blue Color");
				else
					depthMask2.SetTitle ("Red Color");
				depthMask2.loadIntoGameObject (gameObject);
			}
		}




	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
