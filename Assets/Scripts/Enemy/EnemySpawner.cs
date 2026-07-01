using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [System.Serializable]
    public class wave
    {
        public string waveName;
        public List<GameObject> enemyPrefabs; //list of enemy prefabs to spawn in this wave
        public List<string> enemyName;
        public List<int> enemyCount;
        public int waveQuota; //number of enemies to spawn in this wave
        public float spawnInterval; //time between spawns
        public float spawnCount; //number of enemies already spawned in this wave
    }

    public List<wave> waves; //list of waves to spawn

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
