using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotacionLLave : MonoBehaviour {
    
    public Transform referente; // El objeto sobre el que vamos a girar
    public int velocidad = 1; // La velocidad de rotación

	// Use this for initialization
	void Start () {
        if (referente == null) {            
			referente = this.gameObject.transform; //En el caso de que no tengamos un Referente cogemos el mismo objeto          
        }
    }
	
	// Update is called once per frame
	void Update () {        
        //- 1. posición sobre la que se rota. - 2. eje sobre el que rota. - 3. velocidad de rotación         
        transform.RotateAround(referente.transform.position, referente.transform.up, velocidad * Time.deltaTime);   
    }
}
