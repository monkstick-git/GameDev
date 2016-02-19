using UnityEngine;
using System.Collections;

public class PlayerControlls : MonoBehaviour {
	float FireValue = 0;

	Rigidbody PlayerRB;
	// Use this for initialization
	void Start () {

		PlayerRB = GetComponent<Rigidbody> ();
	}

	public int Friendly = 1;
	
	// Update is called once per frame
	void Update () {
       // print(Input.GetJoystickNames());
		float X = (Input.GetAxis ("Vertical") * Time.deltaTime) * -10;
		float Strafe = (Input.GetAxis ("Horizontal") * Time.deltaTime) * -10;
		Vector3 newPos =  new Vector3(Strafe,0,X);

		float Y = (Input.GetAxis ("SecondStick") * Time.deltaTime) * 200;
		Vector3 newPos2 =  new Vector3(0,Y,0);

		gameObject.transform.Translate (newPos);
		gameObject.transform.Rotate(newPos2);

		//FireValue = FireValue + (Time.deltaTime * (9));

		if (Input.GetButton ("Fire1")) {
			if (FireValue < 1) {
				for (int i = 1; i < 2; i++) {
					GameObject test = Instantiate (Resources.Load ("Bullet")) as GameObject;
					test.transform.position = gameObject.transform.position;
					Physics.IgnoreCollision (test.GetComponent<Collider> (), GetComponent<Collider> ());
					test.GetComponent<Bullet> ().Ang = (gameObject.transform.eulerAngles + new Vector3 (Random.Range (-3, 3), 0, Random.Range (-3, 3)));
                    FireValue = FireValue + 0.5f;//Time.deltaTime;
					GetComponent<AudioSource> ().Play ();
				}
			}		
		} else {
			FireValue = 0;
		}

	}

	void ShootBullet() {

	}
}
