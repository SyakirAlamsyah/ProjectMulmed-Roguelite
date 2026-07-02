using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [System.Serializable]
    public class Wave
    {
        public string waveName;
        public List<EnemyGroup> EnemyGroups;
        public int waveQuota;
        public float waveInterval;
        public int spawnCount;
    }

    [System.Serializable]
    public class EnemyGroup
    {
        public string enemyname;
        public int enemycount;
        public int spawncount;
        public GameObject enemyPrefab;
    }

    public List<Wave> waves;
    public int currentWaveCount;

    [Header("Wave Settings")]
    float spawnTime;

    Transform player;

    // Start is called before the first frame update
    void Start()
    {
        CalculateWaveQuota();
        player = FindObjectOfType<PlayerStats>().transform; 
    }

    // Update is called once per frame
    void Update()
    {

        spawnTime += Time.deltaTime;

        if(spawnTime >= waves[currentWaveCount].waveInterval)
        {
            spawnTime = 0f;
            SpawnEnemy();
        }
    }

    void CalculateWaveQuota()
    {
        int currentWaveQuota = 0;
        foreach (var EnemyGroups in waves[currentWaveCount].EnemyGroups)
        {
            currentWaveQuota += EnemyGroups.enemycount;
        }
        waves[currentWaveCount].waveQuota = currentWaveQuota;
        Debug.Log("Current Wave Quota: " + currentWaveQuota);
    }

    void SpawnEnemy()
    {
        if (waves[currentWaveCount].spawnCount < waves[currentWaveCount].waveQuota)
        {
            foreach (var EnemyGroups in waves[currentWaveCount].EnemyGroups)
            {
                if (EnemyGroups.spawncount < EnemyGroups.enemycount)
                {
                    Vector2 spawnPosition = new Vector2(player.transform.position.x + Random.Range(-10f, 10f), player.transform.position.y + Random.Range(-10f, 10f));
                    Instantiate(EnemyGroups.enemyPrefab, spawnPosition, Quaternion.identity);

                    EnemyGroups.spawncount++;
                    waves[currentWaveCount].spawnCount++;
                }
            }
        }
    }
}
