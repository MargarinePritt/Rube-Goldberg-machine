using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Square2Controller : MonoBehaviour
{
    private GameObject camera0;
    private GameObject camera1;
    private GameObject myGameObject;

    // Start is called before the first frame update
    void Start(){
        camera0=GameObject.Find("Camera");
        camera0.GetComponent<Camera>().enabled=false;
        camera1=GameObject.Find("Camera (1)");
        camera1.GetComponent<Camera>().enabled=false;
        myGameObject=GameObject.Find("Square (2)");
    }

    // Update is called once per frame
    void Update(){
        
    }

    private void OnCollisionEnter2D(Collision2D collision){
        if(collision.gameObject.tag=="Square(1)"){
            camera0.GetComponent<Camera>().enabled=false;
            camera1.GetComponent<Camera>().enabled=true;
            myGameObject.GetComponent<Rigidbody2D>().gravityScale=1;
            collision.gameObject.GetComponent<Rigidbody2D>().gravityScale=0;
        }
    }
}
