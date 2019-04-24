using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class gameManager : MonoBehaviour
{
    //Where I get the idea for this assignment: https://www.youtube.com/watch?v=uM_M1ct554U
    public static gameManager instance = null;

    private Pooler cheesePooler;
    private Pooler enemyPooler;
    private Pooler ufoPooler;
    private Pooler coinPooler;
    

    public GameObject player;

    public GameObject abduction;
    public GameObject gameOver;
    public GameObject instruction;
    public GameObject gameWin;

    public Text lifeCounter;
    private int health;
    bool keepLife = false;

    private static int score;
    public Text scoreCounter;
    bool keepScore = false;

    public AudioSource crash;
    public AudioSource point;
    public AudioSource coin;
    // Start is called before the first frame update
    void Start()
    {
        health = 5;
        Debug.Log("health is 5");
        GetReferences();
        score = 0;
    }

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != null)
        {
            Destroy(gameObject);
        }
    }

    public void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }//https://answers.unity.com/questions/1261937/creating-a-restart-button.html

    public void minusHealth()
    {
        Debug.Log("helth");
        if (!keepLife)
        {
            crash.Play();
            health = health - 1;
            Debug.Log("health is goes down");
        }
        if (health <= 0)
        {
            EndGame();
            //gameObject.GetComponent<AudioSource>().Play();
        }
        updateUILife();
    }
    public void abducted()
    {
        if(!keepLife)
        {
            health = 0;
        }
        ufoAbducted();
        updateUILife();
    }

    void ufoAbducted()
    {
        abduction.SetActive(true);
    }
    // Update is called once per frame
    void Update()
    {

    }

    public void open()
    {
        instruction.SetActive(true);
    }
    public void close()
    {
        instruction.SetActive(false);
    }
    public void WinGame()
    {
        gameWin.SetActive(true);
        keepLife = true;
    }
    private void EndGame()
    {
        //gameOverUI();
        gameOver.SetActive(true);
    }

        void GetReferences()
    {
        cheesePooler = GameObject.Find("cheesePool").GetComponent<Pooler>();
        enemyPooler = GameObject.Find("enemyPool").GetComponent<Pooler>();
        ufoPooler = GameObject.Find("ufoPool").GetComponent<Pooler>();
        coinPooler = GameObject.Find("coinPool").GetComponent<Pooler>();
    }
    public Pooler getCheesePool()
    {
        return cheesePooler;
    }
    public Pooler getEnemyPool()
    {
        return enemyPooler;
    }
    public Pooler getUfoPool()
    {
        return ufoPooler;
    }
    public Pooler getCoinPool()
    {
        return coinPooler;
    }


    public void dromeScore()
    {
        if (!keepScore)
        {
            point.Play();
            score =  score + 5;
            //Debug.Log("Score is: " +getScore());       
        }
        updateUI();
    }

    public void coinScore()
    {
        if (!keepScore)
        {
            coin.Play();
            score = score + 1;
        }
        updateUI();
    }

    public void ufoScore()
    {
        if (!keepScore)
        {
            point.Play();
            score = score + 10;
        }
        updateUI();
    }

    public int getScore()
    {
        return score;
    }
    void updateUI()
    {
        scoreCounter.text = "Points: " + score+"/20";
    }
    public int getLife()
    {
        return health;
    }

    void updateUILife()
    {
        lifeCounter.text = "Lives: " + health;
        Debug.Log("Lives is" + health);
    }

}
