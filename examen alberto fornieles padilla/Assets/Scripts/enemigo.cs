using UnityEngine;
using System.Collections;

public class enemigo : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	
	}
	void OnCollisionEnter2D(Collision2D objeto){
		
		if(objeto.transform.tag == "suelo"){
			Destroy(gameObject);
		}
	}
}
