using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nlofly : MonoBehaviour {

    public Transform nloLanding;
    public float landingTime;
    Vector3 nloStartingPos;
    Vector3 nloLandingPos;
    float mTimer;

	// Use this for initialization
	void Start ()
    {
        nloStartingPos = transform.position;
        nloLandingPos = nloLanding.position;
        mTimer = 0.0F;
    }
	
	// Update is called once per frame
	void Update ()
    {
        mTimer += Time.deltaTime;
        transform.position = Vector3.Lerp(nloStartingPos, nloLandingPos, mTimer/landingTime);
	}
}