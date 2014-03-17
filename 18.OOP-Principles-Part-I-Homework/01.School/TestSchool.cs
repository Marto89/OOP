/*We are given a school. In the school there are classes of students. Each class has a set of teachers. Each teacher teaches a set of disciplines. Students have name and unique class number. Classes have unique text identifier. Teachers have name. Disciplines have name, number of lectures and number of exercises. Both teachers and students are people. Students, classes, teachers and disciplines could have optional comments (free text block).
	Your task is to identify the classes (in terms of  OOP) and their attributes and operations, encapsulate their fields, define the class hierarchy and create a class diagram with Visual Studio.
*/
using System;

namespace _01.School
{
	class TestSchool
	{
		static School newSchool()
		{
			School eg = new School();
			int classCount = int.Parse(Console.ReadLine());
			for (int i = 0; i < classCount; i++)
			{
				Class newClass = new Class(Console.ReadLine());
				eg.Classes.Add(newClass);
				int studentCoount = int.Parse(Console.ReadLine());
				for (int n = 0; n < studentCoount; n++)
				{
					string[] array = Console.ReadLine().Split(' ');
					Student student = new Student(array[0], int.Parse(array[1]));
					newClass.Students.Add(student);
				}
				int techerCount = int.Parse(Console.ReadLine());
				for (int k = 0; k < techerCount; k++)
				{
					Teacher teacher = new Teacher(Console.ReadLine());
					newClass.Teachers.Add(teacher);
					int disciplineCount = int.Parse(Console.ReadLine());
					for (int g = 0; g < disciplineCount; g++)
					{
						string[] array = Console.ReadLine().Split(' ');
						Disciplines discipline = new Disciplines(array[0], int.Parse(array[1]), int.Parse(array[2]));
						teacher.NumberOfDisc.Add(discipline);
					}
				}
			}
			Console.WriteLine();
			return eg;
		}
		static void Main()
		{
			School eg = newSchool();

			Console.WriteLine(eg.ToString());
		}
	}
}
