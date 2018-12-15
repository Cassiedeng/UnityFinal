using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerManager : MonoBehaviour {

     
    public CircularTimer timer;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


    public void StartTimer()
    {
        timer.StartTimer();
    
    }

    public void PauseTimer()
    {
        timer.PauseTimer();


    }

    public void DidFinishedTimer(){

        Debug.Log("Finished!");
}
}
