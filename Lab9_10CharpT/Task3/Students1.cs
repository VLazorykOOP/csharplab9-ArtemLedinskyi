using System;
using System.Collections;

namespace Lab9_10CharpT
{
    internal class Students1 : ICloneable
    {
        public string FullName { get; set; }
        public string GroupNumber { get; set; }
        public ArrayList Grades { get; set; }

        public Students1(string fullName, string groupNumber, ArrayList grades)
        {
            FullName = fullName;
            GroupNumber = groupNumber;
            Grades = grades;
        }

        public object Clone()
        {
            // Глибоке клонування
            ArrayList gradesClone = (ArrayList)Grades.Clone();
            return new Students1(FullName, GroupNumber, gradesClone);
        }

        public bool isSucsessful()
        {
            foreach (int grade in Grades)
            {
                if (grade < 4)
                {
                    return false;
                }
            }
            return true;
        }
    }
}