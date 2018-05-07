using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivarPuerta : MonoBehaviour {
	public GameObject puertaAbatible;
	public GameObject puertaFija;
	public GameObject mensaje;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(){
		puertaFija.SetActive (false);
		puertaAbatible.SetActive (true);
		mensaje.SetActive (false);
	}
}
