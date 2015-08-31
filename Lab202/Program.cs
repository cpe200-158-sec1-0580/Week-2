using System;

namespace Lab202
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			/* Testing the Course class */
			Course cpe200 = new Course ("Object-Oriented Programming", "261300");
			Course isne103 = new Course ("Programming Language for ISNE", "269103", "DOME");
			Course cpe453 = new Course ("DIP", "261105", "Dr. Kenneth Cosh", 60);

			Console.WriteLine ("\n--- Initial Courses state ---");
			Console.WriteLine (cpe200);
			Console.WriteLine (isne103);
			Console.WriteLine (cpe453);

			/* playing with cpe200 object */
			Console.WriteLine ("\n--- playing with cpe200 object ---");
			cpe200.CourseID = "261200";
			Console.WriteLine (cpe200);
			cpe200.CourseID = "2612OO";
			cpe200.CourseID = "2612002";

			cpe200.NumStudents = 40;
			Console.WriteLine (cpe200);
			cpe200.MaxStudents = 60;
			Console.WriteLine (cpe200);
			cpe200.NumStudents = 40;
			Console.WriteLine (cpe200);
			cpe200.MaxStudents = 35;
			cpe200.MaxStudents = 40;
			Console.WriteLine (cpe200);

			/* playing with cpe453 object */
			Console.WriteLine ("\n--- playing with cpe453 object ---");
			cpe453.Name = "Digital Image Processing";
			cpe453.CourseID = "261453";
			cpe453.Lecturer = "Sansanee";
			cpe453.MaxStudents = 20;
			Console.WriteLine (cpe453);
            Console.ReadKey();
        }
	}
}
