using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeSpawner : MonoBehaviour
{
    [SerializeField] private GameObject prefab;
    [SerializeField] private float spawnDelayInSeconds = 3f;

    private void OnEnable()
    {
        StartCoroutine(SpawnPrefabsRoutine());
    }

    private void OnDisable()
    {
        //Cette fonction arrête les coroutines.
        StopAllCoroutines();
    }

    private IEnumerator SpawnPrefabsRoutine()
    {
        while (true)
        {
            yield return new WaitForSeconds(spawnDelayInSeconds);
            SpawnPrefab();
        }
    }

    private void SpawnPrefab()
    {
        Instantiate(prefab, transform.position, Quaternion.identity);
    }


}
