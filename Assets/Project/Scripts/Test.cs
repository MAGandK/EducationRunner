using UnityEngine;

public class Test : MonoBehaviour
{


    public void Start()
    {
        //AddElementsFirst(5);

        //ClearArray(5);
        int[] mas = { 1, 7, 3, 4, 5 };
        //RemovesOddElements(5);
        PrintEventElements(mas);
        PrintOddElements(mas);
    }

    private void PrintMass(int[] mas)
    {
        for (int i = 0; i < mas.Length; i++)
        {
            Debug.Log(mas[i]);
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

    private void PrintEventElements(int[] mas)// выводит четный элемент(число)
    {
        for (int i = 0; i < mas.Length; i++)
        {
            if (mas[i] % 2 == 0)
            {
                Debug.Log(mas[i]);
            }
        }
    }

    private void PrintOddElements(int[] mas)// выводит нечетный элемент
    {
        for (int i = 0; i < mas.Length; i++)
        {
            if (mas[i] % 2 != 0)
            {
                Debug.Log(mas[i]);
            }
        }
    }

    //Удаляет каждый нечетный элемент
    private void RemovesOddElements(int size)
    {
        int[] mas = CreateMass(size);

        Debug.Log("Исходный массив:");
        PrintMass(mas);

        int evenCount = 0;
        for (int i = 0; i < mas.Length; i++)
        {
            if (mas[i] % 2 == 0)
            {
                evenCount++;
            }
        }

        int[] evenMas = new int[evenCount];
        // Копируем четные элементы в новый массив
        int j = 0;
        for (int i = 0; i < mas.Length; i++)
        {
            if (mas[i] % 2 == 0)
            {
                evenMas[j] = mas[i];
                j++;
            }
        }

        // Выводим измененный массив
        Debug.Log("Массив после удаления нечетных элементов:");
        PrintMass(mas);
    }

        //Добавляет в начало массива три числа
        private void AddElementsFirst(int size) 
    {
        int[] mas = CreateMass(size);

        Debug.Log("Исходный массив:");
        PrintMass(mas);


        int[] newMass = new int[mas.Length + 3];

        newMass[0] = 1;
        newMass[1] = 2;
        newMass[2] = 3;

        for (int i = 0; i < mas.Length; i++)
        {
            newMass[i + 3] = mas[i];
        }

        Debug.Log("Массив с добавлением:");
        PrintMass(newMass);
    }

    //Отчищает массив 
    private void ClearArray(int size)
    {
        int[] masArray = CreateMass(5);

        Debug.Log("Исходный массив:");
        PrintMass(masArray);

        for (int i = 0; i < masArray.Length; i++)
        {
            masArray[i] = 0;
        }

        Debug.Log("Массив очистили:");
        PrintMass(masArray);
    }
}