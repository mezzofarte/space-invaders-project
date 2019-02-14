using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UFOCookieManager : MonoBehaviour
{
    public GameObject ufo;                           
    public Transform[] spawnPoints;
    public GameObject enemy;

    void Update()
    {
        if (Random.Range(0, 1000) == 500 && enemy.transform.position.y < 4)
        {
            Instantiate(ufo, spawnPoints[Random.Range(0, spawnPoints.Length)].position, spawnPoints[Random.Range(0, spawnPoints.Length)].rotation);
            Debug.Log("ok");
        }
    }

}
