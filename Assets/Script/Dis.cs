using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dis : MonoBehaviour {
    public float interval;
	// Use this for initialization
	void Start () {
        Destroy(gameObject, interval);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
