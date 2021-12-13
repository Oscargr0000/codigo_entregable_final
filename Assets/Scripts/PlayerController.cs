using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    private float horizontalInput;
    private float verticalInput;
    private float speed = 30f;
    private float speedMove = 10f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        transform.Rotate(Vector3.up * speed * Time.deltaTime * horizontalInput);
        transform.Rotate(Vector3.right * speed * Time.deltaTime * verticalInput);
        transform.Translate(Vector3.forward * speedMove * Time.deltaTime);
    }
}
