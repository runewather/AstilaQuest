using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class CharacterCamera : MonoBehaviour {

    [SerializeField]
    private Transform playerTransform;

    [SerializeField]
    private float mouseSensitivity = 2f;

    [SerializeField]
    private float distance = 30;

    private float yaw;    
    private Vector3 cameraDistance;    

	void Start ()
    {
        cameraDistance = playerTransform.position - transform.position;
    }
		
	void FixedUpdate ()
    {
        yaw = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        transform.RotateAround(playerTransform.position, Vector3.up, yaw);        
        transform.position = playerTransform.position - transform.forward * distance;        
	}

    void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawLine(playerTransform.position, transform.position);
    }

}
