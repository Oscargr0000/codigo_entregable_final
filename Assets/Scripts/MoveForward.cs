using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{

    private float xzRange = 400;
    private float yRangeup = 300; 
    private float yRangeDown = -100; 
    private float speed = 30f;




    //DESTRUCCION CAJA Y BALA
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Obstacle"))
        {
            Destroy(gameObject);

            Destroy(other.gameObject);
        }
    }


    // Update is called once per frame
    void Update()
    {

        //MOVIMIENTO UNIFORME
        transform.Translate(Vector3.forward * speed * Time.deltaTime);



        //LIMITADORES DE POSICION
        if (transform.position.x > xzRange)
        {
            Destroy(gameObject);
        }
        
        if (transform.position.x < -xzRange)
        {
            Destroy(gameObject);
        }
        
        
        
        if (transform.position.z > xzRange)
        {
            Destroy(gameObject);
        }
 
        
        if (transform.position.z < -xzRange)
        {
            Destroy(gameObject);
        }
        
        
        if (transform.position.z < yRangeDown)
        {
            Destroy(gameObject);
        }
        
        
        if (transform.position.z > yRangeup)
        {
            Destroy(gameObject);
        }

    }

}
