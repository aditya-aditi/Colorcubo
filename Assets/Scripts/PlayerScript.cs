using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    // Variable for rigidbody
    public Rigidbody rigidbody;

    // Variable to control the movement of the cube
    public float force = 1000f;

    // Variable to control the speed when the cube move right or left
    public float speed = 10f;

    // Variable for staying on the ground
    public float maxX;
    public float minX;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        Vector3 playerPos = transform.position;
        if (playerPos.x<minX) 
        {
            playerPos.x = minX;
        }
        if (playerPos.x > maxX)
        {
            playerPos.x = maxX;
        }
        transform.position = playerPos;

        // Code for taking input from the keyboard
        if(Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            transform.position = transform.position + new Vector3(speed*Time.deltaTime, 0, 0);
        }
        if(Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            transform.position = transform.position - new Vector3(speed * Time.deltaTime, 0, 0);
        }
    }

    private void FixedUpdate()
    {
        // Code for moving the cube forward 
        rigidbody.AddForce(0, 0, force * Time.deltaTime);
    }
}
