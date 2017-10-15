using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour {

    private Rigidbody rb;
    private Animator anim;

    public Rigidbody RigidBody { get { return rb; } }
    public Animator Animator { get { return anim; } }

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();
    }
	
}
