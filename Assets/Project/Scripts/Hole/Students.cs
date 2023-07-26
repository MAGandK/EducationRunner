using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Student
{
    public string Name { get; set; }
    public int Age { get; set; }
    public int Rating { get; set; }
    public string Group { get; set; }
}

public class Students : MonoBehaviour
{
    Student[] students = new Student[]
        {
        new Student{ Name ="Alex", Age = 21, Rating = 85, Group ="Physics" },
        new Student{ Name ="Poman", Age = 18, Rating = 95, Group ="Informatics"},
        new Student{ Name ="Oleg", Age = 19, Rating = 50, Group ="Informatics"},
        new Student{ Name ="Olga", Age = 22, Rating = 67, Group ="Physics"},
        };


    private void Start()
    {
        StudentAge();
        CountStudentsAverageRating();
        BandInformatics();
        CountStudentInBand();
    }

    private void StudentAge()
    {
        var filteredStudentsAge = students.Where(student => student.Age >= 21);

        foreach (var student in filteredStudentsAge)
        {
            Debug.Log($"Студент с возрастом выше 21 : {student.Name}");
        }
    }

    private void CountStudentsAverageRating()//Average - среднее значение
    {
        double averageRating = students.Average(student => student.Rating);

        int countStudentAverageRating = students.Count(student => student.Rating > averageRating);

        Debug.Log($"Средний рейтинг студентов : {averageRating}");
        Debug.Log($"Количество студентов со средним рейтингом : {countStudentAverageRating}");
    }

    private void BandInformatics()
    {
        var informaticsStudents = students.Where(student => student.Group == "Informatics");

        foreach (var student in informaticsStudents)
        {
            Debug.Log($"Студент из группы 'Информатика': {student.Name}");
        }

        if (!informaticsStudents.Any()) //
        {
            Debug.Log("Студенты из группы 'Информатика' не найдены.");
        }
    }

    private void CountStudentInBand()
    {
        var studentsByGroup = students.GroupBy(student => student.Group)
                                      .Select(group => new { Group = group.Key, Count = group.Count() });

        foreach (var groupInfo in studentsByGroup)
        {
            Debug.Log($"Группа: {groupInfo.Group}, Количество студентов: {groupInfo.Count}");
        }
    }
}


