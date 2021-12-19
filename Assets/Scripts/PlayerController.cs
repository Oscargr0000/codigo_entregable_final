using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    
    //AXIS
    private float horizontalInput;
    private float verticalInput;

    //SPEED
    private float speed = 30f;
    private float speedMove = 10f;

    //DECLARACIONES
    public GameObject proyectil;
    private Vector3 StartPoint = new Vector3(0, 100, 0);
    
    //RANGOS DE LIMITACION
    private float xzRange = 200f;
    private float yRangeUp = 200f;
    private float yRangeDown = 0f;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = StartPoint;
    }

    // Update is called once per frame
    void Update()
    {

        //CONTROL DE MOVIMIENTO 
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        transform.Rotate(Vector3.up * speed * Time.deltaTime * horizontalInput);
        transform.Rotate(Vector3.right * speed * Time.deltaTime * verticalInput);
        transform.Translate(Vector3.forward * speedMove * Time.deltaTime);


        //DISPARO

        if (Input.GetKeyDown(KeyCode.RightControl))
        {
            Instantiate(proyectil, transform.position, transform.rotation);
        }



        // LIMITADOR DE DISTACIA EN X

        if (transform.position.x > xzRange)
        {
            transform.position = new Vector3(xzRange, transform.position.y, transform.position.z);
        }


        if (transform.position.x < -xzRange)
        {
            transform.position = new Vector3(-xzRange, transform.position.y, transform.position.z);
        }



        //LIMITADOR DE DISTACIA EN Z

        if (transform.position.z > xzRange)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, xzRange);
        }
        
        if (transform.position.z < -xzRange)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -xzRange);
        }




        //LIMITADOR DE DISTACIA EN 

        if (transform.position.y > yRangeUp)
        {
            transform.position = new Vector3(transform.position.x, yRangeUp, transform.position.z);
        }
        
        if (transform.position.y < yRangeDown)
        {
            transform.position = new Vector3(transform.position.x, yRangeDown, transform.position.z);
        }


        
    }



    //CONTADOR DE MONEDAS - DESAPARECER MONEDAS - PERDER O GANAR
    
    private int Coin = 0;
    private void OnTriggerEnter(Collider other)
    {

        //GANAS
        if (other.gameObject.CompareTag("Coin"))
        {
            Coin += 1;
            Destroy(other.gameObject);
            Debug.Log($"Coins: {Coin}");

            if (Coin == 10)
            {
                Debug.Log($"Has ganado :)");
                Time.timeScale = 0;
            }
        }



        //PIERDES
        if (other.gameObject.CompareTag("Obstacle"))
        {
            Time.timeScale = 0;
            Debug.Log($" Has Perdido :(");

        }

    }




}
