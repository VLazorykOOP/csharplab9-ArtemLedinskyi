using System;
using System.Collections;
using System.IO;
using System.Linq;

namespace Lab9_10CharpT
{
    internal class StudentProcessor1
    {
        public void ProcessStudents1(string filePath)
        {
            Queue successfulStudents = new Queue();
            Queue otherStudents = new Queue();

            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');
                    string[] gradesString = parts[2].Trim().Split(' ');
                    ArrayList grades = new ArrayList(gradesString.Select(int.Parse).ToList());

                    Students1 student = new Students1(parts[0].Trim(), parts[1].Trim(), grades);

                    if (student.isSucsessful())
                    {
                        successfulStudents.Enqueue(student);
                    }
                    else
                    {
                        otherStudents.Enqueue(student);
                    }
                }
            }

            Console.WriteLine("Успішні студенти:");
            foreach (Students1 student in successfulStudents)
            {
                Console.WriteLine($"{student.FullName}, {student.GroupNumber}, {string.Join(" ", student.Grades.Cast<int>())}");
            }

            Console.WriteLine("\nІнші студенти:");
            foreach (Students1 student in otherStudents)
            {
                Console.WriteLine($"{student.FullName}, {student.GroupNumber}, {string.Join(" ", student.Grades.Cast<int>())}");
            }
        }
    }
}