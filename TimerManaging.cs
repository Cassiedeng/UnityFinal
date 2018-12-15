using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerManaging : MonoBehaviour {


    public CircularTimer timer;
	// Use this for initialization
	void Start () {
        StartTimer();
	}
	
	// Update is called once per frame
	void Update () {
	
	}


    public void StartTimer()
    {
        timer.StartTimer();
    }

    public void DidFinishedTimer()
    {
        Debug.Log("Finished!");
    }
}
