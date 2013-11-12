using UnityEngine;
using System.Collections;

public class JuanMovement : MonoBehaviour {
	
	
	public float movementSpeed = 5;
	public JuanAttack attack;
	
	// Use this for initialization
	
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
		if (Input.GetKeyDown(KeyCode.Y))
		{
			attack.Attack();
		}
	
	}
	
	
	void FixedUpdate()
	{
		Transform cameraTransform = Camera.main.transform;
	
		Vector3 forward = cameraTransform.TransformDirection(Vector3.forward);
		forward.y = 0;
		forward = forward.normalized;
		
		Vector3 right = new Vector3(forward.z, 0, -forward.x);
		
		float v = Input.GetAxisRaw("Vertical");
		float h = Input.GetAxisRaw("Horizontal");
		
		Vector3 targetDirection = h * right + v * forward;
		targetDirection.Normalize();
		
		if (targetDirection.magnitude>0)
		{
			rigidbody.velocity = targetDirection * movementSpeed + new Vector3(0,rigidbody.velocity.y,0);
			transform.forward = targetDirection;
		}
	}
}
