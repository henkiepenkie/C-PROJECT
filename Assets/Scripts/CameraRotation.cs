﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotation : MonoBehaviour {

	public Transform target;
	public float turnSpeed = 3;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
    	transform.LookAt(target);
    	transform.Translate(Vector3.right * Time.deltaTime * turnSpeed);
	}
}
