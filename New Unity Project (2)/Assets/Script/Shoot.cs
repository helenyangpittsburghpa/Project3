using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shoot : MonoBehaviour
{
    gameManager gameManager;
    //public GameObject cheese;
    public AudioSource throws;

    public Pooler cheese;
    float startTime;
    Vector3 newForce;

    float launchForce;
    float maxForce = 10f;
    float maxTime = 1f;

    public RectTransform meter;
    
    void Awake()
    {
        gameManager = gameManager.instance;
    }
    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.J)) {
            startTime = Time.time;
        }

        if (Input.GetKey(KeyCode.J)) {
            float pressKeyTime = Time.time - startTime;
            launchForce = maxForce*((pressKeyTime%maxTime)/maxTime);
            meter.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, launchForce*10f);
        }

        if (Input.GetKeyUp(KeyCode.J))
        {
            throws.Play();
            meter.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, 0f);
            if (cheese == null)
            {
                cheese = gameManager.getCheesePool();
            }
            GameObject cheesePool = cheese.getPooledObject();
            if (cheese != null)
            {
                
                Debug.Log("CHeese");
                cheesePool.SetActive(true);
                cheesePool.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z) + transform.forward*0.4f + transform.up;
                newForce = (transform.up*2f + transform.forward) * launchForce;
                cheesePool.GetComponent<Rigidbody>().velocity = Vector3.zero;
                cheesePool.GetComponent<Rigidbody>().AddForce(newForce, ForceMode.Impulse);
            }
        }

        }
}



