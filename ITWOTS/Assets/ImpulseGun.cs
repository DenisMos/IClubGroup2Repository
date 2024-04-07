using UnityEngine;
using System.Collections;
using UnityEngine.Rendering;

public class ImpulseGun : MonoBehaviour
{

    public static bool impulseActive;
    public int impulseForce = 1500;
    public float impulseRadius = 15f;
    public int impulseCount = 3;
    public float impulseDistance = 7f;
    public float maxDistance = 30f;
    public GameObject impulseExplosion;

    void Start()
    {
        impulseActive = false;
    }

    void Update()
    {
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(transform.position);
        if (Physics.Raycast(ray, out hit))
        {
            if (Input.GetMouseButtonDown(0))
            {
                if (hit.rigidbody)
                {
                    if (hit.distance < impulseDistance)
                    {
                        hit.rigidbody.AddForce(ray.direction * impulseForce / hit.rigidbody.mass);
                    }
                    else
                    {
                        Debug.Log("Объект в не зоне действия!");
                    }
                }
            }
            else if (Input.GetMouseButtonDown(1))
            {
                if (!impulseActive)
                {
                    if (hit.distance < maxDistance)
                    {
                        GameObject clone = Instantiate(impulseExplosion, hit.point, Quaternion.identity) as GameObject;
                        clone.GetComponent<ImpulseGunExplosion>().power = impulseForce;
                        clone.GetComponent<ImpulseGunExplosion>().count = impulseCount;
                        clone.GetComponent<ImpulseGunExplosion>().radius = impulseRadius;
                    }
                    else
                    {
                        Debug.Log("Превышен лимит дистанции!");
                    }
                }
                else
                {
                    Debug.Log("Оружие активно!");
                }
            }
        }
    }
}

