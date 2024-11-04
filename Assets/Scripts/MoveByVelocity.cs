using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class MoveByVelocity : MonoBehaviour
{
    [SerializeField]
    private float speed = 5f;
    [SerializeField]
    private float jumpForce = 5f;
    [SerializeField]
    private Rigidbody rb;

    void Start()
    {
        InputManager.Instance.RegisterOnJumpInput(jump);
    }

    void OnDestroy()
    {
        InputManager.Instance.UnregisterOnJumpInput(jump);
    }

    void Update()
    {
        Vector3 newVelocity = InputManager.Instance.movementInput * speed;
        newVelocity.y = rb.velocity.y;
        rb.velocity = newVelocity;
    }

    private void jump(InputAction.CallbackContext callbackContext) {
        rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
    }
}
