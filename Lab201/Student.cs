using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lab201

{
    class Student
    {
        private String _Name;
        private String _StudentID;
        private int _YearOfBirth;
        private bool _isActive = false;

        public override string ToString()
        {
            string s = "[Student: " + Name + " (" + StudentID + ") , age=" + getAge() + ", ";
            if (_isActive)
                s += "is active student]";
            else
                s += "is NOT active student]";
            return s;
        }
        public Student()
        {
            _Name = "John Doe";
            _StudentID = "Unknown";
            _YearOfBirth = 1995;
            _isActive = false;
        }
        public Student(String Name, String StudentID)
        {
            _Name = Name;
            _StudentID = StudentID;
            _YearOfBirth = 1995;
            _isActive = true;
        }
        public Student(String Name, String StudentID, int YearOfBirth)
        {
            _Name = Name;
            _StudentID = StudentID;
            _YearOfBirth = YearOfBirth;
            _isActive = true;
        }
        public Student(String Name, String StudentID, int YearOfBirth, bool isActive)
        {
            _Name = Name;
            _StudentID = StudentID;
            _YearOfBirth = YearOfBirth;
            _isActive = true;
        }
        public String Name
        {
            get
            {
                return _Name;
            }
            set
            {
                _Name = value;
            }
        }
        public String StudentID
        {
            get
            {
                return _StudentID;
            }
            set
            {
                if (value.Length != 5)
                {
                    Console.WriteLine(_StudentID + ": error try setting invalid StudentID!");
                }

                else
                    _StudentID = value;
            }

        }
        public int YearOfBirth
        {
            get
            {
                return _YearOfBirth;
            }
            set
            {
                if (value < 1950 || value > 2000)
                {
                    Console.WriteLine(_StudentID + ": error try setting invalid year-of-birth value!");
                }

                else
                    _YearOfBirth = value;
            }
        }
        public bool isActive
        {
            get
            {
                return _isActive;
            }
            set
            {
                _isActive = value;
            }
        }
        public int getAge()
        {
            return 2015 - _YearOfBirth;

        }
    }


    public class Class1
{
	public Class1()
	{
	}
}
