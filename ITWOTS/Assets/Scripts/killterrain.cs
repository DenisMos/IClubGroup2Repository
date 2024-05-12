
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class killterrain : MonoBehaviour
{
    public float yeet;


    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.collider.name);
        var h = collision.gameObject.GetComponentInParent<Health>();
        h.Die();
    }
}
