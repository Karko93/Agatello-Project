using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;


public class HealthPlayer : MonoBehaviour
{    
    public int healthPlayer = 100;
    public Slider slider;
    public GameObject Mcamera;
    //public GameObject Parent;
    public GameObject PanelDead;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    [System.Obsolete]
    void Update()
    {
        slider.value = healthPlayer;
        if(healthPlayer <= 0){
            //сылаеться к инроку и блокирует его камеру .
            gameObject.GetComponent<FirstPersonController>().enabled = false;
            Screen.lockCursor = false;//устаревшая опция, поэтому попросили указать system.obsolate
            PanelDead.SetActive(true);
            Mcamera.SetActive (true);
            //Destroy(gameObject);
           
        }
    }
}

