using UnityEngine;

public class Test : MonoBehaviour
{
    public void Start()
    {
        int[] mas = CreateMass(5);
        
        PrintMass(mas);
    }

    private void PrintMass(int[] mas1)
    {
        for (int i = 0; i < mas1.Length; i++)
        {
            Debug.Log(mas1[i]);
        }
    }

    private int[] CreateMass(int size)
    {
        int[] mas = new int[size];

        for (int i = 0; i < mas.Length; i++)
        {
            mas[i] = Random.Range(0, 10);
        }

        return mas;
    }
}