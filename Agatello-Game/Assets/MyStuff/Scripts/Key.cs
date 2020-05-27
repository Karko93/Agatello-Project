using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class Key : MonoBehaviour
{   
    public Character nina;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    /*void OnTriggerEnter(Collider other) {
        nina.hasKey = true;
        gameObject.SetActive(false);
    }*/
    void OnTriggerEnter(Collider col)
	{
		if (col.tag == "Player") {
			nina.hasKey = true;
            gameObject.SetActive(false);
		}
	}
    
}
