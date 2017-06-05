using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public float speed = 6.0F;
    public float jumpSpeed = 8.0F;
    public float gravity = 20.0F;
    public float sensitivity = 4;
    private Vector3 moveDirection = Vector3.zero;

    // Use this for initialization
    void Start () {
		
	}
    void Update()
    {
        CharacterController controller = GetComponent<CharacterController>();
        if (controller.isGrounded)
        {
            moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
            moveDirection = transform.TransformDirection(moveDirection);
            moveDirection *= speed;
            if (Input.GetButton("Jump"))
                moveDirection.y = jumpSpeed;

        }
        moveDirection.y -= gravity * Time.deltaTime;
        controller.Move(moveDirection * Time.deltaTime);

        transform.Rotate(new Vector3(0, sensitivity * Input.GetAxis("Mouse X"), 0), Space.World);
        transform.Rotate(new Vector3(-sensitivity*Input.GetAxis("Mouse Y"), 0, 0));
        Debug.Log("transform.rotation : " + transform.rotation.x);
        if (transform.rotation.x > 90) {
            transform.rotation = Quaternion.Euler(new Vector3(90, transform.rotation.eulerAngles.y, transform.rotation.eulerAngles.z));
        }
        if (transform.rotation.x < -90) {
            transform.rotation = Quaternion.Euler(new Vector3(-90, transform.rotation.eulerAngles.y, transform.rotation.eulerAngles.z));
        }
    }
}
