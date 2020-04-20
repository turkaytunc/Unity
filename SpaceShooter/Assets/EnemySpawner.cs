using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private List<WaveConfig> waveConfigs;
    int startingWave = 0;

    void Start()
    {
        WaveConfig currentWave = waveConfigs[startingWave];

        StartCoroutine(SpawnAllEnemies(currentWave));
    }

    private IEnumerator SpawnAllEnemies(WaveConfig currentWave)
    {

        for(int i = 0; i <= currentWave.NumberOfEnemies; i++)
        {
            Instantiate(currentWave.EnemyPrefab, currentWave.GetWayPoints()[0].position, Quaternion.identity);
            yield return new WaitForSeconds(currentWave.TimeBetweenSpawns);
        
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
