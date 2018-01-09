using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBehavior : MonoBehaviour
{

    [SerializeField] private float totalSpeed = 1f;
    [SerializeField] private float movementSpeed = 0.1f;
    [SerializeField] private float rotationSpeed = 0.5f;

    void Update()
    {

        transform.Translate(Vector3.down * Time.deltaTime * movementSpeed * totalSpeed, Space.World);
        transform.Translate(Vector3.right * Time.deltaTime * movementSpeed * totalSpeed * 0.5f);
        transform.Rotate(Vector3.down * Time.deltaTime * rotationSpeed * totalSpeed, Space.World);
    }
    
}
