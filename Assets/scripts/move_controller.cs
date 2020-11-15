//using System;
//using System.Linq;

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move_controller : MonoBehaviour
{
    public float speed;
    public float jumpHeight = 50.0f;
    public Transform position;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float x_position = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
        float y_position = Input.GetAxis("Vertical") * Time.deltaTime * speed;
        float jump = Input.GetAxis("Jump") * Time.deltaTime * jumpHeight;

        position.position = new Vector3(x_position, jump, y_position);
        //position.localScale = new Vector3(x_position, 1, y_position);
    }
}
