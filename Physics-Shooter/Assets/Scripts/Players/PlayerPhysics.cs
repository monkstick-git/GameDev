using UnityEngine;
using System.Collections;

public class PlayerPhysics : MonoBehaviour {

	// Use this for initialization
	void Start () {
		//print (gameObject);
		//GameObject test = Instantiate(Resources.Load("Bullet")) as GameObject;

	}
	
	// Update is called once per frame
	void Update () {
		float Tmp = gameObject.transform.eulerAngles.y;
		gameObject.transform.eulerAngles = new Vector3(0,Tmp,0);
	
	}
}
