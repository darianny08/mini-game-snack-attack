using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] TomatoPrefabs;

    private float spawnLimitXLeft = -3;
    private float spawnLimitXRight = 3;
    private float spawnPosY = 3.79f;

    private float startDelay = 1.0f;
    private float spawnInterval = 4.0f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomTomato", startDelay, spawnInterval);
    }

    // Spawn random ball at random x position at top of play area
    void SpawnRandomTomato ()
    {
        // Generate random ball index and random spawn position
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);

        // instantiate ball at random spawn location
        Instantiate(TomatoPrefabs[0], spawnPos, TomatoPrefabs[0].transform.rotation);
    }

}
