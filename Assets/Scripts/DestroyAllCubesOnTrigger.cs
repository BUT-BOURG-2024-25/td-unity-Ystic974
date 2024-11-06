using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAllCubesOnTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other) {

        GameObject[] cubeObjects = GameObject.FindGameObjectsWithTag("Cube");

        DestroyCubeOnCollide[] objectsToDestroy = FindObjectsByType<DestroyCubeOnCollide>(FindObjectsSortMode.None);
        
        foreach (DestroyCubeOnCollide obj in objectsToDestroy)
            Destroy(obj.gameObject);
            
    }
}
