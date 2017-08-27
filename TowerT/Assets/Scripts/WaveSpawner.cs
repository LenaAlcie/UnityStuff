using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class WaveSpawner : MonoBehaviour {

    public Transform enemyPrefab;

    public Transform spawnPoint;

    public Text waveCountdownText;
    public Text waveCounter; 

    public float timeBetweenWaves = 5f;

    private float countdown = 2f; //2 seconds before it begins to spawn

    private int waveIndex = 0;

    private int lastWaveIndex = 5;

    private float waitSeconds = 0.5f;

 


    void Update()
    {
        if (countdown <= 0f)
        {
            StartCoroutine(SpawnWave());
            countdown = timeBetweenWaves;
        }
        
        countdown -= Time.deltaTime;//amount time since the last time we draw a frame (1/sec)

        waveCountdownText.text = ("Time to next wave: " +  Mathf.Round(countdown).ToString() );

        waveCounter.text = ("Wave number: " + waveIndex);

    }

    IEnumerator SpawnWave() {

        waveIndex++;

        for (int i = 0; i < waveIndex; i++)
        {

            SpawnEnemy();

            yield return new WaitForSeconds(waitSeconds);

          
        }

        if (waveIndex >= lastWaveIndex)
        {
            StopWaves();
        }
       
    }

    void SpawnEnemy() {

        Instantiate(enemyPrefab, spawnPoint.position, spawnPoint.rotation);
            
    }

    private void StopWaves() {

        waveCountdownText.text = ("Level finished");
        enabled = false;
    }
}
