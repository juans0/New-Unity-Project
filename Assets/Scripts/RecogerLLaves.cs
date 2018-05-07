using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecogerLLaves : MonoBehaviour {


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//if (llaves == 1)
			//Debug.Log (llaves);
	}

	public int llaves = 0;

	void OnTriggerEnter(Collider jugador) {
		if (jugador.GetComponent<Collider> ().tag == "llave") {
			llaves++;
			Destroy (jugador.gameObject);
		}

	}		
}
