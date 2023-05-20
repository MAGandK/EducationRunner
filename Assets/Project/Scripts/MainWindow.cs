using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MainWindow : WindowBace
{
    [SerializeField]
    private Slider progressBar;
    [SerializeField]
    private Transform player;
    [SerializeField]
    private Transform levelEnd;
    [SerializeField]
    private float _offsetZ;
    [SerializeField]
    public TextMeshProUGUI _scoreText;


    private int _coinCount = 0;
    private float startDistance;
    private float endDistance;
    private Vector3 _endPositionOffset;

    public override int Index
    {
        get
        {
            return 0;
        }
    }


    private void Start()
    {
        _endPositionOffset = new Vector3(0, 0, _offsetZ);
        startDistance = Vector3.Distance(player.position, levelEnd.position - _endPositionOffset);
        endDistance = 0f;
    }

    private void Update()
    {
        _endPositionOffset = new Vector3(0, 0, _offsetZ);
        endDistance = Vector3.Distance(player.position, levelEnd.position - _endPositionOffset);
        float progress = 1f - (endDistance / startDistance);
        progressBar.value = progress;
    }


    public void OnCoinCollected()
    {
        _coinCount++;

        _scoreText.text = _coinCount.ToString();
    }

    

    
}
