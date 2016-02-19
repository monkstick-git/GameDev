using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {
	float FireValue = 0;
	int IsEnemy = 1;
	float Timer = 0;
	private int Randomness = 12;
	// Use this for initialization
	void Start () {
		
	}

	public int Friendly = 0;

	void LookAtPlayer()
	{
		Vector3 Pos = GameObject.Find("Player").gameObject.transform.position;
		Vector3 Predict = Pos + (GameObject.Find ("Player").GetComponent<Rigidbody>().velocity * 0.5f);
		gameObject.transform.LookAt (Predict);
		//print (GameObject.Find ("Player").GetComponent<Rigidbody>().velocity);
	}

	void ShootPlayer2()
	{
		
		if (FireValue >= 1) {
			for (int i = 1; i < 2; i++) {
				GameObject test = Instantiate (Resources.Load ("EnemyBullet")) as GameObject;
				test.transform.position = gameObject.transform.position;
				test.transform.eulerAngles = new Vector3 (90, gameObject.transform.eulerAngles.y, gameObject.transform.eulerAngles.z); //
				Physics.IgnoreCollision (test.GetComponent<Collider> (), GetComponent<Collider> ());
				test.GetComponent<EnemyBullet> ().Ang = gameObject.transform.eulerAngles + new Vector3 (Random.Range (-Randomness,Randomness), 0, Random.Range (-Randomness,Randomness));
				FireValue = 0;
			}

//			test.GetComponent<EnemyBullet> ().firer = gameObject;
		}	
	}

	// Update is called once per frame
	void Update () {
		Timer = Timer + Time.deltaTime;
		FireValue = FireValue + (Time.deltaTime * 2f);
		float Dist = Vector3.Distance(this.gameObject.transform.position,GameObject.Find("Player").gameObject.transform.position);
		if (Dist <= 25) {
			LookAtPlayer ();
			ShootPlayer2 ();
		} else {
			if (Timer >= 0.5f) {
				Timer = 0;
				Vector3 DirVel = Vector3.Scale(((GameObject.Find ("Player").transform.position - gameObject.transform.position).normalized),new Vector3(2,2,2));
				GetComponent<Rigidbody> ().velocity = GetComponent<Rigidbody> ().velocity + (new Vector3(0,3,0) + DirVel);

			}
		}
	}


}
