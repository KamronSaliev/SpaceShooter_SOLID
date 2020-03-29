using UnityEngine;

public class EnemyManager : Observer
{
    private bool _canSpawn = true;
    
    private readonly int _maxEnemiesSpawn = 10;
    private readonly int _nextSpawn = 15;
    private float _lastSpawn;
    private GameObject[] _spawnPoints;

    public GameObject[] EnemyPrefabs;

    private void Start()
    {
        _spawnPoints = GameObject.FindGameObjectsWithTag("SpawnPoint");
        SpawnEnemies();
    }

    private void Update()
    {
        if (_lastSpawn + _nextSpawn < Time.time && _canSpawn)
            SpawnEnemies();
    }

    private void SpawnEnemies()
    {
        _lastSpawn = Time.time;
        for (var i = 0; i <= Random.Range(0, _maxEnemiesSpawn); i++)
            SpawnEnemy();
    }

    private void SpawnEnemy()
    {
        var prefab = EnemyPrefabs[Random.Range(0, EnemyPrefabs.Length)];
        var spawn = _spawnPoints[Random.Range(0, _spawnPoints.Length)].transform;
        var startPosition = spawn.position;
        Instantiate(prefab, startPosition, prefab.transform.rotation);
    }

    public override void Notify()
    {
        _canSpawn = false;
    }
}