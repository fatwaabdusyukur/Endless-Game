using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Road : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject road;

    Vector3 spawnPoint;

    public static Road instance;

    private void Awake()
    {
        instance = this;
    }

    // Update is called once per frame
    void Start()
    {
        for (int i = 0; i < 100; i++) {
            SpawnRoads();
        }
    }

    public void SpawnRoads() {
        GameObject temp = Instantiate(road, spawnPoint, Quaternion.identity);
        spawnPoint = temp.transform.GetChild(1).transform.position;
    }
}
