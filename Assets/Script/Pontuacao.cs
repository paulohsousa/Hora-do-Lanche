using UnityEngine;
using System.Collections;

public class Pontuacao : MonoBehaviour {
	private int recorde;
	public int pontos = 0;
	public GameObject textPontos;
	// Use this for initialization
	void Start () {
		pontos = 0;
		GetComponent<GUIText>().text = pontos.ToString();
		Recorde ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void Hit(){
		++pontos;
		GetComponent<GUIText> ().text = pontos.ToString ();
	}

	public void Recorde(){
		if(pontos > PlayerPrefs.GetInt("Recorde")){
			PlayerPrefs.SetInt ("Recorde", pontos); 
		}
		if (textPontos != null) {
			textPontos.GetComponent<GUIText> ().text = "Recorde:" + " " + 
				PlayerPrefs.GetInt ("Recorde").ToString ();
		}
	}
}
