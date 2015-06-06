using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour
{

    public float moveSpeed = 100.0f;
    public float rotateSpeed = 5.0f;

	// Use this for initialization
	void Start () 
    {
	
	}
	
	// Update is called once per frame
	void Update () 
    {
	    if (Input.GetKey("w"))
	    {
            transform.Translate((Vector3.forward) * moveSpeed * Time.deltaTime);
	        
	    }
        if (Input.GetKey("s"))
        {
            transform.Translate((Vector3.back) * moveSpeed * Time.deltaTime);
            
        }
        if (Input.GetKey("a"))
        {
            transform.Rotate((Vector3.down) * rotateSpeed );
            
        }
        if (Input.GetKey("d"))
        {
            transform.Rotate((Vector3.up) * rotateSpeed);
            
        }
        if (Input.GetButtonDown("Testing"))
        {
            Debug.Log(Input.GetAxis("Testing"));
            Debug.Log("Pressing Testing key");
        }
        if (Input.GetKeyUp("a"))
        {
            Debug.Log("Pressing A key");
        }
        if (Input.GetMouseButton(1))
        {
            moveSpeed = 20.0f;
            
        }
        if (!Input.GetMouseButton(1))
        {
            moveSpeed = 10.0f;

        }
        if (Input.GetMouseButton(0))
        {
            Debug.Log("Left Mouse Button");
        }
        
	}
}
