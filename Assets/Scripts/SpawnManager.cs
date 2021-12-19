using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    //Declaracions
    public GameObject obstacle;
    private Vector3 spawnPos;

    //Numeros de Limitador
    private float RandomX;
    private float RandomZ;
    private float RandomY;

    private float RandomNumX = 200f;
    private float RandomNumZ = 200f;
    private float RandomNumY = 100f;
    private float RandomNumYdown = 50f;

    //Datos de Spawn de obstaculos
    private float startTimeInst = 4f;
    private float TiempoRep = 5f;


    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(0, 0, 0);


        InvokeRepeating("SpawnObstacle", startTimeInst, TiempoRep);
    }



    //Spawn de obstaculo y su posición
    public void SpawnObstacle()
    {
        RandomY = Random.Range(RandomNumYdown, RandomNumY);
        RandomX = Random.Range(-RandomNumX, RandomNumX);
        RandomZ = Random.Range(-RandomNumZ, RandomNumZ);

        spawnPos = new Vector3(RandomX, RandomY, RandomZ);

        Instantiate(obstacle, spawnPos, obstacle.transform.rotation);
        
    }
   
}
