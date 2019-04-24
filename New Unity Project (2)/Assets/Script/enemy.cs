using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class enemy : MonoBehaviour
{
    //navmeshagent: https://forum.unity.com/threads/moving-target.509040/
    private NavMeshAgent meshAgent;
    private GameObject target;
    // Start is called before the first frame update
    void Start()
    {
        meshAgent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        //transform.LookAt(target);
        target = GameObject.FindGameObjectWithTag("Player");
        meshAgent.SetDestination(target.transform.position);


    }

    private void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.CompareTag("Player"))
        {
           
            gameObject.SetActive(false);
            gameManager.instance.minusHealth();
            Debug.Log("health is" + gameManager.instance.getLife());
        }
        if (col.gameObject.CompareTag("cheese"))
        {
            gameManager.instance.dromeScore();
            gameObject.SetActive(false);
        }
    }
}

  