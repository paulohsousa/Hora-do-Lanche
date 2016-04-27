using UnityEngine;
using System.Collections;

public class Instanciar : MonoBehaviour {

	public float minSpawnTime;
	public float maxSpawnTime;
	public float spawnItem;
	public Pontuacao pontuacao;
	public GameObject[] Itens;
	private GameObject item;
	public int index;

	public float upForce = 400f;
	public float leftForce = 200f;
	public static float minX, maxX;


	// Use this for initialization
	void Start () {
		minX = GerenciarCamera.MinX() + 0.4f;
		maxX = GerenciarCamera.MaxX() - 0.4f;

		StartCoroutine ("Instanciador");
	}
	
	// Update is called once per frame
	void Update () {
		Velocidade (pontuacao);
	}

	bool RandomItem(){
		if (Itens.Length > 0) {
			index = Random.Range (0, Itens.Length);
			return true;
		}
		return false;
	}

	private void Velocidade(Pontuacao pontuacao){
		if (pontuacao.pontos > 15) {
			this.maxSpawnTime = 2;
			if (pontuacao.pontos > 30) {
				this.minSpawnTime = 0;
			} else if (pontuacao.pontos > 50) {
				this.maxSpawnTime = 1;
			}
			if(pontuacao.pontos > 65){
				this.maxSpawnTime = 0.9f;
			}
		}

	
	}

	private IEnumerator Instanciador()
	{
		spawnItem = Random.Range (minSpawnTime, maxSpawnTime);

		yield return new WaitForSeconds (spawnItem);
		if (RandomItem ()) {
			item = Instantiate (Itens [index], new Vector3 (Random.Range (minX , maxX ), transform.position.y, 0),
				Quaternion.Euler (0, 0, 2)) as GameObject;
			/*if(item.transform.position.x>0){
				item.GetComponent<Rigidbody2D>().AddForce(new Vector2(-leftForce,upForce));
					}else{
				item.GetComponent<Rigidbody2D>().AddForce(new Vector2(-leftForce,upForce));
					}*/
			StartCoroutine ("Instanciador");
		}

	}
}
