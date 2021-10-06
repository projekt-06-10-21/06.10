using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int score = 0;
    public Text scoreCounter;
    public GameObject enemyPrefab;

    float spawnInterval = 3;
    float timeSinceLastSpawn = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        scoreCounter.text = score.ToString();
        timeSinceLastSpawn += Time.deltaTime;
        if (timeSinceLastSpawn > spawnInterval)
        {
            Instantiate(enemyPrefab);
            timeSinceLastSpawn = 0;
        }
    }
}
