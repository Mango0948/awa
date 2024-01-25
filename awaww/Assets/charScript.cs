using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class charScript : MonoBehaviour
{

    public Rigidbody2D charRigidbody;
    public float jumpHeight;
    public float movementSpeed;
 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   
        if (Input.GetKeyDown(KeyCode.Space)) {
            charRigidbody.velocity = Vector2.up * jumpHeight;
        }
        if (Input.GetKeyDown(KeyCode.W)) {
            charRigidbody.velocity = Vector2.up * jumpHeight;
        }
        
        if (Input.GetKey(KeyCode.A)) {
            transform.position = transform.position + Vector3.left * movementSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D)) {
            transform.position = transform.position + Vector3.right * movementSpeed * Time.deltaTime;
        }
    }
}
