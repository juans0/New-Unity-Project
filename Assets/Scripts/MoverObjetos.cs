using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverObjetos : MonoBehaviour {

	public float potencia;

	void OnControllerColliderHit(ControllerColliderHit jugador){
		potencia = 1;
		Rigidbody roca = jugador.collider.attachedRigidbody;
		Vector3 direccion = new Vector3 (jugador.moveDirection.x, 0, jugador.moveDirection.z);

		roca.velocity = direccion * potencia / roca.mass;
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
