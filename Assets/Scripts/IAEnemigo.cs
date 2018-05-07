using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class IAEnemigo : MonoBehaviour {

	/*public int estado;
	public AnimationClip atacar;
	public AnimationClip correr;
	public AnimationClip gritar;
	public AnimationClip andar;
*/
	public Animator anim;
	public Transform jugador;
	public Transform punto;
	public NavMeshAgent nav;
	public bool ataque;
	public CharacterController caractContr;
	public float distancia;


	// Use this for initialization
	void Start () {
		//jugador = GameObject.FindGameObjectWithTag ("Player").transform;
		//nav.GetComponent<NavMeshAgent> ();
		caractContr.enabled = true;
		ataque = false;
	}
	
	// Update is called once per frame
	void Update () {

		distancia = Vector3.Distance (transform.position, jugador.position);

		//Ver y seguir al jugador
		if (distancia < 5) {
			anim.SetBool ("enemigoCorre", true);
			nav.SetDestination(jugador.transform.position);
		} else {
			nav.SetDestination (punto.position);
		}
		//Atacar al jugador
		if (distancia < nav.stoppingDistance && ataque == false) {
			anim.SetBool ("enemigoAtaca", true);
			Invoke ("atacar", 1.1f); //invoca el método atacar en 1.1 segundos 
			ataque = true;
		}
		/*if (estado == 0) {
			GetComponent<Animation>().Play (atacar.name);
		}
		if (estado == 1) {
			transform.LookAt (jugador);
			GetComponent<Animation>().Play (correr.name);

		}
		if (estado == 2) {
			GetComponent<Animation>().Play (gritar.name);

		}
		if (estado == 3) {
			GetComponent<Animation>().Play (andar.name);
			transform.Translate (new Vector3 (0, 0, 1) * Time.deltaTime);
		}

		nav.SetDestination (jugador.position);*/
	}

	void atacar() {
		Invoke ("cambioAtaque", 1.5f);
		if (distancia <= 4 && ataque == true)
			SceneManager.LoadScene("menuPrincipal");
	}

	void cambioAtaque(){
		ataque = false;
	}
}
