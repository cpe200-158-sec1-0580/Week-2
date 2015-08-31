using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab202
{
    class Course
    {
        private String _Name;
        private String _CourseID;
        private String _Lec;
        private int _Max;
        private int _Num;

        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        public string CourseID
        {
            get { return _CourseID; }
            set
            {
                if (IsDigitsOnly(value) != false)
                {
                    if (value.Length < 7 && _CourseID != value)
                        _CourseID = value;
                    else
                        Console.WriteLine("" + CourseID + " : error try setting invalid CourseID");

                }
                else
                    Console.WriteLine("" + CourseID + " : error try setting invalid CourseID");


            }



        }
        public string Lecturer
        {
            get { return _Lec; }
            set { _Lec = value; }
        }

        public int MaxStudents
        {
            get { return _Max; }
            set
            {
                if (value > 0 && value <= 80 && value >= _Num)
                    _Max = value;
                else
                    Console.WriteLine("" + CourseID + ": error try setting invalid Max No. Students!");
            }


        }
        public int NumStudents
        {

            get { return _Num; }
            set
            {
                if (value >= 0 && value < MaxStudents)
                    _Num = value;
                else
                    Console.WriteLine("" + CourseID + ": error try setting invalid No. Students!");
            }
        }
        public Course(string n, string id)
        {
            Name = n;
            CourseID = id;
            Lecturer = "staff";
            MaxStudents = 30;
            NumStudents = 0;
        }
        public Course(string n, string id, string lec)
        {
            Name = n;
            CourseID = id;
            Lecturer = lec;
            MaxStudents = 30;
            NumStudents = 0;
        }
        public Course(string n, string id, string lec, int max)
        {
            Name = n;
            CourseID = id;
            Lecturer = lec;
            MaxStudents = max;
            NumStudents = 0;
        }
        public override string ToString()
        {
            
            string s = "[Course: " + Name + " (" + CourseID + "), Lecturer=" + Lecturer + ", has " + NumStudents + " students, max= " + MaxStudents + "]";
            return s;
        }
        bool IsDigitsOnly(string str)
        {
            foreach (char c in str)
            {
                if (c < '0' || c > '9')
                    return false;
            }

            return true;
        }

    }
}
      