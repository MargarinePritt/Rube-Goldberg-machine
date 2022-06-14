using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GameController : MonoBehaviour
{
    private GameObject startObject;
    private Rigidbody2D startComponent;
    private GameObject camera0;

    // Start is called before the first frame update
    void Start(){
        startObject=GameObject.Find("Circle");
        startComponent=startObject.GetComponent<Rigidbody2D>();
        startComponent.gravityScale=0;
        camera0=GameObject.Find("Camera");
        camera0.GetComponent<Camera>().enabled=false;
    }

    // Update is called once per frame
    void Update(){
        if(Input.GetKeyUp(KeyCode.Space)){
            startComponent.gravityScale=1;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision){
        if(collision.gameObject.tag=="middleObject"){
            GameObject middleObject=GameObject.FindWithTag("middleObject");
            middleObject.GetComponent<Rigidbody2D>().gravityScale=1;
            Camera.main.enabled=false;
            camera0.GetComponent<Camera>().enabled=true;
        }
    }
}
