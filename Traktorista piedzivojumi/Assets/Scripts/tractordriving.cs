using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tractordriving : MonoBehaviour {

	public float speed = 20.0F;
    public float gravity = 20.0F;
    public float rotateSpeed = 3.0F;
	private Vector3 moveDirection = Vector3.zero;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		CharacterController controller = GetComponent<CharacterController>();
		if (controller.isGrounded)
        {
			moveDirection = new Vector3(0, 0, Input.GetAxis("Vertical"));
			moveDirection = transform.TransformDirection(moveDirection);
			moveDirection *= speed;
		}
        //Vector3 moveTractor = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        //controller.Move(moveTractor);
        moveDirection.y -= gravity * Time.deltaTime;
        controller.Move(moveDirection * Time.deltaTime);
        transform.Rotate(0, Input.GetAxis("Horizontal"), 0);
	}
}