using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{   
    public Transform EndPoint;

    void Start() {

    }

    void Update() {
        transform.position = Vector3.MoveTowards(transform.position,EndPoint.position,Time.deltaTime);
    }
   /* float dirX;
    float speed = 3f;

    bool moveingRight = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x > 4f){
            moveingRight = false;
        }else if (transform.position.x < -4f){
            moveingRight = true;            
        }

        if(moveingRight){
            transform.position = new Vector3(transform.position.x + speed * Time.deltaTime,transform.position.y,transform.position.z);
        }else{
             transform.position = new Vector3(transform.position.x - speed * Time.deltaTime,transform.position.y,transform.position.z);
        }
        //transform.position = new Vector3(transform.position.x,Mathf.Cos(Time.timeSinceLevelLoad), transform.position.z);
    }*/
}
