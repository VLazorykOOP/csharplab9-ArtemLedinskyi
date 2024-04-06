using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9_10CharpT
{
    internal class StudentProcessor
    {
        public void ProccessStudents(string filePath)
        {
        Queue<Students>successfulStudents = new Queue<Students>();
        Queue<Students>otherStudents = new Queue<Students>();

            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');
                    string[] gradesString = parts[2].Trim().Split(' ');
                    int[] grades = Array.ConvertAll(gradesString, int.Parse);
                    
                    Students students = new Students(parts[0].Trim(), parts[1].Trim(),grades);

                    if (students.isSucsessful())
                    {
                        successfulStudents.Enqueue(students);
                    }
                    else
                    {
                        otherStudents.Enqueue(students);
                    }
                }

            }

            Console.WriteLine("Успішні студенти: ");
            foreach(Students students in successfulStudents)
            {
                Console.WriteLine($"{students.FullName}, {students.GroupNumber}, {string.Join(" ", students.Grades)}");
            }


            Console.WriteLine("Інші студенти: ");
            foreach(Students students in otherStudents) {
                Console.WriteLine($"{students.FullName}, {students.GroupNumber}, {string.Join(" ", students.Grades)}");
                    
                    }
        }
        

    }
}
