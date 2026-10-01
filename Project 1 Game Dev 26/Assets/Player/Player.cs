using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{

    public InputAction moveaction;

    private Vector2 direction;

    private float speed = 5;

    private Vector3 velocity;

    private CharacterController controller;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        moveaction = InputSystem.actions.FindAction("Move");

        controller = GetComponent<CharacterController>();

    }

    // Update is called once per frame
    void Update()
    {
        direction = moveaction.ReadValue<Vector2>();
        //Debug.Log(direction);

        velocity = new Vector3(direction.x, 0, direction.y) * speed;
    }

    void FixedUpdate()
    {
        controller.Move(velocity * Time.fixedDeltaTime);


    }
}
