using System.Collections;

namespace Lab9_10CharpT
{
    internal class StudentComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            Students student1 = x as Students;
            Students student2 = y as Students;

            if (student1 == null || student2 == null)
                throw new InvalidOperationException("One of the objects is not a Student.");

            double average1 = student1.Grades.Cast<int>().Average();
            double average2 = student2.Grades.Cast<int>().Average();

            return average1.CompareTo(average2);
        }
    }
}