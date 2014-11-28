using UnityEngine;
using System.Collections;

public class EfeitoCaixa : MonoBehaviour {
	private string minhaTag;
	private string tagCor;

	private bool utilizarCaixa;
	private Manager _manager ;
	void Start(){
		//minhaTag = Component.tag;
		utilizarCaixa = false;
		//_manager = (Manager) GameObject.FindWithTag("GamaManager").GetComponent("Manager");
}

	void FixedUpdate(){
		if (utilizarCaixa){
			int posicao;
			if (Input.GetKey("1")){
				posicao =1;
				//_manager.EnviaEfeitoCaixa(posissao,tagCor);
			}
			if (Input.GetKey("2")){
				posicao =2;
				//_manager.EnviaEfeitoCaixa(posissao,tagCor);

			}
			if (Input.GetKey("3")){
				posicao =3;
				//_manager.EnviaEfeitoCaixa(posissao,tagCor);

			}
			if (Input.GetKey("4")){
				posicao =4;
				//_manager.EnviaEfeitoCaixa(posissao,tagCor);
			}

		
		}
	}

	void OnCollisionEnter2D(Collision2D c){
		utilizarCaixa = true;
		tagCor = c.collider.tag;	

//		if(c.collider.CompareTag(minhaTag)){
//		}
//		else{
//			rigidbody.AddForce (Vector3.right*2);
//		}
	}


}
