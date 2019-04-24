using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    gameManager gameManager;
    public Pooler ufo;
    public Pooler enemy;
    public Pooler coin;
    // Start is called before the first frame update
    /*void Start()
    {
        
    }*/

    // Update is called once per frame
    void Update()
    {
        objectSpawn();
    }
    void objectSpawn()
    {
        if(ufo == null)
        {
            ufo = gameManager.getUfoPool();
        }
        if (enemy == null)
        {
            enemy = gameManager.getEnemyPool();
        }
        if(coin ==null)
        {
            coin = gameManager.getCoinPool();
        }
        GameObject enemies = enemy.getPooledObject();
        GameObject ufos = ufo.getPooledObject();
        GameObject coins = coin.getPooledObject();

        if (enemies != null)
        {
            enemies.SetActive(true);
           // enemies.GetComponent<Rigidbody>().position = Vector3.zero;
            enemies.transform.position = new Vector3(transform.position.x + Random.Range(-100f, 100f), transform.position.y, transform.position.z + Random.Range(-100f, 100f));
            
        }
        if(ufos != null)
        {
            ufos.transform.position = new Vector3(transform.position.x + Random.Range(-100f,100f), transform.position.y + 14f, transform.position.z + Random.Range(-100f, 100f));
            ufos.SetActive(true);
        }
        if(coins != null)
        {
            coins.transform.position = new Vector3(transform.position.x + Random.Range(-100f, 100f), transform.position.y + 2f, transform.position.z + Random.Range(-100f, 100f));
            coins.SetActive(true);
        }
        
    }
}
