using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class RoadSpawner : MonoBehaviour
{

    public List<GameObject> obstacles;

    // Start is called before the first frame update
    void Start()
    {
        SpawnObstacle();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnObstacle()
    {
        int rand = Random.Range(2,4);
        int randObst = Random.Range(1, obstacles.Count);
        GameObject obstacle = obstacles[randObst]; 
        Transform spawnpoint = transform.GetChild(rand).transform;
        Instantiate(obstacle, spawnpoint.position, Quaternion.identity, transform);
        
    }

    
    

}
