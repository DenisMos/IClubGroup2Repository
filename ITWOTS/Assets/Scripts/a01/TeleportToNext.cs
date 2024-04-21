using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TeleportToNext : MonoBehaviour
{
    public string TeleportName;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log($"name: {other.name}, TAG: {other.tag}");


        if (other.GetComponentInChildren<PlayerMovement>(true) != null)
        {
            Debug.Log("Scene change");
            SceneManager.LoadScene(TeleportName, LoadSceneMode.Single);
        }
    }

#if UNITY_EDITOR

    private void OnDrawGizmos()
    {
        Gizmos.color = new Color(1f, 1f, 1f, 0.4f);
        Gizmos.DrawCube(transform.position, transform.localScale);
    }

#endif
}
