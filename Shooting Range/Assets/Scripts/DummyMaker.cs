using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DummyMaker : MonoBehaviour
{

    public GameObject theEnemy;
    public Text Timer;
    public GameObject StartButton;
    public GameObject stopButton;

    public int xPos;
    public int zPos;
    public int enemyCount;
    public int enemyTotal;
    public int targets = 0;
    public bool killedAllEnemies = false;

    public void GameLoad()
    {
        //Debug.Log("Starting!");
        System.Threading.Thread.Sleep(100);
        //Debug.Log("3...");
        System.Threading.Thread.Sleep(100);
        //Debug.Log("2...");
        System.Threading.Thread.Sleep(100);
        //Debug.Log("1...");
        System.Threading.Thread.Sleep(100);
        //Debug.Log("Starting...");
        GameStart();
    }

    void Start()
    {
        targets = enemyTotal;
    }

    void Update()
    {
        GameObject[] enemies = GameObject.FindGameObjectsWithTag("Target");
        targets = enemies.Length;
        if (targets == 0)
        {
            endGame();
        }
    }

    void endGame()
    {
        killedAllEnemies = true;
        if (Timer.GetComponent<StopWatch>().playing == true && killedAllEnemies == true)
        {
            Timer.GetComponent<StopWatch>().ClickStop();
        }
    }

    void GameStart()
    {
        StartCoroutine(EnemyDrop());
    }

    IEnumerator EnemyDrop()
    {
        while (enemyCount < enemyTotal)
        {
            xPos = Random.Range(3, 20);
            zPos = Random.Range(-15, 15);
            Instantiate(theEnemy, new Vector3(xPos, 1, zPos), Quaternion.identity);
            yield return new WaitForSeconds(0.1f);
            enemyCount += 1;
        }
    }
}
