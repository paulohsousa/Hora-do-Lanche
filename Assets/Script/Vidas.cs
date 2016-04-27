using UnityEngine;
using System.Collections;

public class Vidas : MonoBehaviour {
	public Texture2D[] Vida;
	private int tamanhoVidas;
	private int index = 0;

	// Use this for initialization
	void Start () {
		GetComponent<GUITexture>().texture = Vida [0];
		tamanhoVidas = Vida.Length;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public bool Remover(){
		if (index < (tamanhoVidas - 1)) {
			index += 1;
			GetComponent<GUITexture>().texture = Vida [index];
			return true;
		} else {
			Application.LoadLevel("GameOver");
			return false;
		}
	}
}
