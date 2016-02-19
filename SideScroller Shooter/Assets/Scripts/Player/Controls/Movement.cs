using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {

    int Jump = 1;
    float Mul = 1;
    int Jumped = 0;
    Vector3 Force;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        gameObject.GetComponent<Rigidbody>().AddForce((new Vector3(0, Time.deltaTime * -130, 0)));
        float Movement = Input.GetAxis("Horizontal") * 5;
        Rigidbody Body = gameObject.GetComponent<Rigidbody>();
        if(Mathf.Abs( Input.GetAxis("Horizontal")) >= 0.1 )
        {
           // gameObject.GetComponent<Rigidbody>().drag = 0;
            //print("Moving");
            if (Physics.Raycast(transform.position, -Body.transform.up, 0.5f))
            {
                Mul = 1;

            }
            else
            {
                Mul = 0.3f;
            }
        }
        else
        {
            Mul = 1;
            //gameObject.GetComponent<Rigidbody>().drag = 2;
            Vector3 Vel = gameObject.GetComponent<Rigidbody>().velocity;
            gameObject.GetComponent<Rigidbody>().AddForce((new Vector3(Vel.x,0,0)) * -0.5f);
        }
        Body.AddForce(new Vector3(Movement * (Mul*2), 0, 0));

        if ( (Input.GetButton("Jump") & Jump == 1))
        {
            if(Physics.Raycast(transform.position, -Body.transform.up, 0.5f) & Jumped == 0)
            {
               // Force = 
                Body.AddForce(Body.transform.up * (500f));
                Jump = 0;
                Jumped = 1;
            }

            if (Physics.Raycast(transform.position, -Body.transform.right, 0.3f) & Jumped == 0)
            {
                Body.AddForce(Body.transform.up * 350);
                Body.AddForce(Body.transform.right * 200);
                Jump = 0;
                Jumped = 1;
            }

            if (Physics.Raycast(transform.position, Body.transform.right, 0.3f) & Jumped == 0)
            {
                Body.AddForce(Body.transform.up * 350);
                Body.AddForce(-Body.transform.right * 200);
                Jump = 0;
                Jumped = 1;
            }

        }
        else {
            if (!Input.GetButton("Jump"))
            {
                Jump = 1;
            }          
        }

        Jumped = 0;

    }
}
