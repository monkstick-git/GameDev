using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {
	Vector3 InitAng = new Vector3(0,0,0);
	public Vector3 Ang;
	float Life = 0;
	// Use this for initialization
	void Start () {
		InitAng = Ang; //GameObject.Find ("Player").transform.eulerAngles;

		//Physics.IgnoreCollision (GameObject.Find ("Floor").GetComponent<Collider> (), this.GetComponent<Collider> ());
	}

	void OnCollisionEnter (Collision col) {
		if (col.gameObject.name == "Floor") {
		} else {

			if (col.gameObject.GetComponent<Sides> ().Side == 1) {
				Destroy (col.gameObject);
				Destroy (this.gameObject);

				GameObject enemy = Instantiate(Resources.Load("Enemy")) as GameObject;
				enemy.transform.position = gameObject.transform.position + new Vector3(Random.Range(-30,30),1,Random.Range(-30,30));
			} else {
				//	Physics.IgnoreCollision (Go.GetComponent<Collider>(),GetComponent<Collider>());
				//	Destroy (this.gameObject);
			}

		}

	}

	// Update is called once per frame
	void Update () {
		
		gameObject.transform.eulerAngles = new Vector3(gameObject.transform.eulerAngles.x,InitAng.y,InitAng.z);
		gameObject.transform.Translate (gameObject.transform.forward * (Time.deltaTime * 30));




		Life = Life + (Time.deltaTime * 1);;
		if (Life >= 3) {
			Destroy (gameObject);
		}
	}
}
