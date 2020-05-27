using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerUiValue : MonoBehaviour
{   
    public int valueDown;
    public int valueUp;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerExit(Collider col) {
        if(col.tag == "Player"){
            col.GetComponent<HealthPlayer>().healthPlayer -= valueDown;
             col.GetComponent<HealthPlayer>().healthPlayer += valueUp;
        }
    }
}
