using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour {

    [SerializeField]
    private float speed = 10f;

    private Rigidbody rb;

	void Start () {
        rb = GetComponent<Rigidbody>();
	}
	
	
}
