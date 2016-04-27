using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
	private Vector3 position;
	private bool morte;

	//private Score score;
	//private Vidas vida;
	//private Pause pause;
	//public GameObject gameOver;
	public AudioClip clipLetra;
	public AudioClip clipNumero;

	TrailRenderer trail;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Plataforma ();
	}

	private void Plataforma(){
		if (Application.platform == RuntimePlatform.Android) {
			if (Input.touchCount == 1) {
				position = Camera.main.ScreenToWorldPoint (new Vector3 (Input.GetTouch (0).position.x,
					Input.GetTouch (0).position.y,1));
				transform.position = new Vector2 (position.x, position.y);
				GetComponent<Collider2D>().enabled = true;
				return;
			}
			GetComponent<Collider2D>().enabled = false;
		} else {
			position = Camera.main.ScreenToWorldPoint (new Vector3 (Input.mousePosition.x,
				Input.mousePosition.y,0));
			transform.position = new Vector2 (position.x, position.y);
		}

	}
	void OnTriggerEnter2D(Collider2D collisor){
		if (collisor.tag == "Letras") {
			collisor.GetComponent<Item> ().InstanciarDestruir ();
		}
	}
}
