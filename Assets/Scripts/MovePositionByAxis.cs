using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePositionByAxis : MonoBehaviour
{
    [SerializeField]
    private float speed = 5f;

    void Update()
    {
        //movementAxis();
        //movementKeys();
    }

    private void movementAxis() {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(horizontal, 0, vertical) * speed * Time.deltaTime; // smooth and frame-rate-independent movement
        gameObject.transform.Translate(movement);
    }

    private void movementKeys() {
        Vector3 movement = InputManager.Instance.movementInput * speed * Time.deltaTime; // smooth and frame-rate-independent movement
        gameObject.transform.Translate(movement);
    }

}
