using UnityEngine;
using System.Collections;

public class Delete : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

    void OnCollisionEnter(Collision col) {

        Destroy(col.gameObject);

    }

        // Update is called once per frame
        void Update () {
	
	}
}
