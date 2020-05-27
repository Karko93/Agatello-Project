using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerLight : MonoBehaviour {
	public GameObject Light;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter(Collider col)
	{
		if (col.tag == "Player") {
			Light.SetActive (true);
		}
	}
	void OnTriggerExit(Collider col)
	{
		if (col.tag == "Player") {
			Light.SetActive (false);
		}
	}
}
