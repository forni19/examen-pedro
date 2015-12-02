using UnityEngine;
using System.Collections;

public class disparo : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnCollisionEnter2D(Collision2D objeto){
		
		if(objeto.transform.tag == ""){
			Destroy(gameObject);
		}
}
}
