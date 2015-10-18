using UnityEngine;
using System.Collections;

public class one : MonoBehaviour {
	public float jumpHeight;
	public Transform groundCheck;
	public float groundCheckRadius;
	public LayerMask whatIsGround;
	private bool grounded;

	// Use this for initialization
	void Start () 
	{
		
	}
	
	void FixedUpdate () 
	{
		grounded = Physics2D.OverlapCircle(groundCheck.position,groundCheckRadius, whatIsGround);
	}
	
	// Update is called once per frame
	void Update () {
		
		
		if (Input.GetKeyDown (KeyCode.A) && grounded == true) 
		{
			GetComponent<Rigidbody2D>().velocity = new Vector2 (0, jumpHeight);
		}
		
		
	}
}
