using UnityEngine;
using System.Collections;

public class WaveSpawner : MonoBehaviour {

    public Transform enemyPrefab;

    public Transform spawnPoint;

    public float timeBetweenWaves = 5f;

    private float countdown = 2f; //2 seconds before it begins to spawn

    private int waveIndex = 0;

    private float waitSeconds = 0.5f;


     void Update()
    {
        if (countdown <= 0f)
        {
            StartCoroutine(SpawnWave());
            countdown = timeBetweenWaves;
        }

        countdown -= Time.deltaTime;
    }

    IEnumerator SpawnWave() {

        waveIndex++;

        for (int i = 0; i < waveIndex; i++)
        {

            SpawnEnemy();
            yield return new WaitForSeconds(waitSeconds);
        }
        
    }

    void SpawnEnemy() {

        Instantiate(enemyPrefab, spawnPoint.position, spawnPoint.rotation);
            
    }
}
