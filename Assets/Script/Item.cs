using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class Item : MonoBehaviour {

	private Pontuacao pontos;
	private Vidas vidas;
	public AudioClip BadFoodsAudio;
	private AudioSource source;

	public float forca;
	public float torque;
	private bool isDead;
	private Vector3 screen;

	public float alpha;
	public float red;
	public float green;
	public float blue;

	public float minY;
	public float maxY;

	//private float rotDirecao = 50;


	// Use this for initialization
	void Start () {
		minY = GerenciarCamera.MinY ();
		maxY = GerenciarCamera.MaxY ();
	
	}
	
	// Update is called once per frame
	void Update () {
		Remover ();
	}

	void Awake(){
		pontos = GameObject.FindGameObjectWithTag ("Pontos").GetComponent<Pontuacao> () as Pontuacao;
		vidas = GameObject.FindGameObjectWithTag ("Vidas").GetComponent<Vidas> () as Vidas;
	}

	public void InstanciarDestruir(){
		Destroy (gameObject);
	}

	public void Remover(){
		screen = Camera.main.WorldToScreenPoint(transform.position);
		if(isDead && screen.y < minY){
			Destroy (gameObject);
			if (gameObject.tag == "Goodfood") {
				if (!vidas.Remover ()) {
					pontos.Recorde ();
				}
			}
		}
		else{
			isDead = true;
		}
	}
	void OnMouseDown() {
		
		switch (gameObject.tag) {
		case "badfood":
			GetComponent<AudioSource> ().Play ();
			Destroy(gameObject);
			if (!vidas.Remover ()) {
				pontos.Recorde ();
			}
			break;
		case "Goodfood":
			pontos.Hit ();
			Destroy(gameObject);
			break;
		default:
			break;
		}
	}
}
