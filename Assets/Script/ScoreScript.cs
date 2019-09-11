using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour {
    public Text timertext;
    private float starttime;
	// Use this for initialization
	void Start () {
        starttime = Time.time;
	}
	
	// Update is called once per frame
	void Update () {
        float t = Time.time - starttime;
        string min = ((int)t / 60).ToString();
        string sec = (t % 60).ToString();
        timertext.text = min + ":" + sec;
    }
}
