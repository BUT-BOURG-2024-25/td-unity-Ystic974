using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour
{
    [SerializeField]
    private InputActionReference MovementAction = null;
    [SerializeField]
    private InputActionReference JumpAction = null;

    private static InputManager _instance = null;
    public static InputManager Instance { get { return _instance; } }

    public Vector3 movementInput { get; private set; }

    private void Awake() {
        if(_instance == null)
            _instance = this;
        else
            Destroy(gameObject);
    }

    void Update()
    {
        Vector2 moveInput = MovementAction.action.ReadValue<Vector2>();
        movementInput = new Vector3(moveInput.x, 0, moveInput.y);
    }

    public void RegisterOnJumpInput(Action<InputAction.CallbackContext> onJumpAction) {
        JumpAction.action.performed += onJumpAction;
    }

    public void UnregisterOnJumpInput(Action<InputAction.CallbackContext> onJumpAction) {
        JumpAction.action.performed -= onJumpAction;
    }
}
