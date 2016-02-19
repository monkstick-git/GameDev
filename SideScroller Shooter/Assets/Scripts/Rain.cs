using UnityEngine;
using System.Collections;

public class Rain : MonoBehaviour {
    GameObject Ply;
    float Timer = 0;

    void CreateRain(Vector3 Pos)
    {
        GameObject Cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        Cube.AddComponent<Rigidbody>();
        Cube.transform.localScale = new Vector3(0.4f, 0.4f, 0.4f);
        Cube.transform.position = Pos;
        Cube.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePositionZ | RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationY;
        // Cube.GetComponent<Rigidbody>().constraints = ;
          Cube.GetComponent<Collider>().material = (PhysicMaterial)Resources.Load("Ice");
        Cube.GetComponent<Rigidbody>().mass = 10;
    }

    void Start () {

        GameObject Ply = GameObject.Find("Player");

        for(int I = 1; I < 25; I++)
        {
            for (int I2 = 1; I2 < 25; I2++)
            {
                CreateRain(new Vector3(0,-15,0) + new Vector3(I / 2f, I2 / 2f, 0));
            }
                
        }
	}

	// Update is called once per frame
	void Update () {
        Timer = Timer + Time.deltaTime;
        if(Timer >= 0.1)
        {
         //   CreateRain(GameObject.Find("Player").transform.position + new Vector3(Random.Range(-9, 9), 20, 0));
            Timer = 0;
        }
    }
}
