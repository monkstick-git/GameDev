using UnityEngine;
using System.Collections;

public class Gamemode : MonoBehaviour {
    private int Enemies = 0;
    private float Timer = 0;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        Timer = Timer + Time.deltaTime;

        if (Timer >= 1f & Enemies <= 25)
        {
            GameObject enemy = Instantiate(Resources.Load("Enemy")) as GameObject;
            enemy.transform.position = gameObject.transform.position + new Vector3(Random.Range(-30, 30), 5, Random.Range(-30, 30));
            Timer = 0f;
        }

    }
}
