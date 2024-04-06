using System;


namespace Lab9_10CharpT
{
    internal class Students
    {
        public string FullName { get; set; }
        public string GroupNumber { get; set; }

        public int[] Grades { get; set; }


        public Students(string fullName,string groupNumber, int[] grades) {
            

            FullName = fullName;
            GroupNumber = groupNumber;
            Grades = grades;


        }

        public bool isSucsessful()
        {
            foreach(int grades in Grades)
            {
                if (grades < 4) {

                    return false;

                }
            }
            return true;

            }
        }
    }


