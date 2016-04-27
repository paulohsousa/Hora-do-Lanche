using UnityEngine;
using System.Collections;

public class Musica : MonoBehaviour {

	public Texture2D musicOn;
	public Texture2D musicOff;
	public bool ativo;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if (ativo) {
			gameObject.GetComponent<AudioSource> ().mute = true;
			gameObject.GetComponent<GUITexture> ().texture = musicOff;
		} else {
			gameObject.GetComponent<AudioSource> ().mute = false;
			gameObject.GetComponent<GUITexture> ().texture = musicOn;
		}
	}

	void OnMouseDown() {
		ativo = !ativo;
	}
}
