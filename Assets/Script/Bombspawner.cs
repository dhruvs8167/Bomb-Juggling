using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bombspawner : MonoBehaviour {
    public GameObject bomb;
    float randX;
    Vector2 whereToSpwan;
    public float spwanRate = 10f;
    float nextspwan = 0.0f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Time.time > nextspwan)
        {
            nextspwan = Time.time + spwanRate;
            randX = Random.Range (-2.5f , 2.5f);
            whereToSpwan = new Vector2(randX, transform.position.y);
            Instantiate(bomb, whereToSpwan, Quaternion.identity);
        }
	}
}
