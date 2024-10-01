using UnityEngine;

public class Marble : MonoBehaviour
{
	public Rigidbody rigidbody;
	public float speed = 50f;

    void FixedUpdate()
    {
	    rigidbody.AddTorque(Input.GetAxis("Horizontal") * speed, 0, Input.GetAxis("Vertical") * speed);
    }

    public void Jump()
    {
	    
    }
}
