using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    private float horizontalInput;
    private float verticalInput;
    private float speed = 30f;
    private float speedMove = 10f;
    public GameObject proyectil;
    private Vector3 StartPoint = new Vector3(0, 100, 0);

    // Start is called before the first frame update
    void Start()
    {
        transform.position = StartPoint;
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        transform.Rotate(Vector3.up * speed * Time.deltaTime * horizontalInput);
        transform.Rotate(Vector3.right * speed * Time.deltaTime * verticalInput);
        transform.Translate(Vector3.forward * speedMove * Time.deltaTime);



        if (Input.GetKeyDown(KeyCode.RightControl))
        {
            Instantiate(proyectil, transform.position, proyectil.transform.rotation);
        }
    }
}
