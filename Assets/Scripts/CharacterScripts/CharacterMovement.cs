using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour {

    [SerializeField]
    private float speed = 10f;

    private Rigidbody rb;
    private Transform cameraT;
    private Animator anim;
    private float turnSmoothVelocity;

	void Start () {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
        cameraT = Camera.main.transform;
	}
	
    void FixedUpdate()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        Vector2 input = new Vector2(horizontalInput, verticalInput);
        float angleRotation = (Mathf.Atan2(horizontalInput, verticalInput) * Mathf.Rad2Deg) + cameraT.eulerAngles.y;
        if(input.magnitude > 0)
        {
            transform.eulerAngles = Vector3.up * Mathf.SmoothDampAngle(transform.eulerAngles.y, angleRotation, ref turnSmoothVelocity, 0.5f);
        }        
        Vector3 movement = transform.forward * speed * input.magnitude * Time.deltaTime;        
        rb.MovePosition(rb.position + movement);
        anim.SetFloat("velocity", movement.magnitude);
    }
	
}
