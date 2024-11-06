using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class SpawnCubeOnMouseClick : MonoBehaviour
{
    [SerializeField]
    private GameObject objectToSpawn = null;
    [SerializeField]
    private LayerMask GroundLayer;

    void Start()
    {
        InputManager.Instance.RegisterOnClick(OnClick);
    }

    void OnDestroy()
    {
        InputManager.Instance.UnregisterOnClick(OnClick);
    }

    void OnClick(InputAction.CallbackContext callbackContext) {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        RaycastHit hitInfo;
        if (objectToSpawn != null &&
            Physics.Raycast(ray, out hitInfo, float.MaxValue, GroundLayer)
        ) {
            GameObject.Instantiate(objectToSpawn, hitInfo.point + Vector3.up * 0.5f, Quaternion.identity);
        }
    }

}
