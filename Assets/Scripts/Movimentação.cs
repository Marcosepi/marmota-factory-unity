using UnityEngine;
using System.Collections;

public class Movimentação : MonoBehaviour {

	public float velocidade;
	
	void Start () {
		velocidade = 0.003f;
	}
	
	// Update is called once per frame
	void Update () {
		//transform.Translate ();
		transform.position = new Vector3(transform.position.x+velocidade, transform.position.y, transform.position.z);
	}

	void OnTriggerStay2D(Collider2D c){
		if (c.CompareTag (gameObject.tag)) {
			velocidade = 0.005f;
		}else{
			velocidade = 0.003f;
		}
	}

}
