using Newtonsoft.Json;
using StudentServiceTask.Models;

namespace StudentServiceTask.Service
{
    class GroupService
    {
        const string path = @"C:\Users\user\OneDrive\Desktop\pb102_tasks\c#-tasks\StudentServiceTask\StudentServiceTask\groups.json";
        public List<Group> GetGroups()
        {
            using(StreamReader sr = new StreamReader(path))
            {
                var result  = JsonConvert.DeserializeObject<List<Group>>(sr.ReadToEnd());
                return result ?? new List<Group>();
            }
        }
        public void AddGroup(Group group)
        {
            var groups = GetGroups();
            groups.Add(group);
            using (StreamWriter sr = new StreamWriter(path))
            {
                sr.WriteLine(JsonConvert.SerializeObject(groups));
            }
        }

        public void RemoveGroup(string groupName)
        {
            var groups = GetGroups();
            var group = groups.Where(group => group.Name != groupName);
            
            using (StreamWriter sr = new StreamWriter(path))
            {
                var res = JsonConvert.SerializeObject(group);
                sr.WriteLine(res);
            }
        }


        public Group GoToGroup(string groupName)
        {
            var groups = GetGroups();
            foreach (var group in groups)
            {
                if (group.Name == groupName)
                {
                    return group;
                }
            }
            return null;
        }
    }
}
