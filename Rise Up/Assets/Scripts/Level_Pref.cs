using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level_Pref : MonoBehaviour
{
    public GameObject[] prefabs;

    private void Start()
    {
        Instantiate(prefabs[0], new Vector2(0, 17), Quaternion.identity);
        StartCoroutine(SpawnEnemy());
    }

    private void Repeat()
    {
        StartCoroutine(SpawnEnemy());
    }

    IEnumerator SpawnEnemy() 

    {
        yield return new WaitForSeconds(40);

        Instantiate(prefabs[Random.Range(0, 4)], new Vector2(0, 17), Quaternion.identity);
        Repeat();
    }
}
