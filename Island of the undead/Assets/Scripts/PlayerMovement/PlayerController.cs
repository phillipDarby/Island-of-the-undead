using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{
    private Animator anim;
    public float rotateSpeed;
    public float forwardSpeed;
    public float initialForwardSpeed;
    private float runSpeed;
    private float vert;
    private float horiz;
    private CharacterController playerController;

	// Use this for initialization
	void Start ()
	{
	    playerController = GetComponent<CharacterController>();
        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update ()
	{
        vert = Input.GetAxis("Vertical");
	    horiz = Input.GetAxis("Horizontal");

        anim.SetFloat("walk", vert);
        anim.SetFloat("Strafe",horiz);
	    if ( Input.GetKeyDown("space") && playerController.isGrounded)
	    {
	        playerController.Move(Vector3.up);
	    }

        transform.Rotate(0,Input.GetAxis("Horizontal") * rotateSpeed, 0);
	    Vector3 forward = transform.TransformDirection(Vector3.forward);
	    float speed = forwardSpeed*Input.GetAxis("Vertical");
	    playerController.SimpleMove(speed*forward);

	    if (Input.GetAxis("Run") == 1 && playerController.isGrounded)
	    {
	        runSpeed = forwardSpeed*1.5f;
	        forwardSpeed = runSpeed;
	    }
	    
    }
}
