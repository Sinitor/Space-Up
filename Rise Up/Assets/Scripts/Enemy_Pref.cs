using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Pref : MonoBehaviour
{
    public GameObject[] prefabs;

    private void Start()
    {
        Instantiate(prefabs[0], new Vector2(0, 15), Quaternion.identity);
        StartCoroutine(SpawnEnemy());
    }

    private void Repeat()
    {
        StartCoroutine(SpawnEnemy());
    }

    IEnumerator SpawnEnemy()

    {
        yield return new WaitForSeconds(6);

        Instantiate(prefabs[Random.Range(0, 5)], new Vector2(0, 15), Quaternion.identity);
        Repeat();
    }
}
