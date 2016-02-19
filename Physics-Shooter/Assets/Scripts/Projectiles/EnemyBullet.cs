using UnityEngine;
using System.Collections;

public class EnemyBullet : MonoBehaviour {
	float Life = 0;
	int Vel = 0;
	// Use this for initialization
	Rigidbody rb;
	public Vector3 Ang;

	void Start () {

	}

	public GameObject firer;

	void OnCollisionEnter (Collision col) {
        print(col.gameObject.name);
		GameObject Go = col.gameObject;
        if (Go.GetComponent<Sides>() != null) {
            if (Go.GetComponent<Sides>().Side == 0)
            {
                Destroy(col.gameObject);
                Destroy(this.gameObject);
            }
            else {
                //Physics.IgnoreCollision (Go.GetComponent<Collider>(),GetComponent<Collider>());
               Destroy (this.gameObject);
            }
        }
        else
        {

            Destroy(this.gameObject);
        }


	}

	// Update is called once per frame
	void Update () {
		
		gameObject.transform.eulerAngles = new Vector3(gameObject.transform.eulerAngles.x,Ang.y,Ang.z);
		gameObject.transform.Translate (-gameObject.transform.forward * (Time.deltaTime * 10));
			//rb.velocity = rb.velocity + (rb.transform.forward * 10.0f);


		Life = Life + (Time.deltaTime * 1);
		if (Life >= 10) {
			Destroy (this.gameObject);
		}
	}
}
