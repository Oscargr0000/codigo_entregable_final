using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationCOin1 : MonoBehaviour
{
    public float speed = 40f;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.right * speed * Time.deltaTime);
    }
}
