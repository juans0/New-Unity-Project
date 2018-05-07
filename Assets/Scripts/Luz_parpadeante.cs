using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Luz_parpadeante : MonoBehaviour {

	public float parpadeo = 0.1f;
	public float intensidad = 0.1f;
	private int randome = 0;

	// Use this for initialization
	IEnumerator Start () {
		while (true) {
			if (randome == 0)
				intensidad += 3;
			else 				
				intensidad = 0.1f;			
			randome = Random.Range(0, 11);
			yield return new WaitForSeconds (intensidad);
		}
	}
	

}
