﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerDoor : MonoBehaviour {

	public float smooth = 2.0f;
	public float DoorOpenAngle = 90.0f;

    public Character character;

	
	private Vector3 defaultRot;
	private Vector3 openRot;
	private bool open;
	private bool enter;

	// Use this for initialization
	void Start () {
		
			defaultRot = transform.eulerAngles;
			openRot = new Vector3 (defaultRot.x, defaultRot.y + DoorOpenAngle, defaultRot.z);
		}
	
	// Update is called once per frame
	void Update () {
		if (open) {
			
			transform.eulerAngles = Vector3.Slerp (transform.eulerAngles, openRot, Time.deltaTime * smooth);
		} else {
			
			transform.eulerAngles = Vector3.Slerp (transform.eulerAngles, defaultRot, Time.deltaTime * smooth);

		}
		if (Input.GetKeyDown (KeyCode.E) && enter) {
			open = !open;
		}
}

	void OnTriggerEnter(Collider col)
	{
		if (character.hasKey) {
			enter = true;
		}else{
            Debug.Log("Has no key");
        }
	}

    
}
