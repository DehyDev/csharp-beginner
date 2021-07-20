using System;

namespace HasHonors
{
	class Program
	{	
		static bool fHasHonors(Student student)
		{
			if (student.GPA > 3.2) {return true;}
			else {return false;}
		}
		
		public static void Main(string[] args)
		{	
			string sName = Console.ReadLine();
			int sAge = Convert.ToInt32(Console.ReadLine());
			double sGPA = Convert.ToDouble(Console.ReadLine());
			
			Student NewStudent = new Student(sName, sAge, sGPA);
			
			Console.WriteLine(fHasHonors(NewStudent));
			
			Console.ReadLine(); // hacky freeze shit
		}
	}
}

// Student Class

namespace HasHonors
{
	public class Student
	{
		public string Name;
		public int Age;
		public double GPA;
		
		public Student(string aName, int aAge, double aGPA)
		{
			Name = aName;
			Age = aAge;
			GPA = aGPA;
		}
	}
}
