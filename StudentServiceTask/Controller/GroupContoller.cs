using Newtonsoft.Json;
using StudentServiceTask.Models;
using StudentServiceTask.Service;
using System.IO;

namespace StudentServiceTask.Controller
{
    internal class GroupContoller
    {
        StudentController student = new StudentController();
        GroupService groups = new GroupService();
        const string path = @"C:\Users\user\OneDrive\Desktop\pb102_tasks\c#-tasks\StudentServiceTask\StudentServiceTask\groups.json";


        public void ShowGroup()
        {
            groups.GetGroups().ForEach(g => Console.WriteLine(g));
        }

        public void AddGroup()
        {
            Console.WriteLine("Grupun adini daxil edin:");
            string groupName = Console.ReadLine();
            Group grp = new Group { Name = groupName, Students = new List<Student>()};
            groups.AddGroup(grp);
        }

        public void Remove()
        {
            Console.WriteLine("Silmek istediyiniz qrupun adini daxil edin:");
            string group = Console.ReadLine();
            groups.RemoveGroup(group);
        }


        public void GoGroup()
        {
            Console.WriteLine("Daxil olmaq istediyiniz grupun adini daxil edin:");
            string groupName = Console.ReadLine();
            if (groups.GoToGroup(groupName) != null)
            {
                bool isContinue = true;
                do
                {
                    A: Console.WriteLine("1-Telebelere bax\n2-Telebe elave et\n3-Telebe sil\n4-Geri qayit");
                    char operation = Console.ReadKey().KeyChar;
                    Console.WriteLine();
                    switch (operation)
                    {
                        case '1':
                            student.ShowStudent(groupName);
                            break;
                        case '2':
                            student.Add(groupName);
                            break;
                        case '3':
                            student.Remove(groupName);
                            break;
                        case '4':
                            isContinue = false;
                            Console.Clear();
                            break;
                        default:
                            Console.WriteLine("Emeliyyati duzgun daxil edin:");
                            goto A;
                    }

                }while( isContinue);
            }
        }
    }
}
