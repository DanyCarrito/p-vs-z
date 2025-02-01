using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiate : MonoBehaviour
{
    public Transform spawnPoint;
    public GameObject enemyPrefab;
    public float timer;
    public float timerSpawn;

    // Start is called before the first frame update
    void Start()
    {
        timer = timerSpawn;
         Instantiate(enemyPrefab, spawnPoint.position, spawnPoint.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        timerSpawn -= Time.deltaTime;
        if (timerSpawn <= 0) 
        {
            GameObject enemy = Instantiate(enemyPrefab, spawnPoint.position, spawnPoint.rotation);
            timerSpawn = timer;
        }
        

    }
}
