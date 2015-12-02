using UnityEngine;
using System.Collections;

public class movimineto : MonoBehaviour {
	Rigidbody2D rg;
	public GameObject proyectil;	
	public float velocidad_nave = 50f;
	public Vector2 fuerza= new Vector2(0,50);


	// Use this for initialization
	void Start () {
		rg= GetComponent<Rigidbody2D>();
	  
	
	}
	void Update () {

		if(Input.GetKeyDown(KeyCode.Space)){

				//Debug.Log (objeto.transform.tag); // tambien se puede poner Debug.Log (objeto.name); y detectara solo en nombre
				GameObject nuevo_proyectil=(GameObject)Instantiate(proyectil,transform.position,transform.rotation);//Que cree un objeto llamado proyectil en el lugar de la chistera con la rotacion de esta
				nuevo_proyectil.GetComponent<Rigidbody2D>().AddForce(new Vector2(0,500)); //Hemos dicho q ese game objet sera un nuevo_proyectil, tras poder localizarlo ya le metemos cosas
		
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
	void OnCollisionEnter2D(Collision2D objeto){
	
		if(objeto.transform.tag == "Enemigo"){
			Destroy(gameObject);
		}


}
}
