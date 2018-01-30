using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateSurprise : MonoBehaviour
{
    [SerializeField] private GameObject surprise;

    void OnTriggerEnter(Collider col)
    {
        if (col.CompareTag("SurpriseTrigger"))
        {
            surprise.SetActive(true);
        }
    }
}
