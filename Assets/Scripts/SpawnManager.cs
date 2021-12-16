using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    public GameObject obstacle;

    private Vector3 spawnPos;
    private float RandomX;
    private float RandomZ;
    private float RandomY;
    private float RandomNumX = 40;
    private float RandomNumZ = 40;
    private float RandomNumY = 10;
    private float startTimeInst = 4f;
    private float TiempoRep = 4f;


    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(0, 0, 0);


        InvokeRepeating("SpawnObstacle", startTimeInst, TiempoRep);
    }

    public void SpawnObstacle()
    {
        RandomY = Random.Range(-RandomNumY, RandomNumY);
        RandomX = Random.Range(-RandomNumX, RandomNumX);
        RandomZ = Random.Range(-RandomNumZ, RandomNumZ);

        spawnPos = new Vector3(RandomX, RandomY, RandomZ);

        Instantiate(obstacle, spawnPos, obstacle.transform.rotation);
        
    }
   
}
