using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportTrigger : MonoBehaviour
{
  /* public bool teleported = false;
   public TeleportTrigger target;

   void OnTriggerEnter(Collider other){
       if(other.CompareTag("People")){
           if(!teleported){
               target.teleported = true;
               other.gameObject.transform.position = target.gameObject.transform.position;
           }
       }
   }

    void  OnTriggerExit(Collider other){
        if(other.CompareTag("People")){
            teleported = false;
        }
    }*/
   
   public Transform teleport;
	public GameObject Text;
	private bool teleported;
	//private GameObject player;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(teleported == true)
		{
			Text.SetActive (true);
			if (Input.GetKeyDown (KeyCode.E)) {
				//player.transform.position = Teleport.position;
				//teleported = false;
			}
		}
	}
	void OnTriggerEnter(Collider col)
	{
		if (col.tag == "Player") {
            Text.SetActive (true);
           // col.transform.position = teleport.transform.position;
			//player = col.gameObject;
			//teleported = true;
		}
	}
	void OnTriggerExit(Collider col)
	{
		if (col.tag == "Player") {
			//teleported = false;
			Text.SetActive (false);
		}
	}
}
