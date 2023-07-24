using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Numbers : MonoBehaviour
{
    int[] mass = { 1, 2, 3, 4, 6, 7, 8, 10, 15 };

    string[] cityes = { "Minsk", "Kiev", "London", "Vitebsk", "Paris", "Los Angeles", "Buenos Aires" };

    int[] numbers = { 1, 2, 3, 4, -6, -8, 10, -25 };

    private void Start()
    {
        FirstCount();
        NameCity();
        NegativeNumbers();
    }

    private void FirstCount() // первое числоn в массиве, которое делится на 5. //Возвращение первого элемента или первого элемента, удовлетворяющего условию
    {
        int first = mass.FirstOrDefault(x => x % 5 == 0);
        Debug.Log($"Первое число в массиве которое делится на '5'   : {first}");
    }

    private void NameCity()// Проверить, есть ли хотя бы один город с длиной имени больше 10 символов.
    {
        bool nameCity = cityes.Any(city => city.Length > 10);
        Debug.Log($"Есть ли город с длиной имени больше 10 символов : {nameCity}");
    }

    private void NegativeNumbers()//Подсчет количества элементов, удовлетворяющих условию.
    {
        int negativeNumbers = numbers.Count(number => number < 0);
        Debug.Log($"Количество отрицательных элементов : {negativeNumbers}");
    }
}
