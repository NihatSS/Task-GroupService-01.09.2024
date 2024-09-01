namespace StudentServiceTask.Models
{
    class Group
    {
        public string Name { get; set; }
        public List<Student> Students { get; set; }

        public override string ToString()
        {
            string students = string.Empty;
            foreach (var student in Students)
            {
                students += $"{student.Name} {student.Surname} {student.Age}\n";
            }
            return $"Group name: {Name} \nStudents: {students}";
        }
    }
}
