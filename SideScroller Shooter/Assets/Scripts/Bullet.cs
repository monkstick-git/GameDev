using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {
	Vector3 InitAng = new Vector3(0,0,0);
	public Vector3 Ang;
	float Life = 0;
	// Use this for initialization
	void Start () {
		InitAng = Ang; //GameObject.Find ("Player").transform.eulerAngles;
        gameObject.transform.eulerAngles = new Vector3(InitAng.x, InitAng.y, InitAng.z);
        //Physics.IgnoreCollision (GameObject.Find ("Floor").GetComponent<Collider> (), this.GetComponent<Collider> ());
    }

	void OnCollisionEnter (Collision col) {
		if (col.gameObject.name.Contains("Floor")) {
            print("Floor!");
		} else {
				//Destroy (col.gameObject);
				//Destroy (this.gameObject);

				//GameObject enemy = Instantiate(Resources.Load("Enemy")) as GameObject;
				//enemy.transform.position = gameObject.transform.position + new Vector3(Random.Range(-30,30),1,Random.Range(-30,30));


		}

	}

	// Update is called once per frame
	void Update () {
       // transform.LookAt(transform.position + new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")));
        
		gameObject.transform.Translate (gameObject.transform.right * (Time.deltaTime * 30));

        



        Life = Life + (Time.deltaTime * 1);;
		if (Life >= 3) {
			Destroy (gameObject);
		}
	}
}
