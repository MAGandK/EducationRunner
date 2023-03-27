using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerFinish : MonoBehaviour
{


    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out PlayerController playerController))
        {
            Debug.Log("Finish");
        }
    }
}
