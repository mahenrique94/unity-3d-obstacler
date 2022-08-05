using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    [SerializeField]
    private Material hitMaterial;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            GetComponent<MeshRenderer>().material = this.hitMaterial;
            gameObject.tag = "Hitted";
        }
        
    }
}
