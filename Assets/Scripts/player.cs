using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    float speed = 20f;
    public int hp = 100;


    // Start is called before the first frame update
    void Start()
    {
        transform.position = GameObject.FindGameObjectWithTag("manager").transform.position;

        //make Main Camera's rotation same as this object's rotation
        GameObject.FindGameObjectWithTag("MainCamera").transform.rotation = transform.rotation;


    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Input.GetAxis("Horizontal") * Time.deltaTime * speed, 0f, Input.GetAxis("Vertical") * Time.deltaTime * speed);


        transform.Rotate(0f, Input.GetAxis("Mouse X") * 5f, 0f);


    }

    
    

}
