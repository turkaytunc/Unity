using UnityEngine;

[CreateAssetMenu(menuName = "EnemyConfig")]
public class WaveConfig : ScriptableObject
{

    [SerializeField] private GameObject enemyPrefab;
    [SerializeField] private GameObject pathPrefab;
    [SerializeField] private float timeBetweenSpawns = 0.5f;
    [SerializeField] private float spawnRandomizerTime = 0.3f;
    [SerializeField] private int numberOfEnemies = 5;
    [SerializeField] private float moveSpeed = 5f;

    public GameObject EnemyPrefab { get => enemyPrefab; }
    public GameObject PathPrefab { get => pathPrefab;}
    public float TimeBetweenSpawns { get => timeBetweenSpawns;}
    public float SpawnRandomizerTime { get => spawnRandomizerTime;}
    public int NumberOfEnemies { get => numberOfEnemies;}
    public float MoveSpeed { get => moveSpeed;}
}
