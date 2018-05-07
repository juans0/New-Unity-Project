using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MensajePantalla : MonoBehaviour {

	public string mensaje = "Encuentra la llave" ;
	public bool toca = false;

	// Update is called once per frame
	void Update () {
		
	}

	void OnGUI() {
		GUIStyle tamLetra = new GUIStyle (GUI.skin.button);
		tamLetra.fontSize = 30;

		if (toca)
			GUI.Label (new Rect (Screen.width / 2 - 100, Screen.height / 2, 300, 50), mensaje, tamLetra);
	}

	void OnTriggerEnter() {
		toca = true;
	}

	void OnTriggerExit() {
		toca = false;
	}

}
