using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SurpriseRotation : MonoBehaviour
{
    [SerializeField] float rotationSpeed = 10.0f;

	void Update ()
    {
        transform.RotateAround(transform.position, transform.forward, Time.deltaTime * rotationSpeed);
	}
        
}
