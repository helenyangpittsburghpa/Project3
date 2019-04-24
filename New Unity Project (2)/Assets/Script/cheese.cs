using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cheese : MonoBehaviour
{
    public AudioSource point;
    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.CompareTag("Ground")||col.gameObject.CompareTag("Enemy"))
        {
            gameObject.SetActive(false);
        }

    }
}
