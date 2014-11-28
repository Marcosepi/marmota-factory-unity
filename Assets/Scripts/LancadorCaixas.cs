using UnityEngine;
using System.Collections;

public class LancadorCaixas : MonoBehaviour {
	public GameObject caixapreta;
	public GameObject caixabranca;
	public GameObject caixaverde;
	public GameObject caixaamarela;
	public GameObject caixaazul;
	public GameObject caixavermelha;
	private GameObject _item;
	
	// Use this for initialization
	void Start()
	{
		Invoke("Launch", 1f);
	}
	
	void Launch()
	{
		if (Random.Range(0, 100) <= 10)
		{
			_item = GameObject.Instantiate(caixaazul) as GameObject;
			Vector3 pos = transform.position;
			pos.y = getRandomTrackPosition();
			pos.x = 20f;
			_item.transform.position = pos;
			_item.transform.parent = transform;
		}
		if (Random.Range(0, 100) <= 10)
		{
			_item = GameObject.Instantiate(caixaamarela) as GameObject;
			Vector3 pos = transform.position;
			pos.y = getRandomTrackPosition();
			pos.x = 20f;
			_item.transform.position = pos;
			_item.transform.parent = transform;
		}
		if (Random.Range(0, 100) <= 10)
		{
			_item = GameObject.Instantiate(caixabranca) as GameObject;
			Vector3 pos = transform.position;
			pos.y = getRandomTrackPosition();
			pos.x = 20f;
			_item.transform.position = pos;
			_item.transform.parent = transform;
		}
		if (Random.Range(0, 100) <= 10)
		{
			_item = GameObject.Instantiate(caixaverde) as GameObject;
			Vector3 pos = transform.position;
			pos.y = getRandomTrackPosition();
			pos.x = 20f;
			_item.transform.position = pos;
			_item.transform.parent = transform;
		}
		if (Random.Range(0, 100) <= 10)
		{
			_item = GameObject.Instantiate(caixavermelha) as GameObject;
			Vector3 pos = transform.position;
			pos.y = getRandomTrackPosition();
			pos.x = 20f;
			_item.transform.position = pos;
			_item.transform.parent = transform;
		}
		if (Random.Range(0, 100) <= 10)
		{
			_item = GameObject.Instantiate(caixapreta) as GameObject;
			Vector3 pos = transform.position;
			pos.y = getRandomTrackPosition();
			pos.x = 20f;
			_item.transform.position = pos;
			_item.transform.parent = transform;
		}
		Invoke("Launch", Random.Range(1f, 2f));
	}



public float getRandomTrackPosition(){
	int track = Random.Range(1,4);
	if(track == 1){
		return 3f;
	}
	if (track == 2){
		return 0f;
	}
	if (track == 3){
		return -3f;
	}
	if (track == 4) {
		return -6f;
	} else {
		return 0;
	}
	}
}