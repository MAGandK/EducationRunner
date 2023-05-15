using UnityEngine;
using UnityEngine.UI;

public class SliderScript : MonoBehaviour
{
    public Slider progressBar;
    public Transform player;
    public Transform levelEnd;

    private float startDistance;
    private float endDistance;

    private void Start()
    {
        startDistance = Vector3.Distance(player.position, levelEnd.position);
        endDistance = 0f;
    }

    private void Update()
    {
        endDistance = Vector3.Distance(player.position, levelEnd.position);
        float progress = 1f - (endDistance / startDistance);
        progressBar.value = progress;
    }
}

