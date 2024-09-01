using Newtonsoft.Json;
using StudentServiceTask.Models;
using System.Runtime.CompilerServices;

namespace StudentServiceTask.Service
{
    class StudentService
    {
        const string path = @"C:\Users\user\OneDrive\Desktop\pb102_tasks\c#-tasks\StudentServiceTask\StudentServiceTask\groups.json";
        GroupService groupService = new GroupService();

        public Group GetStudents(string groupName)
        {
            var students = groupService.GetGroups().Find(group => group.Name == groupName);
            return students;
        }

        public void AddStudent(Student student, string groupName)
        {
            var group = GetStudents(groupName);
            group.Students.Add(student);
            using (StreamWriter sr = new StreamWriter(path,true))
            {
                var res = JsonConvert.SerializeObject(group);
                sr.WriteLine(res);
            }
        }

        public void DeleteStudent(string studentName, string groupName)
        {
            var group = GetStudents(groupName);
            foreach (var student in group.Students)
            {
                if (student.Name == studentName)
                {
                    group.Students.Remove(student);
                    break;
                }
            }
            using (StreamWriter sr = new StreamWriter(path,true))
            {
                var res = JsonConvert.SerializeObject(group);
                sr.WriteLine(res);
            }
        }
    }
}
