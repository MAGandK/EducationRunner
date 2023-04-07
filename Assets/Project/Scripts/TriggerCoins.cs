using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerCoins : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out PlayerController playerController))
        {
            playerController.CollectCoin();

            Destroy(gameObject);
        }
    }
}
