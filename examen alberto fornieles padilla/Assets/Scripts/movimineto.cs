using UnityEngine;
using System.Collections;

public class movimineto : MonoBehaviour {
	Rigidbody2D rg;
	public float velocidad_nave = 50f;

	// Use this for initialization
	void Start () {
		rg= GetComponent<Rigidbody2D>();
	
	}
	void Update () {
		if(Input.GetKeyDown(KeyCode.Space)){

	
		}
		if(Input.GetKey(KeyCode.A)){
			mueve_izquierda();
		}
		
		if(Input.GetKey(KeyCode.D)){
			mueve_derecha();
		}
		Vector2 velocidad = GetComponent<Rigidbody2D>().velocity;
		Debug.DrawLine(transform.position,new Vector3(transform.position.x+velocidad.x,transform.position.y+velocidad.y,transform.position.z));
		
	}
	
	// Update is called once per frame
	void mueve_izquierda(){
		transform.localScale=(new Vector3(1,1,1));

		rg.velocity=(new Vector2 (-(velocidad_nave),rg.velocity.y)); 
		
	}
	void mueve_derecha(){
		transform.localScale=(new Vector3(-1,1,1));

		rg.velocity=(new Vector2 (velocidad_nave,rg.velocity.y));
		
	}

}
