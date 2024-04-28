using UnityEngine;
using System.Collections;

public class ImpulseGunExplosion : MonoBehaviour
{

    public float radius;
    public int power;
    public int count;
    private Vector3 explosionPos;
    private Collider[] colliders;
    private bool impulse;

    void Start()
    {
        ImpulseGun.impulseActive = true;
        explosionPos = transform.position;
        colliders = Physics.OverlapSphere(explosionPos, radius);
        StartCoroutine(Wait());
    }

    void Explosion()
    {
        foreach (Collider hit in colliders)
        {
            if (hit.GetComponent<Rigidbody>() && !hit.CompareTag("Player"))
                hit.transform.GetComponent<Rigidbody>().AddExplosionForce(hit.GetComponent<Rigidbody>().mass * power, explosionPos, radius);
        }
        ImpulseGun.impulseActive = false;
        Destroy(gameObject);
    }

    IEnumerator Wait()
    {
        impulse = true;
        yield return new WaitForSeconds(0.5f);
        StartCoroutine(ImpulseCount());
    }

    IEnumerator ImpulseCount()
    {
        impulse = false;
        foreach (Collider hit in colliders)
        {
            if (hit.GetComponent<Rigidbody>() && !hit.CompareTag("Player"))
            {
                hit.GetComponent<Rigidbody>().Sleep();
                hit.GetComponent<Rigidbody>().WakeUp();
                hit.transform.GetComponent<Rigidbody>().AddExplosionForce(hit.GetComponent<Rigidbody>().mass * 1000, explosionPos, radius);
            }
        }
        yield return new WaitForSeconds(0.5f);
        if (count > 0)
        {
            count--;
            StartCoroutine(Wait());
        }
        else
        {
            Explosion();
        }
    }

    void FixedUpdate()
    {
        if (impulse)
        {
            foreach (Collider hit in colliders)
            {
                if (hit.GetComponent<Rigidbody>() && !hit.CompareTag("Player"))
                {
                    Vector3 direction = hit.GetComponent<Rigidbody>().transform.position - explosionPos;
                    hit.GetComponent<Rigidbody>().AddForceAtPosition(-direction.normalized * hit.GetComponent<Rigidbody>().mass * 100, explosionPos);
                }
            }
        }
    }

}
