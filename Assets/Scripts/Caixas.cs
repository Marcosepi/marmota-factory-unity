using UnityEngine;
using System.Collections;

public class Caixas : MonoBehaviour {
	public float speed = 0.08f;
	// Use this for initialization
	void Start () {
		speed = 0.08f;
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (-speed,0,0);
	}

	void OnTriggerEnter2D(Collider2D c){
		if (c.gameObject.CompareTag ("azul") ||c.gameObject.CompareTag ("amarelo")
		    ||c.gameObject.CompareTag ("vermelho")||c.gameObject.CompareTag ("verde")) {
			Destroy(gameObject);

			
		}
		
	}
}
