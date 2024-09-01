using StudentServiceTask.Models;
using StudentServiceTask.Service;
using System.Reflection.Metadata.Ecma335;

namespace StudentServiceTask.Controller
{
    internal class StudentController
    {
        StudentService student = new StudentService();

        public void ShowStudent(string groupName)
        {
            student.GetStudents(groupName).Students.ForEach(std => Console.WriteLine(std));
        }

        public void Add(string groupName)
        {
            var students = student.GetStudents(groupName);
            Console.WriteLine("Telebenin adini daxil et:");
            string name = Console.ReadLine();
            Console.WriteLine("Telebenin soyadini daxil et:");
            string surname = Console.ReadLine();
            Console.WriteLine("Telebenin yasini daxil et:");
            int age =Convert.ToInt32(Console.ReadLine());
            student.AddStudent(new Student(name,surname,age) ,groupName);
        }

        public void Remove(string groupName)
        {
            var students = student.GetStudents(groupName);
            Console.WriteLine("Silmek istediyiniz telebeyi daxil edin:");
            string name = Console.ReadLine();
            student.DeleteStudent(name,groupName);
        }
       
    }
}
