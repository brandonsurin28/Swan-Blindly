using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Consumable : MonoBehaviour
{
    [SerializeField] private BoxCollider bCollider;

    private void Update()
    {
        //insert stuff
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
    }
}
