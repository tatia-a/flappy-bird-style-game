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

    void Start()
    {
        StartCoroutine(SpawnTubes());
    }

    private IEnumerator SpawnTubes()
    {
        while (true)
        {
            yield return new WaitForSeconds(spawnInterval);

            float randomY = Random.Range(lowestPosition, highestPosition);
            Vector3 position = new Vector3(transform.position.x, randomY, transform.position.z);

            Instantiate(tubesPrefab, position, Quaternion.identity);
        }
    }
}
