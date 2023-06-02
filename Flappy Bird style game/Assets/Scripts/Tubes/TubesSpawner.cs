using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TubesSpawner : MonoBehaviour
{
    [SerializeField] private GameObject tubesPrefab;
    [SerializeField] private float spawnInterval = 1;

    // highest position lowest position
    [SerializeField] private float highestPosition = 3.3f;
    [SerializeField] private float lowestPosition = -2.6f;

    [SerializeField] private float speedOfTube = 5f;

    private bool isSpawnEnabled = true;

    void Start()
    {
        tubesPrefab.GetComponent<Tube>().SetSpeed(speedOfTube);
        StartCoroutine(SpawnTubes());       
    }

    private IEnumerator SpawnTubes()
    {
        while (isSpawnEnabled)
        {
            yield return new WaitForSeconds(spawnInterval);

            float randomY = Random.Range(lowestPosition, highestPosition);
            Vector3 position = new Vector3(transform.position.x, randomY, transform.position.z);

            if (isSpawnEnabled)
            {
                Instantiate(tubesPrefab, position, Quaternion.identity);
               
            }
        }
    }

    public void StopSpawn()
    {
        isSpawnEnabled = false;
    }
}
