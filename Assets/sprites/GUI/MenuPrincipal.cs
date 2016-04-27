using UnityEngine;
using System.Collections;

public class MenuPrincipal : MonoBehaviour {
	public GUIStyle buttonStyle;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	/*void OnGUI(){
		GUI.Box (new Rect (Screen.width / 2 -130 , Screen.height / 2 - 160, 250, 350), "");
		if (GUI.Button (new Rect (Screen.width / 2.5f, Screen.height / 6, Screen.width / 4, Screen.height / 5), "Start Game", buttonStyle)) {
			Application.LoadLevel ("level1");
		}
		//GUI.Button(new Rect (Screen.width / 2 - 100 , Screen.height / 2 - 90, 200, 50), "Iniciar");
	}*/
	public Texture aTexture;
	void OnGUI() {
		if (GUI.Button (new Rect (130, 340, 150, 70), "Iniciar")) {
			Application.LoadLevel ("level1");
		}
		if (GUI.Button (new Rect (130, 420, 150, 70), "Creditos")) {
			Application.LoadLevel ("Creditos");
		}
		if (GUI.Button (new Rect (130, 500, 150, 70), "Pontuação")) {
			Application.LoadLevel ("Pontuacao");
		}
	
	}

}
