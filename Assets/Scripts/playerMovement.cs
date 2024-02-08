using UnityEngine;



public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed = 3f; // speed of our sprite
    private Rigidbody2D body; // allow our code to understand what body means
    private bool grounded; // boolean for grounded

    private void Awake() // starts only when script is run
    {
        body = GetComponent<Rigidbody2D>(); // this is how we can extract the RigidBody2D object from Unity
    }

    private void Update() // updates every frame
    {
        body.velocity = new Vector2(Input.GetAxis("Horizontal") * speed, body.velocity.y);

        if (Input.GetKey(KeyCode.Space) && grounded) // if space + grounded
            Jump(); // jump
    }

    private void Jump() // jump function
    {
        body.velocity = new Vector2(body.velocity.x, speed); // x doesnt change, y does
        grounded = false; // in air = not ground

    }

    private void OnCollisionEnter2D(Collision2D collision) // collision function
    {

        if (collision.gameObject.tag == "Ground") // if the tag == ground then it's on the ground
        {
            grounded = true; // ground = ground mhm yes



        }
    }
}