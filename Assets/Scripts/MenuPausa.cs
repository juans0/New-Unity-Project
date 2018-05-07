using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPausa : MonoBehaviour {

	//public string menuPrincipal;
	private bool pausaActiva = false;
	//public GUISkin 


	// Use this for initialization
	void Start () {
		pausaActiva = false;
		//Cursor.visible = false;
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown("p")) {
			if (pausaActiva == false) {
				pausaActiva = true;
				//Cursor.visible = true;
			}
		}
	}

	void OnGUI() {
		if (pausaActiva == true) {
			//Vuelve al juego
			if (GUI.Button (new Rect (Screen.width / 2 - 150, Screen.height / 2 - 110, 250, 50), "Resumen")) {
				if (pausaActiva == true) {
					pausaActiva = false;
					//Cursor.visible = false;
				}
			}
			// volver a menu principal
			if(GUI.Button(new Rect(Screen.width /2 - 150,Screen.height /2 - 10,250,50), "Volver al menu principal" )){
				SceneManager.LoadScene("menuPrincipal");
			}
			// salir del juego
			if (GUI.Button (new Rect (Screen.width /2 - 150,Screen.height /2 +40,250,50), "Salir del juego")){
				Application.Quit();
			}
		}
	}	
}
