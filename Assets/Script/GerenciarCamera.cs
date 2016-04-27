using UnityEngine;
using System.Collections;

public class GerenciarCamera : MonoBehaviour {

	public Camera cam;
	private static float minX;
	private static float maxX;
	private static float minY;
	private static float maxY;

	private float distanciaZ;
	// Use this for initialization
	void Start () {
		Screen.orientation = ScreenOrientation.Portrait;
		distanciaZ = transform.position.z - cam.transform.position.z;
		minX = cam.ScreenToWorldPoint (new Vector3 (0, 0, distanciaZ)).x;
		maxX = cam.ScreenToWorldPoint (new Vector3 (Screen.width, 0, distanciaZ)).x;

		minY = cam.ScreenToWorldPoint (new Vector3 (0, 0, distanciaZ)).y;
		maxY = cam.ScreenToWorldPoint (new Vector3 (0, Screen.height, distanciaZ)).y;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public static float MinY(){
		return minY;
	}
	public static float MaxY(){
		return maxY;
	}
	public static float MinX(){
		return minX;
	}
	public static float MaxX(){
		return maxX;
	}
}
