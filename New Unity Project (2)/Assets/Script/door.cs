using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class door : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.CompareTag("Player") && gameManager.instance.getScore() <= 19)
        {

            gameManager.instance.open();
            //gameObject.SetActive(false);
            Debug.Log("Obstacle collided");
        }
        if (col.gameObject.CompareTag("Player") && gameManager.instance.getScore() >= 20)
        {
            gameManager.instance.WinGame();
        }
    }
}
