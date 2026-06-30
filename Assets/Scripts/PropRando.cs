using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropRando : MonoBehaviour
{
    public List<GameObject> propSpawnpoints;
    public List<GameObject> propPrefabs;
    // Start is called before the first frame update
    void Start()
    {
        SpawnProps();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnProps()
    {
        foreach (GameObject spawnpoint in propSpawnpoints)
        {
            int randomIndex = Random.Range(0, propPrefabs.Count);
            GameObject prop = Instantiate(propPrefabs[randomIndex], spawnpoint.transform.position, Quaternion.identity);
            prop.transform.parent = spawnpoint.transform;
        }
    }
}
