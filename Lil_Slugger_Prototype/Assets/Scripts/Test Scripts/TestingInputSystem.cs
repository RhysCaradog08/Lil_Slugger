using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class TestingInputSystem : MonoBehaviour
{
    private Rigidbody rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        //Movement();
    }

    public void Movement(InputAction.CallbackContext context)
    {
        Debug.Log(context);

        Vector2 inputVector = context.ReadValue<Vector2>();
        rb.AddForce(new Vector3(inputVector.x, 0, inputVector.y) * 0.1f, ForceMode.Impulse);
    }

    public void Jump(InputAction.CallbackContext context)
    {
        Debug.Log(context);
        if (context.performed)
        {
            Debug.Log("Jump" + context.phase);
            rb.AddForce(Vector3.up * 3, ForceMode.Impulse);
        }
    }
}
