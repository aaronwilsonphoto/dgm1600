
public float jumpHeight;

// Double Jump Variable
private bool doubleJump;

void Update () {

// Player Flip
	if (GetComponent<Rigidbody2D>() .velocity.x > 0)
		transform.localScale = new Vector3(1f,1f,1f);
	else if (GetComponent<Rigidbody2D>() .velocity.x < 0)
		transform.localScale = new Vector3(-1f,1f,1f);
	
	
// Double Jump
	if(grounded) 
		doubleJump = false;
	
	if (Input.GetKeyDown (KeyCode.Space) && !doubleJump && !grounded) {
		GetComponent<Rigidbody2D>().velocity = new Vector2 (GetComponent<Rigidbody2D>().velocity.x, jumpHeight);
		doubleJump = true;
	}
}