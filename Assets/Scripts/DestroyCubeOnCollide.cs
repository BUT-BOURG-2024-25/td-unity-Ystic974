using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyCubeOnCollide : MonoBehaviour
{
    public void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.CompareTag("Player"))
            Destroy(gameObject);
    }
}
