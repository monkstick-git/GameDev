using UnityEngine;
using System.Collections;

public class Shooting : MonoBehaviour {
    float FireValue = 0;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetButton("Fire1"))
        {
           // if (FireValue < 1)
           // {
                for (int i = 1; i < 20; i++)
                {
                    GameObject test = Instantiate(Resources.Load("Bullet")) as GameObject;
                    test.transform.position = gameObject.transform.position;
                    Physics.IgnoreCollision(test.GetComponent<Collider>(), GetComponent<Collider>());
               // test.GetComponent<Bullet>().Ang = new Vector3(Input.mousePosition.x, Input.mousePosition.y, Input.mousePosition.z);  //gameObject.GetComponent<Rigidbody>().transform.eulerAngles;
                    FireValue = FireValue + 0.5f;//Time.deltaTime;
                                                 // GetComponent<AudioSource>().Play();


               // Vector3 worldMousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                //Vector3 direction = worldMousePosition - transform.position;
                //Vector3 angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Atan2;
                //energyBall.transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
                //energyBall.rigidbody2D.AddForce(energyBall.transform.right * 5000);


            }
            }
        //}
       // else {
        //    FireValue = 0;
       // }

    }
}
