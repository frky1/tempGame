using UnityEngine;

public class playerMovement : MonoBehaviour

{

    private Rigidbody2D body;

    private void Awake()

    {
        body = GetComponent<Rigidbody2D>();


    }


}
