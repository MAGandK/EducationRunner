using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TriggerCoins : MonoBehaviour
{
    private static int _coinCount = 0;
    
    [SerializeField]
    public TextMeshProUGUI _scoreText;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out PlayerController playerController))
        {
            CollectCoin();

            Destroy(gameObject);
        }
    }

    private void CollectCoin()
    {
        _coinCount++;

        _scoreText.text = _coinCount.ToString();
    }
}