using UnityEngine;
using System.Collections;

public class Creditos : MonoBehaviour {
	GameObject btn_voltar;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnGUI () {
		
		//GUI.Label (new Rect (Screen.width/2-70, Screen.height/2-25, 100, 50), "");
		GUI.Label (new Rect(140, 90, 200, 75), "Programação e Design:");
		GUI.Label (new Rect(60, 110, 320, 105), "Victor Matheus Freitas(victormf.df@hotmail.com)");
		GUI.Label (new Rect(180, 140, 200, 125), "Design:");
		GUI.Label (new Rect(155, 155, 200, 125), "Thiago Jacques");
		GUI.Label (new Rect(125, 180, 200, 125), "Equipe do Consea Nacional:");
		GUI.Label (new Rect(80, 200, 300, 300), "Marcelo Gonçalves, Michelle Andrade, Carlos Eduardo Fonseca, Mirlane Klimach, " +
			"Thais Rocha, Thiago Jacques, Victor Matheus Freitas, Willian Vagner, Mônica Maranhão, Rafael Rioja, Marcelo Torres, Beatriz Eva, Patrícia Nobre, Tita Moreira, Marina Lima," +
			" Roberta Sá, Luiz Dombek, Rafael Fleury, Edna Santos, Eliabe Kleiner, Danielle Souza.");
		GUI.Label (new Rect (80, 560, 320, 105), "Conteúdo licenciado em Creative Commons:");

	}
}
