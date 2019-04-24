using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ufoEnemy : MonoBehaviour
{
    private NavMeshAgent meshAgent;
    private GameObject target;
    //navmeshagent: https://forum.unity.com/threads/moving-target.509040/
    // Start is called before the first frame update
    void Start()
    {
        meshAgent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        target = GameObject.FindGameObjectWithTag("Player");
        meshAgent.SetDestination(target.transform.position);
    }
    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.CompareTag("Player"))
        {

            gameManager.instance.abducted();
            Debug.Log("health is" + gameManager.instance.getLife());
        }
        if (col.gameObject.CompareTag("cheese"))
        {
           
            gameManager.instance.ufoScore();
            gameObject.SetActive(false);
        }
    }
}
