using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Triggering : MonoBehaviour {


    public Transform sparkle;

	// Use this for initialization
	void Start () {
        sparkle.GetComponent<ParticleSystem>().enableEmission = false;
	}

    private void OnTriggerEnter()
    {
        sparkle.GetComponent<ParticleSystem>().enableEmission = true;
        StartCoroutine(stopSparkles());
    }

        IEnumerator stopSparkles()
    {
        yield return new WaitForSeconds(.4f);

        sparkle.GetComponent<ParticleSystem>().enableEmission = false;
    }

}
