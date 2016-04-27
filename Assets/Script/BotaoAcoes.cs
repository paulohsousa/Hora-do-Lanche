using UnityEngine;
using System.Collections;

public class BotaoAcoes : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void btnMenu(){
		Application.LoadLevel("Menu");
	}

	public void btnLicenca(){
		Application.OpenURL("https://creativecommons.org/licenses/by-nc-sa/4.0/legalcode");
	}

	public void btnGame(){
		Application.LoadLevel("level1");
	}
	public void btnCreditos(){
		Application.LoadLevel("Creditos");
	}
	public void btnTutorial(){
		Application.LoadLevel("Pontuacao");
	}
}
