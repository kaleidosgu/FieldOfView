using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

    public Transform target;
    public float smoothSpeed;
    public Vector3 offset;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		

	}

    private void FixedUpdate()
    {
        Vector3 desirePos = target.position + offset;
        Vector3 smoothPos = Vector3.Lerp(transform.position, desirePos, smoothSpeed);
        transform.position = smoothPos;
        //transform.LookAt(target);
    }
}
